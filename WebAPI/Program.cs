
using DataAccess.Persistence;
using DataAccess.Repo;
using Domain.Data;
using Domain.Validation;
using Domain.Validation.Impl;

var builder = WebApplication.CreateBuilder(args);

//db context
builder.Services.AddDbContext<ProductsDbContext>();

//repositories
builder.Services.AddScoped<IProductRepo, ProductRepo>();

//--

//validations
builder.Services.AddScoped<IProductValidation, ProductValidation>();
//--

//controllers
builder.Services.AddControllers();
//--

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