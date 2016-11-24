using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteEmptyLineCommand : ICommand
    {
        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine();
        }
    }
}
