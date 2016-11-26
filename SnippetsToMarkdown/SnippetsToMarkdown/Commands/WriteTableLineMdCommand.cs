using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteTableLineMdCommand : ICommand
    {
        private string shortcut, title;

        public WriteTableLineMdCommand(string shortcut, string title)
        {
            this.shortcut = shortcut;
            this.title = title;
        }

        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine(string.Format("| {0}           | {1}                      |", shortcut, title));
        }
    }
}
