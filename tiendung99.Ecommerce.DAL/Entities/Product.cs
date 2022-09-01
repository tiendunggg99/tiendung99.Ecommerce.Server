namespace tiendung99.Ecommerce.DAL.Entities
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Infomation { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public bool Price { get; set; }
        public IEnumerable<Image> Gallery { get; set; }
    }
}
