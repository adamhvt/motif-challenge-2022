using DrawingPackage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage
{
    public class WidgetRepository : IWidgetRepository
    {
        private List<IWidget> Widgets = new List<IWidget>();
        public void Add(IWidget widget)
        {
            Widgets.Add(widget);
        }

        public IEnumerable<IWidget> GetWidgets()
        {
            return Widgets;
        }
    }
}
