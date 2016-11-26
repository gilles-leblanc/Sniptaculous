using SnippetsToMarkdown.Commands;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace SnippetsToMarkdown.Builders
{
    class HtmlBuilder : IBuilder
    {
        private static List<ICommand> commands;
        private static StringBuilder output;

        public HtmlBuilder()
        {
            output = new StringBuilder();
            commands = new List<ICommand>();
        }

        public void AddFooterCommand()
        {
            commands.Add(new WriteFooterHtmlCommand());
        }

        public void AddTableLineCommand(string shortcut, string title)
        {
            commands.Add(new WriteTableLineHtmlCommand(shortcut, title));
        }

        public void AddWriteHeaderCommand(string directory)
        {
            commands.Add(new WriteHeaderHtmlCommand(directory));
        }

        public void WriteOutput()
        {
            commands.ForEach(command => command.WriteToOutput(output));

            string pathToOutputFile = ConfigurationManager.AppSettings["pathToOutputFile"];
            File.WriteAllText(pathToOutputFile + ".html", output.ToString());
        }
    }
}
