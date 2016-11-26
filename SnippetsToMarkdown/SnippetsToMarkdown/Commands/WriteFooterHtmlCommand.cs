using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteFooterHtmlCommand : ICommand
    {
        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine("</tbody></table>");
            output.AppendLine("<br />");
        }
    }
}
