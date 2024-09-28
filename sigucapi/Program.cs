using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using sigucapi;
using sigucapi.Models;

var builder = WebApplication.CreateBuilder(args);
var movieApiKey = builder.Configuration["Movies:ServiceApiKey"];
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
//builder.Configuration.AddAzureAppConfiguration(connectionString);

builder.Services.AddRazorPages();
builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});
builder.Services.AddControllers();
builder.Services.AddDbContext<OrderContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(swagger =>
//{
//    swagger.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Version = "v1",
//        Title = "ASP.NET 8 Web API",
//        Description = "Authentication and Authorization in ASP.NET 8 with JWT and Swagger"
//    });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
