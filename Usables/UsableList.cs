using Uaine.Objects.Primitives;
using Uaine.UID;

namespace Uaine.Game.Usables
{
    public class UsableList : NamedObject
    {
        public List<Usable> usables { get; }

        public UsableList(string name) : base(name)
        {
            usables = new List<Usable>();
        }

        public void AddUsable(Usable u)
        {
            usables.Add(u);
        }

        public Usable GetCharacterFromID(UniqueID id)
        {
            return usables.FirstOrDefault(c => c.ID.Equals(id));
        }

        // Seralize
        public string[] SeraliseCharacters()
        {
            string[] output = new string[usables.Count];
            for (int i = 0; i < usables.Count; i++)
            {
                output[i] = usables[i].SeralizeToJSON();
            }
            return output;
        }

        // De-Seralize
        public static UsableList Deserialize(string[] usablesjson, string name)
        {
            UsableList ul = new UsableList(name);
            foreach (string usable in usablesjson)
            {
                Usable nus = Usable.Deserialize(usable);
                ul.AddUsable(nus);
            }
            return ul;
        }
    }
}
