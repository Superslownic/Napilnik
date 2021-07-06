using System.Collections.Generic;

namespace NapilnikTask_Online_shop
{
    public class Warehouse
    {
        private Dictionary<Product, int> _products;

        public Warehouse()
        {
            _products = new Dictionary<Product, int>();
        }

        public IReadOnlyDictionary<Product, int> Products => _products;

        public void Deliver(Product product, int amount)
        {
            if (_products.ContainsKey(product))
                _products[product] += amount;
            else
                _products.Add(product, amount);
        }
    }
}
