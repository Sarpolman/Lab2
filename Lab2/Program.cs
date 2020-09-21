using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class GeomFigure
    {
        public abstract double Area();
    }
    interface IPrint
    {
        void Print();
    }
    class Rectangle :GeomFigure, IPrint
    {
        public double width { get; set; }
        public double height { get; set; }

        
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height; 
        }

        public override double Area()
        {
            return width * height;
        }
       public override string ToString()
        {
            return $"Ширина:{width} Высота:{height} Площадь прямоугольника:{Area()}";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        
    }

    class Square : Rectangle, IPrint
    {

        public Square(double width) : base(width,width)
        {
        }
        public override double Area()
        {
            return width * width;
        }

        public override string ToString()
        {
            return $"Длина стороны:{width}  Площадь квадрата:{Area()}";
        }
        new public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Circle : GeomFigure, IPrint
    {

        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Радиус:{radius}  Площадь круга:{Area()}";
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ширшов А.С ИУ5-35Б");
            Console.ResetColor();
            Rectangle Pryamougolnik = new Rectangle(2, 4);
            var Krug = new Circle(4);
            var Kvadrat = new Square(5);
            Pryamougolnik.Print();
            Kvadrat.Print();
            Krug.Print();
            Console.ReadKey();
        }
    }
}
