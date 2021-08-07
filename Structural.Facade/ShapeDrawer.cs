using Structural.Facade.Shapes;

namespace Structural.Facade
{
    public class ShapeDrawer
    {
        public void Draw(string shapeName)
        {
            IShape shape;

            switch (shapeName)
            {
                case "circle":
                    shape = new Circle();
                    break;
                case "square":
                    shape = new Square();
                    break;
                case "triangle":
                    shape = new Triangle();
                    break;
                default:
                    shape = new Circle();
                    break;
            }

            shape.Draw();
        }
    }
}
