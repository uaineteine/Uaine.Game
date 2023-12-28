using Newtonsoft.Json;
using Uaine.Game.Stats;
using Uaine.Objects.Primitives;
using Uaine.UID;

namespace Uaine.Game.Usables
{
    public class Usable : NamedObject
    {
        public ObjectStatus stats;
        public TextObject Description;
        public bool useOnce = false;
        public float cooldown = 0;

        public UniqueID ID;

        public Usable(string name, ObjectStatus s, TextObject desc, UniqueID id) : base(name)
        {
            stats = s;
            Description = desc;
            useOnce = true;
            cooldown = 0;
            ID = id;
        }
        public Usable(string name, ObjectStatus s, TextObject desc, bool useonce, float cooldowntime, UniqueID id) : base(name)
        {
            stats = s;
            Description = desc;
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
