namespace AdapterPattern.Models
{
    public abstract class AbstractProduct
    {
        public abstract string Name { get; set; }

        public abstract void ShowName();
    }
}