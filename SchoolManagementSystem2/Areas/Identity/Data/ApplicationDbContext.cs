using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem2.Areas.Identity.Data;
using SchoolManagementSystem2.Models;

namespace SchoolManagementSystem2.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

public DbSet<SchoolManagementSystem2.Models.Student> Student { get; set; } = default!;

public DbSet<SchoolManagementSystem2.Models.Teacher> Teacher { get; set; } = default!;

public DbSet<SchoolManagementSystem2.Models.Report> Report { get; set; } = default!;

public DbSet<SchoolManagementSystem2.Models.Course> Course { get; set; } = default!;

public DbSet<SchoolManagementSystem2.Models.Attendance> Attendance { get; set; } = default!;
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(225);
        builder.Property(x => x.LastName).HasMaxLength(225);
    }
}