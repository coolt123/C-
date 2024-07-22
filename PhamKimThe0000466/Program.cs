
using Microsoft.EntityFrameworkCore;
using PhamKimThe0000466.DbContexts;

namespace PhamKimThe0000466
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<MyDbContext0000466De1>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Mydb"));
            });
            builder.Services.AddScoped<IDoanhNghiepService0000466De1, DoanhNghiepService0000466De1>();
            builder.Services.AddScoped<ISanPhamDoanhNghiep0000466De1, SanPhamDoanhNghiep0000466De1>();
            var app = builder.Build();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
