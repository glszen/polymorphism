    public class BaseGeometricShape
    {

    public int width;

    public int height;

        public virtual void calculateArea()
        {
            int area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
 
    public class Square : BaseGeometricShape
    {
        public override void calculateArea()
        {
            int area = width * height;
            Console.WriteLine("Square area is: " + area );
        }
    }

    public class Rectangle : BaseGeometricShape
    {
        public override void calculateArea()
        {
            int area = width * height;
            Console.WriteLine("Reactangle area is: " + area);
        }
    }

    public class rightTriangle: BaseGeometricShape
    {
        public override void calculateArea()
        {
            int area = (width * height) / 2;
            Console.WriteLine("Right Triangle area is: " + area);
        }
    }

