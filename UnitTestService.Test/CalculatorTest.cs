using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestService;

namespace UnitTestService.Test
{
    [TestFixture] 
    public class CalculatorTest
    {
        [Test]
        public void AddAlwaysReturnsExceptionValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10,220), Is.EqualTo(230));
        }

    }
}
