namespace tiendung99.Ecommerce.DAL.Entities
{
    public class Order : BaseModel
    {
        public IEnumerable<OrderDetail> OrderItems { get; set; }
        public Guid PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
