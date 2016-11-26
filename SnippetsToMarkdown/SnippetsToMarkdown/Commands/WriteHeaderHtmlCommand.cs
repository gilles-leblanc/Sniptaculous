using System.Text;

namespace SnippetsToMarkdown.Commands
{
    class WriteHeaderHtmlCommand : ICommand
    {
        private string directory;

        public WriteHeaderHtmlCommand(string directory)
        {
            this.directory = directory;
        }            

        public void WriteToOutput(StringBuilder output)
        {
            output.AppendLine("<h4>" + directory.Substring(directory.LastIndexOf('\\') + 1) + "</h4>");
            output.AppendLine("<br />");
            output.AppendLine("<table>");

            output.AppendLine("<thead>");
            output.AppendLine("<tr>");
            output.AppendLine("<td>Shortcut</td>");
            output.AppendLine("<td>Name</td>");
            output.AppendLine("</tr>");
            output.AppendLine("</thead>");

            output.AppendLine("<tbody>");            
        }
    }
}
