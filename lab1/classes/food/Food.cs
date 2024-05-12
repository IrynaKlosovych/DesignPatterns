using System;
namespace lab1.classes.food
{
    public class Food
    {
        protected string Name { get; set; }
        protected int Quantity { get; set; }

        public Food(string name, int quantity)
        {
            Name = name;
            if (!CheckQuantity(quantity)) throw new ArgumentException("Quantity can't be less or equal zero");
            Quantity = quantity;
        }

        protected bool CheckQuantity(int quantity)
        {
            if (quantity <= 0)
            {
                return false;
            }
            return true;
        }
        public string GetName() { return Name; }
        public int GetQuantity() { return Quantity; }
    }
}

