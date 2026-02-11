using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jayde_Storry_Jack_Martin_AssignmentTwo.Assignment2Tests;
using NUnit.Framework;

namespace Jayde_Storry_Jack_Martin_AssignmentTwo.Assignment2.tests
{
    [TestFixture]
    internal class RectangleTests
    {
        [Test]
        public void GetLength_Default_Returns1()
        {
            var rect = new Rectangle();
            Assert.That(rect.GetLength(), Is.EqualTo(1));
        }

        [Test]
        public void TestPerimeter()
        {
         
        }
    }
}
