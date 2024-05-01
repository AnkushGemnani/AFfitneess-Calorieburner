using System;
using NUnit.Framework;

namespace AGFitness.Test
{
    [TestFixture]
    public class CalculateCaloriesTest
    {
        private CalculateCalories calculateCalories;
        private RetrieveData userData; // Add a reference to RetrieveData

        [SetUp]
        public void Setup()
        {
            // Assuming "testuser" is a valid username for testing
            calculateCalories = new CalculateCalories("testuser");
            userData = new RetrieveData("testuser"); // Create an instance of RetrieveData
            userData.viewDetails(); // Retrieve user details
        }

        [Test]
        public void TestCalculateWalkingCalories()
        {
            double calories = calculateCalories.calculateWalkingCalories("1000", "Brisk Walking", DateTime.Now, 5.0, 30.0);
            Assert.AreEqual(4.5 * userData.Weight * (30.0 / 60.0), calories, 0.001); // Use userData to access Weight
        }

        [Test]
        public void TestCalculateSwimmingCalories()
        {
            double calories = calculateCalories.calculateSwimmingCalories(60.0, "Butterfly(fast)", "10", DateTime.Now.ToString("yyyy-MM-dd"));
            Assert.AreEqual(12.8 * userData.Weight, calories, 0.001); // Use userData to access Weight
        }

        // Add tests for other methods similarly
    }
}
