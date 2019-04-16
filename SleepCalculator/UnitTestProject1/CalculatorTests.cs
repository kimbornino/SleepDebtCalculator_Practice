using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SleepCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTests
    {

        [TestMethod]

        public void GetSleepByAge_CheckForAge10()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int age = 10;
            int expected = 10;
            int actual;

            //act
            actual = calculator.GetSleepByAge(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSleepByAge_CheckForAge16()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int age = 16;
            int expected = 9;
            int actual;

            //act
            actual = calculator.GetSleepByAge(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSleepByAge_CheckForAge30()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int age = 30;
            int expected = 8;
            int actual;
            //act
            actual = calculator.GetSleepByAge(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void getWeeklySleepGoal_checkCorrectTotal()
        {
            Calculator calculator = new Calculator();
            //arrange
            int hoursByAge = 10;
            int expected = 70;
            int actual;

            //act
            actual = calculator.GetWeeklySleepGoal(hoursByAge);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDeficetOrSurplus_DeficitResult()
        {
            //arrange
            Calculator calculator = new Calculator();
            decimal weeklySleep = 52;
            int weeklyGoal = 70;
            decimal expected = 18;
            decimal actual;

            //act

            actual = calculator.GetDeficitOrSurplus(weeklySleep, weeklyGoal);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void GetDeficetOrSurplus_SurplusResult()
        {
            //arrange
            Calculator calculator = new Calculator();
            decimal weeklySleep = 80;
            int weeklyGoal = 70;
            decimal expected = 10;
            decimal actual;

            //act

            actual = calculator.GetDeficitOrSurplus(weeklySleep, weeklyGoal);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDeficetOrSurplus_CheckBoolStatusWithDeficit()
        {
            //arrange
            Calculator calculator = new Calculator();
            
            decimal weeklySleep = 52;
            int weeklyGoal = 70;
            
            bool expected = true;
            
            
            //act

           calculator.GetDeficitOrSurplus(weeklySleep, weeklyGoal);
           bool actual = calculator.deficit;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetDeficetOrSurplus_CheckBoolStatusWithSurplus()
        {
            //arrange
            Calculator calculator = new Calculator();

            decimal weeklySleep = 52;
            int weeklyGoal = 70;
            bool deficit = false;
            bool expected = false;
            bool actual = deficit;


            //act

            calculator.GetDeficitOrSurplus(weeklySleep, weeklyGoal);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDeficetOrSurplus_CheckBoolStatusWith0()
        {
            //arrange
            Calculator calculator = new Calculator();

            decimal weeklySleep = 70;
            int weeklyGoal = 70;
            bool deficit = false;
            bool expected = false;
            bool actual = deficit;


            //act

            calculator.GetDeficitOrSurplus(weeklySleep, weeklyGoal);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
