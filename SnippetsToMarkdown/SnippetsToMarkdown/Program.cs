using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace SnippetsToMarkdown
{
    class Program
    {
        private static OutputManager outputManager;

        static void Main(string[] args)
        {
            outputManager = new OutputManager();
            
            string pathToSnippets = ConfigurationManager.AppSettings["pathToSnippets"];
            string currentDirectory = Environment.CurrentDirectory;

            CollectSnippetsCommands(currentDirectory + pathToSnippets);
            outputManager.WriteOutput();
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
            outputManager.AddWriteHeaderCommand(directory);            

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
              .ForEach(snippet => outputManager.AddTableLineCommand(snippet.Shortcut, snippet.Title));

            outputManager.AddFooterCommand();
        }
    }
}
