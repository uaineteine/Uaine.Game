using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game
{
    public class Counter : IValue
    {
        public int _limit;

        public bool Elapsed { get => (_limit >= Value); }

        public Counter(int limit, int startingvalue) : base(startingvalue, 0)
        {
            _limit = limit;
        }

        public void Reset()
        {
            Value = _def;
        }

        public void addCount(int value)
        {
            Value += value;
        }
    }
}
