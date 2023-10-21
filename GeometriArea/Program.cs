
namespace GeometriArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri;

            Rectangle myRectangle = new Rectangle();
            geometri = myRectangle;
            double rectangleArea = geometri.Area();
            Console.WriteLine($"The rectangle's area: {rectangleArea:0.##}");

            Circle myCircle = new Circle();
            geometri = myCircle;
            double circleArea = geometri.Area();
            Console.WriteLine($"The circle's area: {circleArea:0.##}");

            Parallellogram myParallellogram = new Parallellogram();
            geometri = myParallellogram;
            double parallellogramArea = geometri.Area();
            Console.WriteLine($"The parallellogram's area: {parallellogramArea:0.##}");

            Ellipse myEllipse = new Ellipse();
            geometri = myEllipse;
            double ellipseArea = geometri.Area();
            Console.WriteLine($"The ellipse's area: {ellipseArea:0.##}");

            Square mySquare = new Square();
            geometri = mySquare;
            double squareArea = geometri.Area();
            Console.WriteLine($"The square's area: {squareArea:0.##}");


        }
    }
}