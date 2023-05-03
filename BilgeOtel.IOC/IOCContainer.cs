using BilgeOtel.BLL.Abstract;
using BilgeOtel.BLL.AbstractService;
using BilgeOtel.BLL.Concrete;
using BilgeOtel.BLL.Service;
using BilgeOtel.DAL.Context;
using BilgeOtel.Entity.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.IOC
{
    public class IOCContainer
    {
        public static void ConfigureIoc(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IRentUserService, RentUserService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            //Identity
            services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<ProjectContext>().AddDefaultTokenProviders();
        }
    }
}
