namespace Markdown2HTMLLib
{
    public interface IMarkdownConverter
    {
        bool IsInlineConverter();
        bool CanConvert(string input);
        string Convert(string input);
    }
}