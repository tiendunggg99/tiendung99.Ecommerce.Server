namespace tiendung99.Ecommerce.DAL.Entities
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public Guid LogoId { get; set; }
        public virtual Image Logo { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
