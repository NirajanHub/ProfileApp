using API.Data;
using API.Helpers;
using API.Interface;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extenseions
{
    public static class ApplicationServiceExtensions{
        public static IServiceCollection AddApplicaitonServices(this IServiceCollection services, IConfiguration config){
               services.AddScoped<ITokenService,TokenService>();
               services.AddScoped<IUserRepository,UserRepository>();
               services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
               services.AddDbContext<DataContext>(options =>
                 {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
                 });
            return services;
        }
    }
}
