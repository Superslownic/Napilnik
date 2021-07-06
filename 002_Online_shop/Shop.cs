using System;

namespace NapilnikTask2
{
    public class Shop
    {
        private Warehouse _warehouse;
        private Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _cart = new Cart(this);
        }

        public bool Contains(Product product, int amount)
        {
            return _warehouse.Products.TryGetValue(product, out int count) && count >= amount;
        }

        public Cart Cart() => _cart;

        public Order GenerateOrder()
        {
            foreach (var pair in _cart.Products)
                if (!Contains(pair.Key, pair.Value))
                    throw new InvalidOperationException();

            return new Order("https://..");
        }
    }
}
