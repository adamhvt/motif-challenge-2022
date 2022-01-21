using DrawingPackage.Interfaces;
using System.Collections.Generic;

namespace DrawingPackage
{
    public class WidgetRepository : IWidgetRepository
    {
        private readonly List<IWidget> _widgets = new List<IWidget>();

        public void Add(IWidget widget)
        {
            _widgets.Add(widget);
        }

        public IEnumerable<IWidget> GetWidgets()
        {
            return new List<IWidget>(_widgets);
        }
    }
}
