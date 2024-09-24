using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.DAL.DataContext;
using BookStore.DAL.Interfaces;
using BookStore.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBook,BookRepository> ();
builder.Services.AddScoped<IBookService,BookSrvice> ();

builder.Services.AddDbContext <BookStoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sql"));
});

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Use CORS
app.UseCors("AllowAllOrigins");

app.MapControllers();

app.Run();
