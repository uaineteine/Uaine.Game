using Uaine.Objects.Primitives;
using Uaine.UID;
using Uaine.Users;

namespace Uaine.Game.Characters
{
    public class CharacterList : NamedObject
    {
        public List<Character> chars { get; }

        public CharacterList(string name) : base(name)
        {
            chars = new List<Character>();
        }

        public void AddCharacter(Character c)
        {
            chars.Add(c);
        }

        public Character GetCharacterFromID(UniqueID id)
        {
            return chars.FirstOrDefault(c => c.ID.Equals(id));
        }

        // Seralize
        public string[] SeraliseCharacters()
        {
            string[] output = new string[chars.Count];
            for (int i = 0; i < chars.Count; i++)
            {
                output[i] = chars[i].SerializeToJson();
            }
            return output;
        }

        // De-Seralize
        public static CharacterList Deserialize(string[] charsjson, string name)
        {
            CharacterList cl = new CharacterList(name);
            foreach (string charjson in charsjson)
            {
                Character nc = Character.DeserializeFromJson(charjson);
                cl.AddCharacter(nc);
            }
            return cl;
        }
    }
}
