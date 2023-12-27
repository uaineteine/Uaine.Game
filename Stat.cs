using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game
{
    public class Stat : FValue
    {
        public Stat(float val) : base(val)
        {
        }

        public void Buff(float buffSum)
        {
            Value = _def + buffSum;
        }
    }
}
