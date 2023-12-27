using Uaine.Game.Stats;
using Uaine.Objects.Primitives;

namespace Uaine.Game.Usables
{
    public class Usable : NamedObject
    {
        public ObjectStatus stats;
        public bool useOnce = false;
        public float cooldown = 0;
    }
}
