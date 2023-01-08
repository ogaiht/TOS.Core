namespace TOS.Common.Tests.Utils
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
 
}
