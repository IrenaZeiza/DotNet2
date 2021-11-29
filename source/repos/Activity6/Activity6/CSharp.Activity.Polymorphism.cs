using System;

namespace CSharp.Activity.Polymorphism
{
    public abstract class Shape : IPrintable
    {
        static void Main(string[] args)
        {



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
                return;
            }
        }
        public abstract void CalculateArea(double radius);
        public abstract void CalculateArea(double length, double width, double area1);



    }



    public interface IPrintable

    {
        void Print()
        {
            // length =
            // width =

            //    Console.WriteLine("Please enter width!");
          //  width = Convert.ToDouble(Console.ReadLine());

            //   double length = Convert.ToInt32(Console.ReadLine());

            //    double length = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Please enter lenght");
            //    Console.ReadLine();

            //    Console.WriteLine();
            //  Console.WriteLine("The Rectangle area is:", area);
        }


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
        public Rectangle(double length, double width, double area1) //constructor which 
                                                      // initializes the length and width of the rectangle.
        {
            this.Length = length;
            this.Width = width;

            // double area = length * width;

            this.Area = area1;
          

          

        }


        public override void CalculateArea(double length, double width, double area1) //overridden method to compute the 
                                                                        // area of the rectangle.
        {
            _ = length * width;

            //}
            //      throw new NotImplementedException();
            //}






        }

        public void Print(double area)

        {
            Console.WriteLine("The Rectangle area is:", area);
        }



        public override void CalculateArea(double radius)
        {
            throw new NotImplementedException();
        }

        //public static int Multiply(double width, double lenght)
        //{
        //    throw new NotImplementedException();
        //}
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
            double area = 3.14 * radius * radius;
        }

            public override void CalculateArea(double radius)
            {

               double area =  radius*radius*3.14;

               // throw new NotImplementedException();
            }

            public void Print(double area)
            {

                Console.WriteLine("The Circle area is:", area);

                // interface method implementation to display the area 
                //  of the circle.This method should contain text which would identify that the method of the Circle class has been invoked.

            }

            public override void CalculateArea(double width, double length, double area1)
            {
                throw new NotImplementedException();
            }


            



            
        }
    
}


