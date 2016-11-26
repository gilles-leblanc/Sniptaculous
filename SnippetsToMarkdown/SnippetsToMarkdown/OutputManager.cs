using SnippetsToMarkdown.Builders;
using System.Collections.Generic;

namespace SnippetsToMarkdown
{
    class OutputManager
    {
        private List<IBuilder> builders;

        public OutputManager()
        {
            builders = new List<IBuilder>
            {
                new MarkdownBuilder(),
                new HtmlBuilder(),
            };
        }

        internal void AddWriteHeaderCommand(string directory)
        {
            builders.ForEach(x => x.AddWriteHeaderCommand(directory));
        }

        internal void AddTableLineCommand(string shortcut, string title)
        {
            builders.ForEach(x => x.AddTableLineCommand(shortcut, title));
        }

        internal void AddFooterCommand()
        {
            builders.ForEach(x => x.AddFooterCommand());
        }

        internal void WriteOutput()
        {
            builders.ForEach(x => x.WriteOutput());
        }
    }
}
