//-----------------------------------------------------------------------
// <copyright file="UnitTestProjectForTask2.cs" company="CompanyName">
//     Company copyright. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task2;

    /// <summary>
    /// To test Task2
    /// </summary>
    [TestClass]
    public class UnitTestProjectForTask2
    {
        /// <summary>
        /// To test main method
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Program test2 = new Program();
            string[] args = { "sum", "1,2" };
            Program.Main(args);
        }

        /// <summary>
        /// To test Addition method
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Program test2 = new Program();
            string[] args = { "sum", "1,2" };
            List<string> input = new List<string>() { "sum", "1", "2" };
            double actualResult = Program.Addition(input);
            double expectedResult = 3;
            Assert.AreEqual<double>(expectedResult, actualResult);
        }
    }
}
