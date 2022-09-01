using Microsoft.EntityFrameworkCore;
using System.Reflection;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Services;
using tiendung99.Ecommerce.DAL.Data;

namespace tiendung99.Ecommerce.API.Services
{
    public static class ServiceRegister
    {
        public static void AddServiceRegisters(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            // Add services to the container.

            serviceDescriptors.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            serviceDescriptors.AddEndpointsApiExplorer();
            serviceDescriptors.AddSwaggerGen();

            serviceDescriptors.AddDbContext<AppcationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            serviceDescriptors.AddAutoMapper(Assembly.GetExecutingAssembly());

            serviceDescriptors.AddTransient<ICategoryService, CategoryService>();
            serviceDescriptors.AddTransient<IImageService, ImageService>();
            serviceDescriptors.AddTransient<IOrderDetailService, OrderDetailService>();
            serviceDescriptors.AddTransient<IOrderService, OrderService>();
            serviceDescriptors.AddTransient<IProductService, ProductService>();
            serviceDescriptors.AddTransient<IPromotionService, PromotionService>();
        }
    }
}
