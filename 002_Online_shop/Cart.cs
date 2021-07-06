using System;
using System.Collections.Generic;

namespace NapilnikTask2
{
    public class Cart
    {
        private Shop _shop;
        private Dictionary<Product, int> _products;

        public Cart(Shop shop)
        {
            _shop = shop;
            _products = new Dictionary<Product, int>();
        }

        public IReadOnlyDictionary<Product, int> Products => _products;

        public void Add(Product product, int amount)
        {
            if (!_shop.Contains(product, amount))
                throw new InvalidOperationException();

            _products.Add(product, amount);
        }

        public Order Order()
        {
            return _shop.GenerateOrder();
        }
    }
}
