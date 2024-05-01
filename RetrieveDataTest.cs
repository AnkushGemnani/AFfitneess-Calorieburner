using NUnit.Framework;
using System;

namespace AGFitness.Test
{
    [TestFixture]
    internal class RetrieveDataTest
    {
        private RetrieveData retrieveData;

        [SetUp]
        public void Setup()
        {
            // Initialize with a known username
            retrieveData = new RetrieveData("ankushh");
        }

        [Test]
        public void RetrieveData_ViewDetails_ReturnsValidValues()
        {
            // Act
            retrieveData.viewDetails();

            // Assert
            Assert.IsNotNull(retrieveData.fullName);
            Assert.IsNotNull(retrieveData.Age);
            Assert.IsNotNull(retrieveData.Weight);
            Assert.IsNotNull(retrieveData.Gender);
            Assert.IsNotNull(retrieveData.Height);
            Assert.IsNotNull(retrieveData.calGoal);
        }

        [Test]
        public void RetrieveData_GetCaloriesBurnt_ReturnsValidValue()
        {
            // Arrange
            DateTime date = DateTime.Now.Date; // Use current date

            // Act
            double calBurned = retrieveData.GetCaloriesBurnt(date);

            // Assert
            Assert.GreaterOrEqual(calBurned, 0); // Ensure non-negative value
        }

        [Test]
        public void RetrieveData_GetCaloriesBurnt_InvalidDate_ReturnsZero()
        {
            // Arrange
            DateTime invalidDate = new DateTime(2023, 1, 1); // Use a date where no calories are recorded

            // Act
            double calBurned = retrieveData.GetCaloriesBurnt(invalidDate);

            // Assert
            Assert.AreEqual(0, calBurned); // No calories should be burnt on this date
        }
    }
}
