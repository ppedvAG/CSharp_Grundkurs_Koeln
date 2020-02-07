using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul004_3_VirtualOverride;

namespace Modul004_UnitTestProject
{
    [TestClass]
    public class CircleUnitTest
    {
        private Circle circle;
        private SqlConnection connection ;

        [TestInitialize]
        public void CircleInitial()
        {
            connection = new SqlConnection("");
            circle = new Circle(5);
            
        }



        [TestMethod]
        public void TestMethod1()
        {
            double result = circle.Area();

            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            circle = null;

            connection.Close();
            connection.Dispose();
            connection = null;

            GC.SuppressFinalize(connection);
        }
    }
}
