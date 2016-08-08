using AdapterPattern.Models;

namespace AdapterPattern
{
    public class User
    {
        public void WorkWithProduct(AbstractProduct product)
        {
            product.ShowName();
        }
    }
}