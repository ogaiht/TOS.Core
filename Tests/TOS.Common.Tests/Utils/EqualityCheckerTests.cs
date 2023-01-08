using NUnit.Framework;
using TOS.Common.Utils;

namespace TOS.Common.Tests.Utils
{
    [TestFixture]
    public class EqualityCheckerTests
    {
        [Test]
        public void AreEqual_WhenCheckingTwoRefsToSameObject_ShouldReturnTrue()
        {
            object a = new object();
            object b = a;
            Assert.AreSame(a, b);
            Assert.AreEqual(a, b);
            Assert.IsTrue(new EqualityChecker().AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoRefsToDifferentObject_ShouldReturnFalse()
        {
            object a = new object();
            object b = new object();
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(new EqualityChecker().AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoObjectsWithOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(1);
            Assert.AreNotSame(a, b);
            Assert.AreEqual(a, b);
            Assert.True(new EqualityChecker().AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoObjectsWithDiffOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(2);
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(new EqualityChecker().AreEqual(a, b));
        }
    }
}