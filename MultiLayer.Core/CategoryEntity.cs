namespace MultiLayer.Core
{
    public class CategoryEntity:BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}