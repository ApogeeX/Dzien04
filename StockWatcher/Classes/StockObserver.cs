namespace StockWatcher.Classes
{
    public class AppleStockObserver : IObserver<Stock>
    {
        public void Update(Stock data)
        {
            if (data.Name.Equals("APL") && data.Value>=30)
            {
                System.Console.WriteLine("Akcje Apple powyżej 30");
            }
        }
    }

    public class IbmStockObserver : IObserver<Stock>
    {
        public void Update(Stock data)
        {
            if (data.Name.Equals("IBM") && data.Value >= 20)
            {
                System.Console.WriteLine("Akcje IBM powyżej 20");
            }
        }
    }
}
