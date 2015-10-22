using System;
using System.ComponentModel;
using NUnit.Framework;
using OperationInformation;

namespace UnitTests
{

    public class UnitTest1
    {
        [TestCase(1,1,Operations.Addition,Result = "2")]
        [TestCase(1, 3, Operations.Substraction, Result = "-2")]
        [TestCase(1, 1111, Operations.Addition, Result = "1112")]
        [TestCase(1.5f, 1.8f, Operations.Addition, Result = "3,3")]
        [TestCase(1, 1, Operations.Substraction, Result = "0")]
        [TestCase(1, 2, Operations.Substraction, Result = "-1")]
        [TestCase(1, 1, Operations.Mod, Result = "0")]
        [TestCase(11, 2, Operations.Mod, Result = "1")]
        [TestCase(15, 2, Operations.Mod, Result = "1")]
        [TestCase(16, 1, Operations.Sqrt, Result = "4")]
        [TestCase(25, 1, Operations.Sqrt, Result = "5")]
        [TestCase(100, 1, Operations.Sqrt, Result = "10")]
        [TestCase(5, 1, Operations.Reciprocal, Result = "0,2")]
        [TestCase(4, 1, Operations.Reciprocal, Result = "0,25")]
        [TestCase(2, 1, Operations.Reciprocal, Result = "0,5")]
        [TestCase(16, 4, Operations.Division, Result = "4")]
        [TestCase(11, 11, Operations.Division, Result = "1")]
        [TestCase(4, 2, Operations.Division, Result = "2")]
        [TestCase(100, 2, Operations.Multiplication, Result = "200")]
        [TestCase(16, 43, Operations.Multiplication, Result = "688")]
        public string TestOperation(float x,float y,Operations s)
        {

            return CalculationManager.GetOperation(s).Invoke(x, y);
        }
    }
}
