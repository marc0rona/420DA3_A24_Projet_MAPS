using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);



        #region USER

        _ = modelBuilder.Entity<User>()
            .ToTable(nameof(this.Users))
            .HasKey(user => user.Id);

        _ = modelBuilder.Entity<User>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName("Username")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .HasMaxLength(User.USERNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .HasMaxLength(User.PASSWORDHASH_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName("EmployeeWarehouseId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(7)
            .IsRowVersion();


        _ = modelBuilder.Entity<User>()
            .HasOne(user => user.EmployeeWarehouse)
            .WithMany(warehouse => warehouse.WarehouseEmployees)
            .HasForeignKey(user => user.EmployeeWarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.CreatedShippingOrders)
            .WithOne(order => order.CreatorEmployee)
            .HasForeignKey(order => order.CreatorEmployeeId)
            .HasPrincipalKey(user => user.Id)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.FulfilledShippingOrders)
            .WithOne(order => order.FulfillerEmployee)
            .HasForeignKey(order => order.FulfillerEmployeeId)
            .HasPrincipalKey(user => user.Id)
            .IsRequired(false);

        #endregion

        #region ROLE

        // TODO: @PROF Faire config Role
        _ = modelBuilder.Entity<Role>()
            .ToTable(nameof(this.Roles))
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .HasIndex(role => role.Name)
            .IsUnique(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Name)
            .HasColumnName("Name")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.NAME_MAX_LENGTH})")
            .HasMaxLength(Role.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Description)
            .HasColumnName("Description")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.DESCRIPTION_MAX_LENGTH})")
            .HasMaxLength(Role.DESCRIPTION_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion


        // TODO @TEAM: configurez vos entités ici






        #region RELATIONS RE DONNÉES DE TEST

        // Warehouse ici


        // NOTE: le mot de passe des user est "testpasswd".
        User user1 = new User("UserAdmin", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 1
        };
        User user2 = new User("UserOffice", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 2
        };
        // TODO: @PROF assigner une warehouse à user3 quand une warehouse sera ajoutée.
        User user3 = new User("UserWarehouse", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 3
        };
        _ = modelBuilder.Entity<User>().HasData(user1, user2, user3);


        Role adminRole = new Role("Administrateurs",
            "Administrateurs tout-puissants."
        ) {
            Id = Role.ADMIN_ROLE_ID
        };
        Role officeEmployeesRole = new Role("Employés de bureau",
            "Employés travaillant dans les bureaux de WSYS Inc."
        ) {
            Id = Role.OFFICE_EMPLOYEE_ROLE_ID
        };
        Role whEmployeeRole = new Role("Employés d'entrepôt",
            "Employés travaillant dans les entrepôts de WSYS Inc."
        ) {
            Id = Role.WAREHOUSE_EMPLOYEE_ROLE_ID
        };
        _ = modelBuilder.Entity<Role>()
            .HasData(adminRole, officeEmployeesRole, whEmployeeRole);


        // NOTE: doit être placé après l'insertion de données pour User et pour Role
        // (besoin des IDs pour les associations)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.Users)
            .UsingEntity("UserRoles",
                rightRelation => {
                    return rightRelation.HasOne(typeof(Role)).WithMany().HasForeignKey("RoleId").HasPrincipalKey(nameof(Role.Id));
                },
                leftRelation => {
                    return leftRelation.HasOne(typeof(User)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(User.Id));
                },
                shadowEntityConfig => {
                    _ = shadowEntityConfig.HasKey("UserId", "RoleId");
                    _ = shadowEntityConfig.HasData(
                    new { UserId = 1, RoleId = 1 },
                    new { UserId = 2, RoleId = 2 },
                    new { UserId = 3, RoleId = 3 });
                }
            );
        // Possiblement pas besoin de la relation inversion
        /*
        _ = modelBuilder.Entity<Role>()
            .HasMany(role => role.Users)
            .WithMany(user => user.Roles);
        */

        #endregion

    }
}
