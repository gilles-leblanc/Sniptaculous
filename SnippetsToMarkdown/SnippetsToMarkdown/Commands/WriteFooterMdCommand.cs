using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteFooterMdCommand : ICommand
    {
        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine();
        }
    }
}
