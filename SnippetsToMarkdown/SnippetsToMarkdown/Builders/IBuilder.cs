namespace SnippetsToMarkdown.Builders
{
    interface IBuilder
    {
        void AddWriteHeaderCommand(string directory);
        void AddTableLineCommand(string shortcut, string title);
        void AddFooterCommand();
        void WriteOutput();
    }
}
