namespace Homework_07_03
{
    public class IsProductAttribute : System.Attribute
    {
        public bool IsProduct { get; set; }

        public IsProductAttribute(bool isProduct)
        {
            IsProduct = isProduct;
        }
    }
}
