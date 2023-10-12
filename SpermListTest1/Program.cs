using Microsoft.EntityFrameworkCore;
using SpermListTest1.data;
using SpermListTest1.data.context;
using SpermListTest1.data.Repository;
using SpermListTest1.Services;
using SpermListTest1.Services.fileServices;
using SpermListTest1.Services.FilterServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<SpermServices>();
builder.Services.AddScoped<CsvImportToDb>();
builder.Services.AddScoped<IData,DbRepository>();
builder.Services.AddScoped<IFileService,FileService>();
builder.Services.AddScoped<filterServices>();

builder.Services.AddDbContext<DatabaseContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
