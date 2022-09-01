namespace tiendung99.Ecommerce.DAL.Entities
{
    public class OrderDetail : BaseModel
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
