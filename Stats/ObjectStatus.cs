namespace Uaine.Game.Stats
{
    public class ObjectStatus
    {
        //basics
        public Stat Health;
        public int Tier { get; }

        //combat stuff
        public Stat Attack;
        public Stat Defense;
        public Stat Armour;
        public Stat Stamina;

        public Stat Dodge;
        public Stat Speed;
        public Stat CritChance;

        //magic
        public Stat MP;

        public ObjectStatus(Stat attack, Stat defense, Stat armour, int level)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.Armour = armour;
            this.Tier = level;
        }
    }
}
