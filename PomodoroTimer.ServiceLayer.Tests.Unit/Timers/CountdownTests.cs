
using NUnit.Framework;
using PomodoroTimer.ServiceLayer.Constants;
using PomodoroTimer.ServiceLayer.Enumerations;
using PomodoroTimer.ServiceLayer.Timers;
using System;

namespace PomodoroTimer.ServiceLayer.Tests.Unit.Timers
{
    [TestFixture]
    public class CountdownTests
    {
        private readonly ICountdown _sut;

        public CountdownTests()
        {
            _sut = Countdown.Instance;
        }

        [Test]
        public void ResetTimer_WhenSetsTypeIsWork_MinutesLeftWillBeSetToWorkMinutes()
        {
            // Arrange
            int expectedMinutes = StringConstant.pomodoroWorkMinutes;
            // Act
            _sut.SetWorkTimer();
            int resultMinutes = _sut.MinutesLeft;
            // Assert
            Assert.AreEqual(expectedMinutes, resultMinutes);
        }

        [Test]
        public void ResetTimer_WhenSetsTypeIsBreak_MinutesLeftWillBeSetToShortBreakMinutes()
        {
            // Arrange
            int expectedMinutes = StringConstant.pomodoroShortBreakMinutes;
            // Act
            _sut.SetBreakTimer();
            int resultMinutes = _sut.MinutesLeft;
            // Assert
            Assert.AreEqual(expectedMinutes, resultMinutes);
        }

        [Test]
        public void ResetTimer_WhenSetsTypeIsBreak_MinutesLeftWillBeSetToLongBreakMinutes()
        {
            // Arrange
            int expectedMinutes = StringConstant.pomodoroLongBreakMinutes;
            // Act
            
            _sut.SetBreakTimer();
            int resultMinutes = _sut.MinutesLeft;
            // Assert
            Assert.AreNotEqual(expectedMinutes, resultMinutes);
        }
    }
}
