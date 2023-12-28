namespace Uaine.Game.Characters
{
    public class LevelSystem
    {
        private float levelUpFactor = 2;
        public int xp { get; private set; }
        public int xp_level_up { get; private set; }
        public int Level { get; private set; }

        public LevelSystem(int level, int neededtoLevelUp, float lvlupfac)
        {
            Level = level;
            xp = 0;
            xp_level_up = neededtoLevelUp;
            levelUpFactor = lvlupfac;
        }

        public void AddExperience(int newxp)
        {
            xp += newxp;
            if (xp >= xp_level_up)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            if (xp <= levelUpFactor)
            {
                int leftoverxp = xp_level_up - xp;
                xp_level_up = (int)(xp_level_up*levelUpFactor);
                xp = xp - leftoverxp;
                Level += 1;
            }
        }
    }
}
