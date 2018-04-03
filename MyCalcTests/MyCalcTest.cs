using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcInittest;

namespace MyCalcTests
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange 
            int z = 10;
            int x = 20;
            int expected = 30;
            //act
            MyCalcInittest.MyCalc c = new MyCalcInittest.MyCalc();
           double actual= c.Sum(z, x);

            //assert
            Assert.AreEqual(expected,actual) ;
        }

        [TestMethod]
        public void Subtraction_30and20_10returned()
        {
            //arrange 
            int z = 30;
            int x = 20;
            int expected = 10;
            //act
            MyCalcInittest.MyCalc c = new MyCalcInittest.MyCalc();
            double actual = c.Subtraction(z, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_10and20_200returned()
        {
            //arrange 
            int z = 10;
            int x = 20;
            int expected = 200;
            //act
            MyCalcInittest.MyCalc c = new MyCalcInittest.MyCalc();
            double actual = c.Multiplication(z, x);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_20and10_2returned()
        {
            //arrange 
            int z = 20;
            int x = 10;
            int expected = 2;
            //act
            MyCalcInittest.MyCalc c = new MyCalcInittest.MyCalc();
            double actual = c.Divide(z, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SQRT_100_10returned()
        {
            //arrange 
            int z = 100;
          
            int expected = 10;
            //act
            MyCalcInittest.MyCalc c = new MyCalcInittest.MyCalc();
            double actual = c.SQRT(z);
            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
