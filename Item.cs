using System;
using Uaine.Objects.Primitives;

namespace Uaine.Objects.Game
{
    public class Item : NamedObject
    {
        public TextObject Description;
        public BaseStats Stats;
        public ItemStack stack;
        public void addStack(int number)
        {
            stack.addStack(number);
        }
        public void removeStack(int number)
        {
            stack.removeStack(number);
        }
        public Item(string Name, TextObject description, CharacterStats stats, ItemStack itmstack) : base(Name)
        {
            Description = description;
            Stats = stats;
            stack = itmstack;
        }
    }
    public class ItemStack
    {
        private int stack;
        public int Stack { get => stack; }
        private int stackLim;
        public int StackLim { get => stackLim; }
        private bool unlimited = false;
        public bool Unlimited { get => unlimited; }

        public ItemStack(int stack, int stackLim)
        {
            this.stack = stack;
            this.stackLim = stackLim;
            this.unlimited = false;
        }

        public ItemStack(int stack, bool unlimited)
        {
            this.stack = stack;
            this.stackLim = int.MaxValue;
            this.unlimited = unlimited;
        }
        public void addStack(int number)
        {
            if (stack <= number && stack + number <= stackLim)
                stack += number;
            else throw new Exception("Item stack will be beyond limits");
        }
        public void removeStack(int number)
        {
            if (stack >= number)
                stack -= number;
            else throw new Exception("Item stack will be beyond limits");
        }
    }
}
