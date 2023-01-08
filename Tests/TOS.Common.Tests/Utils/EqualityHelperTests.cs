﻿using NUnit.Framework;
using TOS.Common.Utils;

namespace TOS.Common.Tests.Utils
{
    [TestFixture]
    public partial class EqualityHelperTests
    {
        [Test]
        public void AreEqual_WhenCheckingTwoRefsToSameObject_ShouldReturnTrue()
        {
            object a = new object();
            object b = a;
            Assert.AreSame(a, b);
            Assert.AreEqual(a, b);
            Assert.IsTrue(EqualityHelper.AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoRefsToDifferentObject_ShouldReturnFalse()
        {
            object a = new object();
            object b = new object();
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(EqualityHelper.AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoObjectsWithOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(1);
            Assert.AreNotSame(a, b);
            Assert.AreEqual(a, b);
            Assert.True(EqualityHelper.AreEqual(a, b));
        }

        [Test]
        public void AreEqual_WhenCheckingTwoObjectsWithDiffOverridenEquals_ShouldReturnTrue()
        {
            ValueClass a = new ValueClass(1);
            ValueClass b = new ValueClass(2);
            Assert.AreNotSame(a, b);
            Assert.AreNotEqual(a, b);
            Assert.False(EqualityHelper.AreEqual(a, b));
        }

    }
}
