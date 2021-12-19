using System;

namespace CSharp.Activity.Polymorphism
{
    public abstract class Shape : IPrintable
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Please enter width!");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter lenght");


            double length = Convert.ToDouble(Console.ReadLine());
            double result = length * width;

            Console.WriteLine($"Rectangle area is {result}.");

            Console.WriteLine("Please enter radius!");

            double radius = Convert.ToDouble(Console.ReadLine());


            double result2 = radius * radius * 3.14;

            Console.WriteLine($"Circle area is {result2}.");
        }




        public double Area  //. public double Area – property with get and protected set accessors to hold 
                            // the area of the shape.
        {


            get
            {

                return Area;
            }



            protected set
            {
              
                Area = value;
            }
        }
        public abstract void CalculateArea(double radius, double area);
        public abstract void CalculateArea(double length, double width, double area);



    }



    public interface IPrintable

    {
        void Print();
      



    }

    public class Rectangle : Shape
    {

        public double Length
        {
            get
            {
               
                   return Length;
            
            }
            protected set
            {
                if (Length <= 0)
                    throw new IndexOutOfRangeException("Invalid index, number can be only positive");

                else
                    return;
            }
        }

        public double Width
        {
            get
            {
                return Width;
            }
            protected set
            {
                if (Width <= 0)
                    throw new IndexOutOfRangeException("Invalid index, number can be only positive");

                else
                    return;
            }
        }
        public Rectangle(double length, double width) //constructor which 
                                                      // initializes the length and width of the rectangle.
        {
            this.Length = length;
            this.Width = width;

         




        }


        public override double CalculateArea(double length, double width, double area) //overridden method to compute the 
                                                                                       // area of the rectangle.
        {
            area = length * width;


            throw new NotImplementedException();







        }

        public void Print(double area)

        {
            Console.WriteLine("The Rectangle area is:", area);
        }





        public override double CalculateArea(double radius, double area)
        {
            throw new NotImplementedException();
        }









    }

    public class Circle : Shape
    {

        public double Radius
        {

            get
            {
                return Radius;
            }
            protected set
            {
                if (Radius <= 0)
                    throw new IndexOutOfRangeException("Invalid index, number can be only positive");

                else
                    return;
            }

        }
        public Circle(double radius)
        {
            this.Radius = radius;
          
        }

        public override double CalculateArea(double radius, double area)
        {

            area = radius * radius * 3.14;

            throw new NotImplementedException();
        }

        public void Print(double area)
        {

            Console.WriteLine("The Circle area is:", area);

            // interface method implementation to display the area 
            //  of the circle.This method should contain text which would identify that the method of the Circle class has been invoked.

        }

        public override double CalculateArea(double length, double width, double area)
        {
            throw new NotImplementedException();
        }
    }

}


