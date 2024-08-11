using Uaine.Objects.Primitives.ID;
using Uaine.UID;

namespace Uaine.Game.Player
{
    public class Player
    {
        public ID32 PlayerID { get; }
        public UniqueID characterID { get; }
        public Player(int id, UniqueID charID)
        {
            PlayerID = id;
            characterID = charID;
        }
    }
}
