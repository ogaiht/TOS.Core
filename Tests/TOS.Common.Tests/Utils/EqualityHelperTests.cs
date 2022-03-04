using NUnit.Framework;
using TOS.Common.Utils;

namespace TOS.Common.Tests.Utils
{
    [TestFixture]
    public class EqualityHelperTests
    {
        public class ValueClass
        {
            private readonly int _value;

            public ValueClass(int value)
            {
                _value = value;
            }

            public override bool Equals(object obj)
            {
                return obj is ValueClass testClass && testClass._value == _value;
            }

            public override int GetHashCode()
            {
                return _value;
            }

        }

        [Test]
        public void AreEquals_WhenCheckingTwoRefsToSameObject_ShouldReturnTrue()
        {
            object a = new object();
            object b = a;
            Assert.AreSame(a, b);
            Assert.AreEqual(a, b);
            Assert.IsTrue(EqualityHelper.AreEquals(a, b));
        }

        [Test]
        public void AreEquals_WhenCheckingTwoRefsToDifferentObject_ShouldReturnFalse()
        {
            object a = new object();
            object b = new object();
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(EqualityHelper.AreEquals(a, b));
        }

        [Test]
        public void AreEquals_WhenCheckingTwoObjectsWithOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(1);
            Assert.AreNotSame(a, b);
            Assert.AreEqual(a, b);
            Assert.True(EqualityHelper.AreEquals(a, b));
        }

        [Test]
        public void AreEquals_WhenCheckingTwoObjectsWithDiffOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(2);
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(EqualityHelper.AreEquals(a, b));
        }

    }
}
