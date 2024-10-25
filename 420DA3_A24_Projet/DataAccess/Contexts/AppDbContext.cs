using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        #region CONFIGURATION DE USER

        modelBuilder.Entity<User>()
            .ToTable("Users")
            .HasKey(user => user.Id);

        modelBuilder.Entity<User>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        modelBuilder.Entity<User>().Property(user => user.Id)
            .HasColumnName("Id")
            .HasColumnType("int")
            .HasColumnOrder(0);

        modelBuilder.Entity<User>().Property(user => user.Username)
            .HasColumnName("Username")
            .HasColumnType($"nvarchar({User.UsernameMaxLength})")
            .HasColumnOrder(1)
            .HasMaxLength(User.UsernameMaxLength)
            .IsRequired(true);

        modelBuilder.Entity<User>().Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnType($"nvarchar({User.PasswordHashMaxLength})")
            .HasColumnOrder(2)
            .HasMaxLength(User.PasswordHashMaxLength)
            .IsRequired(true);

        modelBuilder.Entity<User>().Property(user => user.EmployeeWarehouseId)
            .HasColumnName("EmployeeWarehouseId")
            .HasColumnType("int")
            .HasColumnOrder(3)
            .IsRequired(false);

        modelBuilder.Entity<User>().Property(User => User.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2(7)")
            .HasColumnOrder(4)
            .HasPrecision(7)
            .IsRequired(true)
            .HasDefaultValueSql("getdate()");

        modelBuilder.Entity<User>().Property(User => User.DateModified)
            .HasColumnName("DateModified")
            .HasColumnType("datetime2(7)")
            .HasColumnOrder(5)
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<User>().Property(User => User.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnType("datetime2(7)")
            .HasColumnOrder(6)
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<User>().Property(User => User.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(7)
            .IsRowVersion();

        #endregion








        // Relations entre entités
        modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.RoleUsers);

        modelBuilder.Entity<Role>()
            .HasMany(role => role.RoleUsers)
            .WithMany(user => user.Roles);
    }
}
