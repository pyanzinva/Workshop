using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkShopControlLib;
using static WorkShopLogicLib.WorkShopCalculator;

namespace WorkShopLogicLib.Tests
{
    [TestClass]
    public class WorkShopCalculatorTests
    {
        // Тест 1: Проверка на отсутствие завершенных запросов
        [TestMethod]
        public void CalculateCompletedRequests_NoCompletedRequests_ShouldReturnZero()
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("В ожидании", DateTime.Now),
                new MockRecordsUserControl("Отменено", DateTime.Now)
            };
            var calculator = new WorkShopCalculator();

            // Act
            var completedRequests = calculator.CalculateCompletedRequests(controls);

            // Assert
            Assert.AreEqual(0, completedRequests);
        }

        // Тест 2: Проверка среднего времени выполнения для смешанных запросов
        [TestMethod]
        public void CalculateAverageCompletionTime_MixedRequests_ShouldReturnCorrectAverage()
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddMinutes(-30)),
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddHours(-1)),
                new MockRecordsUserControl("В ожидании", DateTime.Now.AddHours(-2)),
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddHours(-3)),
                new MockRecordsUserControl("Отменено", DateTime.Now.AddHours(-4))
            };
            var calculator = new WorkShopCalculator();

            // Act
            var averageCompletionTime = calculator.CalculateAverageCompletionTime(controls);

            // Assert
            var expectedAverageTime = new TimeSpan((long)((DateTime.Now - DateTime.Now.AddMinutes(-30)).Ticks +
                                                           (DateTime.Now - DateTime.Now.AddHours(-1)).Ticks +
                                                           (DateTime.Now - DateTime.Now.AddHours(-3)).Ticks) / 3);
            Assert.IsTrue(Math.Abs((averageCompletionTime - expectedAverageTime).TotalMilliseconds) < 100,
                $"Expected: {expectedAverageTime}, Actual: {averageCompletionTime}");
        }

        // Тест 3: Проверка завершенных запросов с использованием различных статусов
        [DataTestMethod]
        [DataRow("Выполнено", -1, 1)]
        [DataRow("Отменено", -2, 0)]
        [DataRow("В ожидании", -3, 0)]
        public void CalculateCompletedRequests_VariousStatuses_ShouldReturnExpectedCount(string status, int hoursOffset, int expectedCount)
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl(status, DateTime.Now.AddHours(hoursOffset))
            };
            var calculator = new WorkShopCalculator();

            // Act
            var completedRequests = calculator.CalculateCompletedRequests(controls);

            // Assert
            Assert.AreEqual(expectedCount, completedRequests);
        }
    }
}
