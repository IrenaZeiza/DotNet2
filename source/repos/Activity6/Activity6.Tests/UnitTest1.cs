using CSharp.Activity.Polymorphism;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static CSharp.Activity.Polymorphism.Rectangle;
using static CSharp.Activity.Polymorphism.Circle;
using static CSharp.Activity.Polymorphism.Shape;


namespace Activity6.Tests
{
    [TestClass]
    public class ShapeTest : Shape

    {
        Shape[] data;
        private Shape shape;
        private Rectangle rectangle;
        private Circle circle;

        double width = 5;
        double lenght = 7;
        double radius = 3;

        [TestInitialize]
        public void Initialize()
        {

        }

        public void CalculateArea()
        {


            //double result1 = width * lenght;
            //Assert.AreEqual(35, Equals(result1));

            //double result2 = 3.14 * radius * radius;
            //Assert.AreEqual(28.26, Equals(result2));


            double area1 = width * lenght;
            Assert.AreEqual(35, Equals(area1));

            double area2 = 3.14 * radius * radius;
            Assert.AreEqual(28.26, Equals(area2));
        }

    //    public override void CalculateArea(double width, double length)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void CalculateArea(double radius)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}


