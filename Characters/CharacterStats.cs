using Uaine.Game.Stats;

namespace Uaine.Game.Characters
{
    public class CharacterStats
    {
        public Skills skills { get; private set; }
        public ObjectStatus stats { get; private set; }

        public CharacterStats(Skills skills, ObjectStatus stats)
        {
            this.skills = skills;
            this.stats = stats;
        }
    }
}
