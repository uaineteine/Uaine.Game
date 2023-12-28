using Uaine.Game.Items;
using Uaine.UID;

namespace Uaine.Game.items
{
    public class Container
    {
        public UniqueID ID;
        public Item[] Contents { get; private set; }
        public int MaxSize { get => Contents.Length; }

        public Container(UniqueID iD, Item[] contents, int maxSize)
        {
            ID = iD;
            if (maxSize >= contents.Length)
            {
                Contents = new Item[maxSize];
                for (int i = 0; i < contents.Length; i++)
                {
                    Contents[i] = contents[i];
                }
            }
            else
            {
                new ArgumentException("Contents longer than container size");
            }
        }
    }
}
