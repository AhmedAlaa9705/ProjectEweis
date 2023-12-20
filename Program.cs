using DAL.DBContext;
using ProjectEweis.Healper;
using ProjectEweis.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
using TestApiJWT.Models;
using ProjectEweis.Models;
using ProjectEweis.Services.POST;
using ProjectEweis.Services.Request;
using ProjectEweis.Hubs;
using Microsoft.AspNet.SignalR;
using IRequest = ProjectEweis.Services.Request.IRequest;

namespace ProjectEweis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));
            builder.Services.AddIdentity<ApplicationUser ,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddScoped<ILoginSystem, LoginSystem>();
            builder.Services.AddScoped<IPOST, POST>();
            builder.Services.AddScoped<IRequest, Request>();
           
            //builder.Services.AddCors(a => a.AddPolicy(
            //  name: "AllowOrigin",
            //  builder => {
            //      builder
            //      .AllowAnyOrigin()
            //      .AllowAnyMethod()
            //       .AllowCredentials()
            //      .AllowAnyHeader()
            //      .WithOrigins("https://localhost:44327/");
            //      }
            //  ));
            builder.Services.AddEndpointsApiExplorer();
          
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            //////////////////Console.WriteLine("rrrrrr");////////////////////////////
            ///
            builder.Services.AddSignalR();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = false;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
                };
            });


            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            //app.UseCors(builder =>
            //{
            //    builder
            //   .AllowAnyOrigin()
            //   .AllowAnyMethod()
            //   .AllowAnyHeader();
            //});
            app.UseCors(x => x
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true) // allow any origin
        .AllowCredentials()); // allow credentials

            app.UseHttpsRedirection();
            app.MapHub<ChatHub>("/chathub");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.Run();

        }
    }
}