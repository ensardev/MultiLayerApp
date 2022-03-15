namespace MultiLayer.Core
{
    public class ProductFeatureEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int ProductId { get; set; }

        public virtual ProductEntity Product { get; set; }
    }
}