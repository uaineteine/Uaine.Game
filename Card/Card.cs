using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game.Card
{
    public class Card
    {
        public IValue cardValue;
        public IValue cardClass;

        public Card(int value, int cardclass)
        {
            cardValue = value;
            cardClass = cardclass;
        }

        //OPERATORS
        public static bool operator ==(Card lhs, Card rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            if (lhs.cardValue == rhs.cardValue)
            {
                if (lhs.cardClass == rhs.cardClass)
                    return true;
            }
            return false; //else
        }
        public static bool operator !=(Card lhs, Card rhs) => !(lhs == rhs);
    }
}
