using System;

namespace stackoverflow
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "evans");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new order();
            customer.Orders.Add(order);
        }
    }
}
