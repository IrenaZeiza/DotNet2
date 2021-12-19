using CSharp.Activity.Polymorphism;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Activity6.Tests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestArea()
        {
            Shape[] data;
        }
    
    }

    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            // arrange
            double width = 5;
            double length = 7;
            double result = width * length;

            //act
            Assert.AreEqual(35, result);
        }
            public void TestPositiveValue()
            {
                {
                 

                    double length = -1;
                    Assert.IsTrue(length <=0);

                    double width = -1;
                    Assert.IsTrue(width <= 0);
                }
            }
        
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            double radius = 5;
            const double PI = 3.14;

          

            double result = PI * (Math.Pow(radius, 2));
            Assert.AreEqual(78.5, result);
        }
        [TestMethod]
        public void TestPositiveValue()
        {
            double radius = -1;
            Assert.IsTrue(radius <= 0);
        }
    
    }
}
