using System;

namespace NapilnikTask_Online_shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product iPhone12 = new Product("IPhone 12");
            Product iPhone11 = new Product("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Deliver(iPhone12, 10);
            warehouse.Deliver(iPhone12, 5);
            warehouse.Deliver(iPhone11, 1);

            //Вывод всех товаров на складе с их остатком
            Console.WriteLine("In warehouse:");
            foreach (var product in warehouse.Products)
                Console.WriteLine($"{product.Key.Name}: {product.Value} pc");

            Cart cart = shop.Cart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе

            //Вывод всех товаров в корзине
            Console.WriteLine("");
            Console.WriteLine("In cart:");
            foreach (var product in cart.Products)
                Console.WriteLine($"{product.Key.Name}: {product.Value} pc");
            
            Console.WriteLine("");
            Console.WriteLine($"Paylink: {cart.Order().Paylink}");
            Console.ReadKey();
        }
    }
}
