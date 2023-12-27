﻿using Uaine.Game.Characters;
using Uaine.Objects.Primitives.ID;

namespace Uaine.Game.Player
{
    public class Player : Character
    {
        ID32 PlayerID;
        public Player(Character playercharacter, int id) : base(playercharacter, playercharacter.Description, playercharacter.Stats)
        {
            PlayerID = id;
        }
    }
}
