namespace TDDCourse.NUnit.Tests
{
    public class Item
    {
        public Item(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal() => Quantity * Price;
    }
}
