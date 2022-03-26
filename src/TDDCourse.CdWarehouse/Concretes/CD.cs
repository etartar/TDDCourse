using TDDCourse.CdWarehouse.Exceptions;

namespace TDDCourse.CdWarehouse.Concretes
{
    public class CD
    {
        public CD(int initialStock)
        {
            StockCount = initialStock;
        }

        public int StockCount { get; private set; }

        public void Buy(int quantity)
        {
            if (quantity > StockCount)
                throw new InsufficientStockException();

            StockCount -= quantity;
        }
    }
}
