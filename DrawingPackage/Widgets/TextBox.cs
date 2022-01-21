using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage.Widgets
{
    public class Textbox : Rectangle
    {
        public string Text { get; set; }

        public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height)
        {
            Text = RequireNonEmpty(text, nameof(text));
        }

        public override string ToString()
        {
            return $"{base.ToString()} text=\"{Text}\"";
        }
    }
}
