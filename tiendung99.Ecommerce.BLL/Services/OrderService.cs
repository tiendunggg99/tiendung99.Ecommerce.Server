using AutoMapper;
using Microsoft.EntityFrameworkCore;
using tiendung99.Core.Entity.Repository;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;
using tiendung99.Ecommerce.DAL.Entities;

namespace tiendung99.Ecommerce.BLL.Services
{
    public class OrderService : RepositoryBase<Order, OrderModel>, IOrderService
    {
        public OrderService(IMapper mapper, DbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}
