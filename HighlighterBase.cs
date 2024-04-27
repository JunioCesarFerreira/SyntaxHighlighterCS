using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SyntaxHighlighterCS
{
    internal abstract class HighlighterBase
    {
        private readonly RichTextBox _richTextBox;
        private readonly Color _defaultFontColor;

        public HighlighterBase(RichTextBox richTextBox, Color defaultFont)
        {
            _richTextBox = richTextBox;
            _defaultFontColor = defaultFont;
        }

        protected abstract void Highlight();

        public void HighlightSyntax()
        {
            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            SendMessage(_richTextBox.Handle, WM_SETREDRAW, false, 0);

            _richTextBox.SelectAll();
            _richTextBox.SelectionColor = _defaultFontColor;
            _richTextBox.SelectionFont = new Font(_richTextBox.Font, FontStyle.Regular);

            Highlight();

            _richTextBox.Select(selectionStart, selectionLength);
            _richTextBox.ScrollToCaret();

            SendMessage(_richTextBox.Handle, WM_SETREDRAW, true, 0);
            _richTextBox.Invalidate();
        }

        protected void HighlightPattern(string pattern, Color color, RegexOptions options = RegexOptions.None, FontStyle fontStyle = FontStyle.Regular)
        {
            foreach (Match match in Regex.Matches(_richTextBox.Text, pattern, options))
            {
                _richTextBox.Select(match.Index, match.Length);
                _richTextBox.SelectionColor = color;
                _richTextBox.SelectionFont = new Font(_richTextBox.Font, fontStyle);
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);
        private const int WM_SETREDRAW = 0x000B;
    }
}
