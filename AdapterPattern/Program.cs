using System;
using AdapterPattern.Customer;
using AdapterPattern.Models;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dev = new DevProduct();
            var productB = new ProductB("Product B");
            var productA = new ProductAdapter(dev);

            var user = new User();

            user.WorkWithProduct(productB);
            user.WorkWithProduct(productA);

            Console.ReadKey();
        }
    }
}