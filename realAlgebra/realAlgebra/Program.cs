using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShapeArealip.Class1;

namespace realAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("Welcome to RealAlgebra!");

                    Console.WriteLine("Please choose a shape:");
                    Console.WriteLine("1. Rectangle");
                    Console.WriteLine("2. Square");
                    Console.WriteLine("3. Circle");
                    Console.WriteLine("4. Triangle");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the length of the rectangle:");
                            double length = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the width of the rectangle:");
                            double width = Convert.ToDouble(Console.ReadLine());

                            Rectangle rectangle = new Rectangle();
                            double rectangleArea = rectangle.Area(length, width);
                            Console.WriteLine("The area of the rectangle is: " + rectangleArea);
                            break;

                        case 2:
                            Console.WriteLine("Enter the side length of the square:");
                            double side = Convert.ToDouble(Console.ReadLine());

                            Square square = new Square();
                            double squareArea = square.Area(side);
                            Console.WriteLine("The area of the square is: " + squareArea);
                            break;

                        case 3:
                            Console.WriteLine("Enter the radius of the circle:");
                            double radius = Convert.ToDouble(Console.ReadLine());

                            Circle circle = new Circle();
                            double circleArea = circle.Area(radius);
                            Console.WriteLine("The area of the circle is: " + circleArea);
                            break;

                        case 4:
                            Console.WriteLine("Enter the base length of the triangle:");
                            double baseLength = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the height of the triangle:");
                            double height = Convert.ToDouble(Console.ReadLine());

                            Triangle triangle = new Triangle();
                            double triangleArea = triangle.Area(baseLength, height);
                            Console.WriteLine("The area of the triangle is: " + triangleArea);
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}