namespace Uaine.Game.Characters
{
    public class Skills
    {
        public Skill Intelligence;
        public Skill Leadership;
        public Skill Strength;
        public Skill Crafting;
        public Skill Combat;

        public Skills(Skill intl, Skill ldrsp, Skill strg, Skill crft, Skill cmb)
        {
            Intelligence = intl;
            Leadership = ldrsp;
            Strength = strg;
            Crafting = crft;
            Combat = cmb;
        }
    }
}
