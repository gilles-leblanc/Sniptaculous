using SnippetsToMarkdown.Commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SnippetsToMarkdown
{
    class Program
    {
        private static StringBuilder output;
        private static List<ICommand> commands;

        static void Main(string[] args)
        {
            output = new StringBuilder();
            commands = new List<ICommand>();

            string pathToSnippets = ConfigurationManager.AppSettings["pathToSnippets"];
            string currentDirectory = Environment.CurrentDirectory;

            CollectSnippetsCommands(currentDirectory + pathToSnippets);
            RunCommands();
            WriteOutput();
        }        

        static void CollectSnippetsCommands(string pathToSnippets)
        {           
            try
            {
                foreach (string directory in Directory.GetDirectories(pathToSnippets))
                {
                    CreateOutputCommandsForDirectory(directory);
                    CollectSnippetsCommands(directory);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private static void CreateOutputCommandsForDirectory(string directory)
        {
            commands.Add(new WriteHeaderCommand(directory));

            var files = Directory.GetFiles(directory, "*.snippet");
            files.Select(file =>
            {
                var xmlDocument = XDocument.Load(file);
                var xns = xmlDocument.Root.Name.Namespace;

                return (from header in xmlDocument.Root.Descendants(xns + "Header")
                        select new
                        {
                            Shortcut = header.Element(xns + "Shortcut").Value,
                            Title = header.Element(xns + "Title").Value
                        }).Single();
            }).OrderBy(snippet => snippet.Shortcut)
              .ToList()
              .ForEach(snippet => commands.Add(new WriteSnippetTableLineCommand(snippet.Shortcut, snippet.Title)));

            commands.Add(new WriteEmptyLineCommand());
        }

        private static void RunCommands()
        {
            commands.ForEach(command => command.WriteToOutput(output));
        }

        private static void WriteOutput()
        {
            string pathToOutputFile = ConfigurationManager.AppSettings["pathToOutputFile"];
            File.WriteAllText(pathToOutputFile, output.ToString());
        }        
    }
}
