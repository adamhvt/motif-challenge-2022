using DrawingPackage.Widgets;

namespace DrawingPackage
{
    interface ICanvas
    {
        public void AddWidget(Widget widget);
        public void Draw();
    }
}
