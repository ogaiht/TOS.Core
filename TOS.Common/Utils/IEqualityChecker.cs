namespace TOS.Common.Utils
{
    public interface IEqualityChecker
    {
        bool AreEqual(object first, object second);
        bool AreEqual(string first, string second, bool ignoreCase = false);
    }
}