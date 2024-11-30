using ApiTutorial.BusinessAccesLayer;
using ApiTutorial.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiTutorialContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("ApiTutorial"));
});
builder.Services.AddScoped<IBusinessAcessLayer,BusinessAcessLayer>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
