namespace MultiLayer.Core
{
    public class ProductEntity:BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ProductFeatureEntity ProductFeature { get; set; }    
    }
}