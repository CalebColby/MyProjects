using GameExchange_L1_.DAL_Implementations;
using GameExchange_L1_.Interfaces;
using GameExchange_L1_.Models;

namespace GameExchange_L1_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<GameExchangeDatabaseSettings>(
                builder.Configuration.GetSection("GameExchangeStoreDatabase"));

            builder.Services.AddScoped<IDataAccessLayer,MongoDAL>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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