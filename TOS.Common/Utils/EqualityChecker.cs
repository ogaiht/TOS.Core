namespace TOS.Common.Utils
{
    public class EqualityChecker : IEqualityChecker
    {
        public bool AreEqual(object first, object second)
        {
            return EqualityHelper.AreEqual(first, second);
        }

        public bool AreEqual(string first, string second, bool ignoreCase = false)
        {
            return EqualityHelper.AreEqual(first, second, ignoreCase);
        }
    }
}
