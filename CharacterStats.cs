using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Game
{
    public class CharacterStats : BaseStats
    {
        float XP;
        int Level;
        private float speed = 1f;
        public float Speed { get => speed; set => speed = value; }
        public void LevelUp()
        {
            Level += 1;
        }
    }
}
