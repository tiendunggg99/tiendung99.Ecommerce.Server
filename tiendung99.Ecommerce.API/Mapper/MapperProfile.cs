using AutoMapper;
using tiendung99.Ecommerce.BLL.Models;
using tiendung99.Ecommerce.DAL.Entities;

namespace tiendung99.Ecommerce.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<ImageModel, Image>().ReverseMap();
            CreateMap<OrderDetailModel, OrderDetail>().ReverseMap();
            CreateMap<OrderModel, Order>().ReverseMap();
            CreateMap<PromotionModel, Promotion>().ReverseMap();
        }
    }
}
