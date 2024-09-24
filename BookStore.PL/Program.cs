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

<<<<<<< HEAD

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        // Allow any domain- *  or only specific domain-http://localhost:3000
        policy.WithOrigins("*")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});  
=======
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
>>>>>>> 2249c5b84364d1a328778dcc4be9aeffe41a5181

var app = builder.Build();



<<<<<<< HEAD

=======
>>>>>>> 2249c5b84364d1a328778dcc4be9aeffe41a5181
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

// Use CORS
app.UseCors("AllowAllOrigins");

app.MapControllers();

app.Run();
