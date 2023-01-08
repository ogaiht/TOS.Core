using System;
using NUnit.Framework;
using TOS.Common.Utils;

namespace TOS.Common.Tests.Utils
{
    [TestFixture]
    public class ExceptionHelperTests
    {
        [Test]
        public void CheckArgumentNullException_WhenArgumentIsNull_ShouldThrowNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ExceptionHelper().CheckArgumentNullException(null, "Argument"));
        }

        [Test]
        public void CheckArgumentNullException_WhenArgumentIsNotNull_ShouldNotThrowNullException()
        {
            new ExceptionHelper().CheckArgumentNullException(new object(), "Argument");
            Assert.Pass();
        }

        [Test]
        public void CheckInvalidOperationException_WhenAnInvalidOperationIsExecuted_ShouldThrowInvalidOperationException()
        {
            const string message = "Invalid Operation";
            Assert.Throws<InvalidOperationException>(() => new ExceptionHelper().CheckInvalidOperationException(false, message), message);
        }

        [Test]
        public void CheckInvalidOperationException_WhenAValidOperationIsExecuted_ShouldNotThrowInvalidOperationException()
        {
            new ExceptionHelper().CheckInvalidOperationException(true, string.Empty);
            Assert.Pass();
        }

        [Test]
        public void CheckArgumentException_WhenAnArgumentIsInvalid_ShouldThrownArgumentException()
        {
            const string message = "Invalid Argument";
            Assert.Throws<ArgumentException>(() => new ExceptionHelper().CheckArgumentException(false, message, "parameter"), message);
        }

        [Test]
        public void CheckArgumentException_WhenAnArgumentIsValid_ShouldNotThrownArgumentException()
        {
            new ExceptionHelper().CheckArgumentException(true, "message", "parameter");
            Assert.Pass();
        }
    }
}