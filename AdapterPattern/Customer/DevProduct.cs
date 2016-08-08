using System;

namespace AdapterPattern.Customer
{
    public class DevProduct
    {
        public DevProduct()
        {
            AnotherName = "DevProduct";
        }

        public string AnotherName { get; set; }

        public void ShowDevName()
        {
            Console.WriteLine("My name is little other: {0}", AnotherName);
        }
    }
}