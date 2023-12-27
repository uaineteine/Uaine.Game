using Uaine.Game.Character;
using Uaine.Objects.Primitives;

namespace Uaine.Game.Characters
{
    public class Character : NamedObject
    {
        public TextObject Description;
        public CharacterStats Stats;

        public Character(string Name, TextObject description, CharacterStats stats) : base(Name)
        {
            Description = description;
            Stats = stats;
        }
    }
}
