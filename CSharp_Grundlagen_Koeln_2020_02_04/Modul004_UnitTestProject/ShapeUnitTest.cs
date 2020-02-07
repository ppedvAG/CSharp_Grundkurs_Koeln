using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul004_3_VirtualOverride;

namespace Modul004_UnitTestProject
{
    [TestClass]
    public class ShapeUnitTest
    {
        private Shape shape;

        [TestInitialize]
        public void ShapeInitial()
        {
            shape = new Shape(5,5);
        }

        [TestMethod]
        public void TestGetArea()
        {
            double result = shape.Area();

            Assert.AreEqual(result, 25);
        }
    }
}
