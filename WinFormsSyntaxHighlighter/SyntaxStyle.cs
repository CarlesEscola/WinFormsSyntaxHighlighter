using System.Drawing;

namespace WinFormsSyntaxHighlighter
{
    public class SyntaxStyle
    {
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public Color Color { get; set; }

        #region CE.2020-04-09.START: add background color

        public Color BackColor { get; set; } = Color.Empty;

        public bool HasBackColor()
        {
            if (BackColor == Color.Empty)
                return false;
            else
                return true;
        }

        public SyntaxStyle(Color color, Color backColor, bool bold, bool italic)
            : this(color, bold, italic)
        {
            BackColor = backColor;
        }

        #endregion

        public SyntaxStyle(Color color, bool bold, bool italic)
        {
            Color = color;
            Bold = bold;
            Italic = italic;
        }

        public SyntaxStyle(Color color)
            : this(color, false, false)
        {
        }
    }
}
