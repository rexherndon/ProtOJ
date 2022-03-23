using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProtOJ.Data;
using ProtOJ.Models;
using System.Configuration;

namespace ProtOJ.Data;

public class IdentityContext : IdentityDbContext<IdentityUser>
{

    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    public DbSet<Session> Sessions { get; set; }

     public DbSet<ProtOJ.Models.User> User { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);
        

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
