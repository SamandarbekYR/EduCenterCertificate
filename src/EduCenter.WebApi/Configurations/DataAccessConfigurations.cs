using EduCenter.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace EduCenter.WebApi.Configurations
{
    public static class DataAccessConfigurations
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            string connection = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder.Services.AddDbContext<AppDb>(options => options.UseNpgsql(connection));
        }
    }
}
