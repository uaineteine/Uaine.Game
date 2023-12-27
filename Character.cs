using System;
using System.Collections.Generic;
using System.Text;
using Uaine.Objects.Primitives;

namespace Uaine.Objects.Game
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
