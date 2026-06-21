namespace Core
{
    public class ProductColor
    {
        public string Code { get; set; }
        public string Display { get; set; }
    }

    public class Product : IComparable<Product>
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }

        public bool IsColorApply { get; set; }
        public ProductColor ProductColor { get; set; }

        public int MyProperty { get; set; }

        public int CompareTo(Product? other)
        {
            if (other == null)
                return 1;
            return this.Price.CompareTo(other.Price);
        }
    }

    public class ProductComapreByName : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
