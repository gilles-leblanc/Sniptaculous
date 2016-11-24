using System.Text;

namespace SnippetsToMarkdown.Commands
{
    interface ICommand
    {
        void WriteToOutput(StringBuilder output);
    }
}
