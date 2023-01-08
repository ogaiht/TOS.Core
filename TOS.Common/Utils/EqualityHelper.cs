using System;

namespace TOS.Common.Utils
{
    public static class EqualityHelper
    {
        public static bool AreEqual(object first, object second)
        {
            return !((first == null && second != null) || (first != null && !first.Equals(second)));
        }

        public static bool AreEqual(string first, string second, bool ignoreCase = false)
        {
            return string.Equals(first, second, ignoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture);
        }
    }
}
