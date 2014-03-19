using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcTestLib.Tests
{
    [TestFixture]
    public class CalcUtilsTest
    {
        [Test]
        public void Add_WhenInputIs5And2_Return7()
        {
            CalcUtils utils = new CalcUtils();
            Assert.AreEqual(7, utils.Add(5, 2));
        }

        //[Test]
        //public void Sub_WhenInputIs5And2_Return3()
        //{
        //    CalcUtils utils = new CalcUtils();
        //    Assert.AreEqual(3, utils.Subtract(5, 2));
        //}

        //[Test]
        //public void Mult_WhenInputIs5And2_Return10()
        //{
        //    CalcUtils utils = new CalcUtils();
        //    Assert.AreEqual(10, utils.Multiply(5, 2));
        //}

        //[Test]
        //public void Div_WhenInputIs0_ThrowDivideByZeroException()
        //{
        //    CalcUtils utils = new CalcUtils();
        //    Assert.Throws<DivideByZeroException> (() => utils.Div(5, 0));
        //}
    }
}
