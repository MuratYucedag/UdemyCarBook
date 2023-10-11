using UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers;
using UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers;
using UdemyCarBook.Core.Application.Services;
using UdemyCarBook.Infrastructure.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CarBookContext>();

builder.Services.AddScoped<GetAuthorQueryHandler>();
builder.Services.AddScoped<GetAuthorByIdQueryHandler>();
builder.Services.AddScoped<CreateAuthorCommandHandler>();
builder.Services.AddScoped<UpdateAuthorCommandHandler>();
builder.Services.AddScoped<RemoveAuthorCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddApplicationServices(builder.Configuration);

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
