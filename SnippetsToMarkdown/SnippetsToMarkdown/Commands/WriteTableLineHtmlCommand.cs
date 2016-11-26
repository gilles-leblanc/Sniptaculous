using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteTableLineHtmlCommand : ICommand
    {
        private string shortcut, title;

        public WriteTableLineHtmlCommand(string shortcut, string title)
        {
            this.shortcut = shortcut;
            this.title = title;
        }

        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine(string.Format("<tr> <td>{0}</td> <td>{1}</td> </tr>", shortcut, title));
        }
    }
}
