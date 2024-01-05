using AutoMapper;
using EduCenter.DataAccess.Repositories;
using EduCenter.Services.Interfaces;
using EduCenter.Services.Mapper;
using EduCenter.Services.Services;
using EduCenter.WebApi.Configurations;
using EduCenter.WebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(CertificateProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.ConfigureCORSPolicy();
builder.ConfigureDataAccess();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ISertificateService, SertificateService>();
//builder.Services.AddTransient<IMapper, Mapper>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowAll");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<CrosOriginAccessMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
