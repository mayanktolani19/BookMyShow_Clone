using System.Reflection;
using BookMyShow_Clone;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Data;
using BookMyShow_Clone.Data.Repositories;
using BookMyShow_Clone.Models;
using Carter;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Book My Show Clone API", Version = "v1" });
    option.AddSecurityDefinition(
        "Bearer",
        new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter a valid token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "Bearer"
        }
    );
    option.AddSecurityRequirement(
        new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        }
    );
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.EnableSensitiveDataLogging();
});

// builder
//     .Services.AddIdentity<User, IdentityRole>(options =>
//     {
//         options.Password.RequireDigit = false;
//         options.Password.RequireLowercase = false;
//         options.Password.RequireUppercase = false;
//         options.Password.RequireNonAlphanumeric = false;
//         options.Password.RequiredLength = 3;
//     })
//     .AddEntityFrameworkStores<ApplicationDbContext>();

// builder
//     .Services.AddAuthentication(options =>
//     {
//         options.DefaultAuthenticateScheme =
//             options.DefaultChallengeScheme =
//             options.DefaultForbidScheme =
//             options.DefaultScheme =
//             options.DefaultSignInScheme =
//             options.DefaultSignOutScheme =
//                 JwtBearerDefaults.AuthenticationScheme;
//     })
//     .AddJwtBearer(options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidIssuer = builder.Configuration["JWT:Issuer"],
//             ValidateAudience = true,
//             ValidAudience = builder.Configuration["JWT:Audience"],
//             ValidateIssuerSigningKey = true,
//             IssuerSigningKey = new SymmetricSecurityKey(
//                 System.Text.Encoding.UTF8.GetBytes(builder.Configuration["JWT:SigningKey"] ?? "")
//             )
//         };
//     });

builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<ICityRepo, CityRepo>();

builder.Services.AddApplication();
builder.Services.AddCarter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapCarter();

app.UseHttpsRedirection();

app.Run();
