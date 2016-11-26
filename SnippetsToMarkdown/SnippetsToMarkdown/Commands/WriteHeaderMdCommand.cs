using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteHeaderMdCommand : ICommand
    {
        private string directory;

        public WriteHeaderMdCommand(string directory)
        {
            this.directory = directory;
        }            

        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine();
            output.AppendLine("### " + directory.Substring(directory.LastIndexOf('\\') + 1));
            output.AppendLine();
            output.AppendLine("| Shortcut    | Name                  |");
            output.AppendLine("|-------------|-----------------------|");
        }
    }
}
