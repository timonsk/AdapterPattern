using System;

namespace AdapterPattern.Models
{
    public class ProductB : AbstractProduct
    {
        public sealed override string Name { get; set; }

        public override void ShowName()
        {
            Console.WriteLine("My name is: {0}", Name);
        }

        public ProductB(string name)
        {
            Name = name;
        }
    }
}