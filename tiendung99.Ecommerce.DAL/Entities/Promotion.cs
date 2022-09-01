namespace tiendung99.Ecommerce.DAL.Entities
{
    public class Promotion : BaseModel
    {
        public decimal DiscountPercent { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public Double BasePrice { get; set; }
    }
}
