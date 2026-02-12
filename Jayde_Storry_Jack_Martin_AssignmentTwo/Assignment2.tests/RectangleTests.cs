using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Jayde_Storry_Jack_Martin_AssignmentTwo.Assignment2Tests;
using Microsoft.VisualBasic;
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
            int result = rect.GetLength();
            Assert.That(rect.GetLength(), Is.EqualTo(1));
        }

        [Test]
        public void GetLength_MinBoundary_Returns1()
        {
            var rect = new Rectangle(1, 5);
            int result = rect.GetLength();
            Assert.That(result, IsEqualTo(1));
        }

        [Test]
        public void GetLength_MaxBoundary_Returns4500()
        {
            var rect = new Rectangle(4500, 10);
            int result = rect.GetLength();
            Assert.That(result, Is.EqualTo(4500));
        }

        [Test]
        public void SetLength_MinBoundary_Returns1()
        {
            var rect = new Rectangle();
            int result = rect.SetLength(1);
            Assert.That(result, Is,EqualTo(1));
        }

        [Test]
        public void SetLength_MaxBoundary_Returns4500()
        {
            var rect = new Rectangle();
            int result = rect.SetLength(4500);
            Assert.That(result, Is.EqualTo(4500));
        }

        [Test]
        public void SetLength_MidValue_ReturnsCorrectValue()
        {
            var rect = new Rectangle();
            int result = rect.SetLength(2500);
            Assert.That(result, Is.EqualTo(2500));
        }

        [Test]
        public void GetWidth_Default_Returns1()
        {
            var rect = new Rectangle();
            int result = rect.GetWidth();
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetWidth_MinBoundary_Returns1()
        {
            var rect = new Rectangle(5, 1);
            int result = rect.GetWidth();
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetWidth_MaxBoundary_Returns4500()
        {
            var rect = new Rectangle(10, 4500);
            int result = rect.GetWidth();
            Assert.That(result, Is.EqualTo(4500));
        }

        [Test]
        public void SetWidth_MinBoundary_Returns1()
        {
            var rect = new Rectangle();
            int result = rect.SetWidth(1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetWidth_MaxBoundary_Return4500()
        {
            var rect = new Rectangle();
            int result = rect.SetWidth(4500);
            Assert.That(result, Is.EqualTo(4500));
        }

        [Test]
        public void SetWidth_MidValue_ReturnsCorrectValue()
        {
            var rect = new Rectangle();
            int result = rect.SetWidth(2500);
            Assert.That(result, Is.EqualTo(2500));
        }

        [Test]
        public void GetPerimeter_MinBoundary_ReturnsCorrectValue()
        {
            var rect = new Rectangle(1, 1);
            int result = rect.GetPerimeter();
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void GetPerimeter_MaxBoundary_ReturnsCorrectValue()
        {
            var rect = new Rectangle(4500, 4500);
            int result = rect.GetPerimeter();
            Assert.That(result, Is.EqualTo(18000));
        }

        [Test]
        public void GetPerimeter_MidValues_ReturnsCorrectValue()
        {
            var rect = new Rectangle(100, 200);
            int result = rect.GetPerimeter();
            Assert.That(result, Is.EqualTo(600));
        }

        [Test]
        public void GetArea_MaxBoundary_ReturnsCorrectValue()
        {
            var rect = new Rectangle(4500, 4500);
            int result = rect.GetArea();
            Assert.That(result, Is.EqualTo(20250000));
        }

        [Test]
        public void GetArea_MinBoundary_ReturnsCorrectValue()
        {
            var rect = new Rectangle(1, 1);
            int result = rect.GetArea();
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test]
        public void GetArea_MaxBoundary_ReturnsCorrectValue()
        {
            var rect = new Rectangle(100, 200);
            int result = rect.GetArea();
            Assert.That(result, Is.EqualTo(20000));
        }
            
        
    }
}
