using System;
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

        static void Main(string[] args)
        {
            output = new StringBuilder();

            string pathToSnippets = ConfigurationManager.AppSettings["pathToSnippets"];
            string currentDirectory = Environment.CurrentDirectory;

            CollectSnippets(currentDirectory + pathToSnippets);
            WriteOutput();
        }        

        static void CollectSnippets(string pathToSnippets)
        {           
            try
            {
                foreach (string directory in Directory.GetDirectories(pathToSnippets))
                {
                    WriteSnippetsTableForDirectory(directory);
                    CollectSnippets(directory);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private static void WriteSnippetsTableForDirectory(string directory)
        {
            WriteSnippetCategoryHeader(directory);

            foreach (string file in Directory.GetFiles(directory, "*.snippet"))
            {
                WriteSnippetTableLine(file);
            }

            output.AppendLine();
        }

        private static void WriteSnippetTableLine(string file)
        {
            var xmlDocument = XDocument.Load(file);
            var xns = xmlDocument.Root.Name.Namespace;

            var snippet = (from header in xmlDocument.Root.Descendants(xns + "Header")
                           select new
                           {
                               Shortcut = header.Element(xns +"Shortcut").Value,
                               Title = header.Element(xns + "Title").Value
                           }).Single();

            output.AppendLine(string.Format("| {0}           | {1}                      |", snippet.Shortcut, snippet.Title));
        }

        private static void WriteSnippetCategoryHeader(string directory)
        {
            output.AppendLine();
            output.AppendLine("### " + directory.Substring(directory.LastIndexOf('\\') + 1));
            output.AppendLine();
            output.AppendLine("| Shortcut    | Name                  |");
            output.AppendLine("|-------------|-----------------------|");
        }

        private static void WriteOutput()
        {
            string pathToOutputFile = ConfigurationManager.AppSettings["pathToOutputFile"];
            File.WriteAllText(pathToOutputFile, output.ToString());
        }
    }
}
