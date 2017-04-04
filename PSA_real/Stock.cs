using System.Collections.Generic;


namespace PSA_real
{
    //subject,publisher
    public abstract class Stock
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }

        private string _symbol;
        private double _price;

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }


        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }

}
