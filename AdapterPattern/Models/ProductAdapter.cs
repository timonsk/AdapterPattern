using AdapterPattern.Customer;

namespace AdapterPattern.Models
{
    public class ProductAdapter : AbstractProduct
    {
        private readonly DevProduct _devProduct;
        public ProductAdapter(DevProduct devProduct)
        {
            _devProduct = devProduct;
        }

        public override string Name {
            get { return _devProduct.AnotherName; }
            set { _devProduct.AnotherName = value; }
        }

        public override void ShowName()
        {
            _devProduct.ShowDevName();
        }
    }
}