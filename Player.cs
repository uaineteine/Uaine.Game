using Uaine.Objects.Primitives.ID;

namespace Uaine.Objects.Game
{
    public class Player : ID32
    {
        Character playerChar;
        public Player(Character playercharacter, int id) : base(id)
        {
            playerChar = playercharacter;
        }
    }
}
