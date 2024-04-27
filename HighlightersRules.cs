using System.Text.RegularExpressions;

namespace SyntaxHighlighterCS
{
    enum HighlighterOptions
    {
        JSON, XML, SQL, Cpp
    }

    internal class HighlighterRules : HighlighterBase
    {
        private HighlighterOptions option;
        public HighlighterRules(RichTextBox richTextBox) : base(richTextBox, Color.White) { }

        public void SelectOption(HighlighterOptions select)
        {
            option = select;
        }

        protected override void Highlight()
        {
            switch (option)
            {
                case HighlighterOptions.JSON:
                    HighlightPattern(@"\b(true|false|null)\b", Color.DeepSkyBlue);
                    HighlightPattern(@"""(.*)""\s*:", Color.LightGreen);
                    HighlightPattern(@":\s*"".*""", Color.LightSalmon);
                    HighlightPattern(@":", Color.LightYellow);
                    break;
                case HighlighterOptions.XML:
                    HighlightPattern(@"<[!?]?[^<>]+?[!?]?>", Color.DeepSkyBlue); 
                    HighlightPattern(@"(?<=\s)\w+=(?=""|')", Color.LightYellow);
                    HighlightPattern(@"""[^""]*""", Color.LightSalmon); 
                    HighlightPattern(@"<!--.*?-->", Color.Gray, RegexOptions.Singleline, FontStyle.Italic);
                    break;
                case HighlighterOptions.SQL:
                    HighlightPattern(@"\b(SELECT|UPDATE|DELETE|INSERT|FROM|WHERE|AND|OR|NOT|IN|AS|LIKE)\b",
                        Color.DeepSkyBlue, RegexOptions.IgnoreCase, FontStyle.Bold);
                    HighlightPattern(@"'[^']*'", Color.OrangeRed);
                    HighlightPattern(@"--.*$", Color.Green, RegexOptions.Multiline, FontStyle.Italic);
                    break;
                case HighlighterOptions.Cpp:
                    HighlightPattern(@"\b(int|char|float|double|void|class|struct|if|else|while|for|return|break|continue|public|private|protected|static|const)\b",
                        Color.DeepSkyBlue, RegexOptions.None, FontStyle.Bold);
                    HighlightPattern(@"\""[^\""]*\""", Color.LightSalmon);
                    HighlightPattern(@"\#.*", Color.LightGray, RegexOptions.Multiline);
                    HighlightPattern(@"//.*$", Color.Green, RegexOptions.Multiline, FontStyle.Italic);
                    HighlightPattern(@"/\*.*?\*/", Color.Green, RegexOptions.Singleline, FontStyle.Italic); 
                    break;
            }
        }
    }
}
