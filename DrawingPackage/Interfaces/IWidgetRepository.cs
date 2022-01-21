using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage.Interfaces
{
    /// <summary>
    /// Repository for Widgets
    /// </summary>
    interface IWidgetRepository
    {
        public void Add(IWidget widget);
        public IEnumerable<IWidget> GetWidgets();
    }
}
