using Newtonsoft.Json;
using Uaine.Game.Stats;
using Uaine.Objects.Primitives;
using Uaine.UID;

namespace Uaine.Game.Usables
{
    public class Usable : NamedObject
    {
        public ObjectStatus stats;
        public bool useOnce = false;
        public float cooldown = 0;

        public UniqueID ID;

        public Usable(string name, ObjectStatus s, UniqueID id) : base(name)
        {
            stats = s;
            useOnce = true;
            cooldown = 0;
            ID = id;
        }
        public Usable(string name, ObjectStatus s, bool useonce, float cooldowntime, UniqueID id) : base(name)
        {
            stats = s;
            useOnce = useonce;
            cooldown = cooldowntime;
            ID = id;
        }

        // Seralize
        public string SeralizeToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        // De-Seralize
        public static Usable Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Usable>(json);
        }
    }
}
