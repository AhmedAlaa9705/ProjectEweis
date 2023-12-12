using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectEweis.Models;
using TestApiJWT.Models;

namespace DAL.DBContext
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
            
           public DbSet<real_estate_no> real_estate_nos { get; set; }
           public DbSet<commercial> commercials { get; set; }
           public DbSet<real_estate_yes> real_estate_yess { get; set; }
           public DbSet<UserRequest> Requests { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
                {
                    base.OnModelCreating(builder);
                
                    builder.Entity<ApplicationUser>().ToTable("users", "Login");
                    builder.Entity<IdentityRole>().ToTable("Role", "Login");

                    builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim", "Login");
                    builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "Login");
                    builder.Entity<IdentityUserRole<string>>().ToTable("UserRole"  , "Login");
                    builder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "Login");
                    builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim", "Login");

                    builder.Entity<commercial>().ToTable("commercial", "Post");
                    builder.Entity<real_estate_yes>().ToTable("real_estate_yes", "Post");
                    builder.Entity<real_estate_no>().ToTable("real_estate_no", "Post");
                    builder.Entity<UserRequest>().ToTable("Requests", "Request");
        }
    }
    }