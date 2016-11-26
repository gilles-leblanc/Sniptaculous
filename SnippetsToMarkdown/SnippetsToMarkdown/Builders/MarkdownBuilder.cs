using SnippetsToMarkdown.Commands;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace SnippetsToMarkdown.Builders
{
    class MarkdownBuilder : IBuilder
    {
        private static List<ICommand> commands;
        private static StringBuilder output;

        public MarkdownBuilder()
        {
            output = new StringBuilder();
            commands = new List<ICommand>();
        }

        public void AddFooterCommand()
        {
            commands.Add(new WriteFooterMdCommand());
        }

        public void AddTableLineCommand(string shortcut, string title)
        {
            commands.Add(new WriteTableLineMdCommand(shortcut, title));
        }

        public void AddWriteHeaderCommand(string directory)
        {
            commands.Add(new WriteHeaderMdCommand(directory));
        }

        public void WriteOutput()
        {
            commands.ForEach(command => command.WriteToOutput(output));

            string pathToOutputFile = ConfigurationManager.AppSettings["pathToOutputFile"];
            File.WriteAllText(pathToOutputFile + ".md", output.ToString());
        }
    }
}
