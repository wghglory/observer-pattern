using System;

namespace PSA_real
{
    //concrete observer
    public class Investor : Observer
    {
        private string _observerName;
        private Stock _stock;

        // Constructor
        public Investor(Stock stock,string observerName)
        {
            _stock = stock;
            _observerName = observerName;
        }

        public override void Update()
        {
            Console.WriteLine($"Notify {_observerName} of {_stock.Symbol}'s change to {_stock.Price}");
        }

    }
}