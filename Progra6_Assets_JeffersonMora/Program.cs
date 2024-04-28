using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Progra6_Assets_JeffersonMora.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var CnnStrBuilder = new SqlConnectionStringBuilder(
            builder.Configuration.GetConnectionString("CNNSTR")
            );

        CnnStrBuilder.Password = "progra6";

        string CnnStr = CnnStrBuilder.ConnectionString;


        builder.Services.AddDbContext<Progra620241Context>(options => options.UseSqlServer(CnnStr));


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

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}