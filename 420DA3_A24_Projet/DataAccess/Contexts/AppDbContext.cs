﻿using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Shipment> Shipments { get; set; }


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
            .HasColumnName(nameof(User.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName(nameof(User.Username))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .HasMaxLength(User.USERNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName(nameof(User.PasswordHash))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .HasMaxLength(User.PASSWORDHASH_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName(nameof(User.EmployeeWarehouseId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName(nameof(User.DateCreated))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName(nameof(User.DateModified))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName(nameof(User.DateDeleted))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName(nameof(User.RowVersion))
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

        _ = modelBuilder.Entity<Role>()
            .ToTable(nameof(this.Roles))
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .HasIndex(role => role.Name)
            .IsUnique(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName(nameof(Role.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Name)
            .HasColumnName(nameof(Role.Name))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.NAME_MAX_LENGTH})")
            .HasMaxLength(Role.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Description)
            .HasColumnName(nameof(Role.Description))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.DESCRIPTION_MAX_LENGTH})")
            .HasMaxLength(Role.DESCRIPTION_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName(nameof(Role.DateCreated))
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName(nameof(Role.DateModified))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName(nameof(Role.DateDeleted))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName(nameof(Role.RowVersion))
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion


        // TODO @TEAM: configurez vos entités ici

        #region ADDRESS
        _ = modelBuilder.Entity<Address>()
            .ToTable(nameof(this.Addresses))
            .HasKey(address => address.Id);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.Id)
            .HasColumnName(nameof(Address.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.Addressee)
            .HasColumnName(nameof(Address.Addressee))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Address.ADDRESSEE_MAX_LENGTH})")
            .HasMaxLength(Address.ADDRESSEE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.CivicNumber)
            .HasColumnName(nameof(Address.CivicNumber))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Address.CIVIC_NUMBER_MAX_LENGTH})")
            .HasMaxLength(Address.CIVIC_NUMBER_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.Street)
            .HasColumnName(nameof(Address.Street))
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Address.STREET_MAX_LENGTH})")
            .HasMaxLength(Address.STREET_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.City)
            .HasColumnName(nameof(Address.City))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Address.CITY_MAX_LENGTH})")
            .HasMaxLength(Address.CITY_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.State)
            .HasColumnName(nameof(Address.State))
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Address.STATE_MAX_LENGTH})")
            .HasMaxLength(Address.STATE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.Country)
            .HasColumnName(nameof(Address.Country))
            .HasColumnOrder(6)
            .HasColumnType($"nvarchar({Address.COUNTRY_MAX_LENGTH})")
            .HasMaxLength(Address.COUNTRY_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.PostalCode)
            .HasColumnName(nameof(Address.PostalCode))
            .HasColumnOrder(7)
            .HasColumnType($"nvarchar({Address.POSTAL_CODE_MAX_LENGTH})")
            .HasMaxLength(Address.POSTAL_CODE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.AddressType)
            .HasColumnName(nameof(Address.AddressType))
            .HasColumnOrder(8)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.DateCreated)
            .HasColumnName(nameof(Address.DateCreated))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.DateModified)
            .HasColumnName(nameof(Address.DateModified))
            .HasColumnOrder(10)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.DateDeleted)
            .HasColumnName(nameof(Address.DateDeleted))
            .HasColumnOrder(11)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Address>()
            .Property(address => address.RowVersion)
            .HasColumnName(nameof(Address.RowVersion))
            .HasColumnOrder(12)
            .IsRowVersion();

        // Configuration des relation pour Address
        _ = modelBuilder.Entity<Address>()
            .HasOne(a => a.OwnerWarehouse)
            .WithOne()
            .HasForeignKey<Address>("WarehouseId")
            .OnDelete(DeleteBehavior.Restrict);

        _ = modelBuilder.Entity<Address>()
            .HasOne(a => a.OwnerShipOrder)
            .WithOne()
            .HasForeignKey<Address>("ShipmentOrderId")
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region PRODUCT
        /* Ajoute des underlines "_" comme initialisation. Les fonctions modelBuilder retourner toujours qqchose, mais ici, c inutile (on return rien)
           Donc on ajoute le underline pour le faire explicite (je sais que c vide) et éviter les Warning qui m'énervent des fois. */

        ///Configur de Table 'PRODUCTS' situé dans la BD. On cherche par son nom + Configur sa Clé Primaire 
        _ = modelBuilder.Entity<Product>()                   //Return Entity Product (en methode générique List<T> pour mieux compiler sil y a des Erreurs)
            .ToTable("Products").HasKey(product => product.Id);    //Liée à table 'Products' + dont la Clé Primaire = propriété 'Id' du Entity

        ///Configur que l'index soit toujours UNIQUE (en fonction du Nom du Produit)
        _ = modelBuilder.Entity<Product>()
            .HasIndex(product => product.Name).IsUnique(true);  //Cherche Name et vérifie si Unique

        ///CONFIGURATION DU ENTITY 'PRODCUT' À TOUTES LES COLONNES DE LA TABLE 'Products' !!!
        /* 0 - ID */
        _ = modelBuilder.Entity<Product>()           // Entity Product
            .Property(prod => prod.Id)               // Clé Primaire ('Id' Property in Domain)
            .HasColumnName("Id").HasColumnOrder(0)   // Liée à colonne 'Id' dans table 'Product' et qui est index 0 (colonne 1) dans la table
            .HasColumnType("int")                    // seed (ou 'default':pour user admin par exemple [number #1]. Utile si faut reset la Table) = 1
            .UseIdentityColumn(1, 1);                // + incrementation de 1 a chaque création de nouvelle rangée (de donnée)

        _ = modelBuilder.Entity<Product>()  /*1 - NAME */
            .Property(prod => prod.Name)
            .HasColumnName("Name").HasColumnOrder(1)
            .HasColumnType($"nvarchar( {Product.PROD_NAME_MAXLENGHT} )") // type: NVARCHAR (PAS STRING!) + <taille spécifiée dans Constante/Domain 'Product'>                 
            .IsRequired(true);  // colonne = null!    

        _ = modelBuilder.Entity<Product>()  /*2 - DESCRIPTION */
            .Property(prod => prod.Description)
            .HasColumnName("Description").HasColumnOrder(2)
            .HasColumnType($"nvarchar( {Product.PROD_DESCRIPTION_MAXLENGHT} )") // NVARCHAR                
            .IsRequired(true);  //NOT NULL     

        _ = modelBuilder.Entity<Product>()  /*3 - CODE UPC */
            .Property(prod => prod.Code_UPC)
            .HasColumnName("Code-UPC").HasColumnOrder(3)
            .HasColumnType($"nvarchar({Product.UP_CODE_MAXLENGHT})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()  /*4 - CODE SUPPLIER */
            .Property(product => product.Code_Supplier)
            .HasColumnName("Code-Supplier").HasColumnOrder(4)
            .HasColumnType($"nvarchar({Product.SUPPLIER_CODE_MAXLENGHT})")
            .IsRequired(false); //?NULLABLE

        _ = modelBuilder.Entity<Product>()  /*5 - IMAGE FILE */
            .Property(product => product.Image_FileName)
            .HasColumnName("IMG-File").HasColumnOrder(5)
            .HasColumnType($"nvarchar({Product.IMG_FILE_NAME_MAXLENGHT})")
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()  /*6 - INSTOCK QUANTITY */
            .Property(prod => prod.Qty_InStock)
            .HasColumnName("QtyInStock").HasColumnOrder(6)
            .HasColumnType("int")    // type est INT
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()  /*7 - DESIRED QUANTITY */
            .Property(prod => prod.Qty_Desired)
            .HasColumnName("QtyDesired").HasColumnOrder(7)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()  /*8 - WEIGHT */
            .Property(prod => prod.Weight_inKg)
            .HasColumnName("Weight").HasColumnOrder(8)
            .HasColumnType("float") // type DOUBLE (float dans SQL)
            .IsRequired(true);

        ///Configuration des IDs reliés aux autres Tables (FOREIGN KEYS)
        _ = modelBuilder.Entity<Product>()  /*9 - Table CLIENT */
            .Property(product => product.OwnerClient_Id)
            .HasColumnName("id-Client").HasColumnOrder(9)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()  /*10 - Table SUPPLIER */
            .Property(product => product.Supplier_Id)
            .HasColumnName("id-Supplier").HasColumnOrder(10)
            .HasColumnType("int")
            .IsRequired(true);

        ///Configuration des DATES
        _ = modelBuilder.Entity<Product>() /*11 - CREATED */
            .Property(product => product.DateCreated)
            .HasColumnName(nameof(Product.DateCreated)).HasColumnOrder(11)
            .HasColumnType("datetime2").HasPrecision(7)  //Maximum de 7 digits (char pour numeros)
            .HasDefaultValueSql("GETDATE()") //Se créer automatiquement (important à gérer dans le SQL)
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>() /*12 - MODIFIED */
            .Property(product => product.DateModified)
            .HasColumnName(nameof(Product.DateModified)).HasColumnOrder(12)
            .HasColumnType("datetime2").HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>() /*13 - DELETED */
            .Property(product => product.DateDeleted)
            .HasColumnName(nameof(Product.DateDeleted)).HasColumnOrder(13)
            .HasColumnType("datetime2").HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>() /* RowVersion[FrameWork] */
            .Property(product => product.RowVersion)
            .HasColumnName(nameof(Product.RowVersion)).HasColumnOrder(14)
            .IsRowVersion();

        //ToDo : RELATIONS n-n
        #endregion

        #region SUPPLIER
        ///Cherche par nom de Table + Configur sa Clé Primaire 
        _ = modelBuilder.Entity<Supplier>()                   //Return Entity Supplier (en methode générique List<T>)
            .ToTable("Suppliers").HasKey(supplier => supplier.Id);    //Liée à table 'Suppliers' + dont la Clé Primaire = propriété 'Id' du Entity

        //index soit toujours UNIQUE (en fonction du Nom du Produit)
        _ = modelBuilder.Entity<Supplier>()
            .HasIndex(supplier => supplier.Name).IsUnique(true);  //Cherche Name et vérifie si Unique

        ///LIASON DU ENTITY 'SUPPLIER' À TOUTES LES COLONNES DE LA TABLE 'Suppliers'
        /* 0 - ID */
        _ = modelBuilder.Entity<Supplier>()           // Entity 
            .Property(supp => supp.Id)                // Clé Primaire
            .HasColumnName("Id").HasColumnOrder(0)    // colonne 'Id' dans Table et qui est index 0 (colonne 1) 
            .HasColumnType("int")                   
            .UseIdentityColumn(1, 1);                // seed + incrementation de 1 a chaque création de nouvelle donnée

        _ = modelBuilder.Entity<Supplier>()  /*1 - NAME */
            .Property(supp => supp.Name)
            .HasColumnName("Name").HasColumnOrder(1)
            .HasColumnType($"nvarchar( {Supplier.SUPPLIER_NAME_MAXLENGHT} )") // type: NVARCHAR  + <taille spécifiée dans Constante>                 
            .IsRequired(true);  // colonne = not null

        _ = modelBuilder.Entity<Supplier>()  /*2 - CONTACT FIRSTNAME */
            .Property(supplier => supplier.Contact_FirstName)
            .HasColumnName("Name").HasColumnOrder(2)
            .HasColumnType($"nvarchar( {Supplier.CONTACT_NAME_MAXLENGHT} )")                  
            .IsRequired(true);  

        _ = modelBuilder.Entity<Supplier>()  /*3 - CONTACT LASTNAME */
            .Property(supplier => supplier.Contact_LastName)
            .HasColumnName("Name").HasColumnOrder(3)
            .HasColumnType($"nvarchar( {Supplier.CONTACT_NAME_MAXLENGHT} )")              
            .IsRequired(true);  // colonne = not null

        _ = modelBuilder.Entity<Supplier>()  /*4 - EMAIL */
            .Property(supplier => supplier.Contact_Email)
            .HasColumnName("Name").HasColumnOrder(4)
            .HasColumnType($"nvarchar( {Supplier.CONTACT_EMAIL_MAXLENGHT} )")              
            .IsRequired(false);  // colonne peut etre NULL

        _ = modelBuilder.Entity<Supplier>()  /*5 - PHONE */
            .Property(supplier => supplier.Contact_Phone)
            .HasColumnName("Name").HasColumnOrder(5)
            .HasColumnType($"nvarchar( {Supplier.CONTACT_PHONE_MAXLENGHT} )")                  
            .IsRequired(false);  

        ///Configuration des DATES
        _ = modelBuilder.Entity<Supplier>() /*6 - CREATED */
            .Property(supp => supp.DateCreated)
            .HasColumnName(nameof(Supplier.DateCreated)).HasColumnOrder(6)
            .HasColumnType("datetime2").HasPrecision(7)  //Maximum de 7 digits 
            .HasDefaultValueSql("GETDATE()") //Se créer automatiquement (important à gérer dans le SQL)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>() /*7 - MODIFIED */
            .Property(supp => supp.DateModified)
            .HasColumnName(nameof(Supplier.DateModified)).HasColumnOrder(7)
            .HasColumnType("datetime2").HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>() /*8 - DELETED */
            .Property(supp => supp.DateDeleted)
            .HasColumnName(nameof(Supplier.DateDeleted)).HasColumnOrder(8)
            .HasColumnType("datetime2").HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>() /* RowVersion[FrameWork] */
            .Property(supplier => supplier.RowVersion)
            .HasColumnName(nameof(Supplier.RowVersion)).HasColumnOrder(9)
            .IsRowVersion();

        //ToDo : RELATIONS 1-n
        #endregion

        #region SHIPMENT
        _ = modelBuilder.Entity<Shipment>()
            .ToTable(nameof(this.Shipments))
            .HasKey(shipment => shipment.Id);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.Id)
            .HasColumnName(nameof(Shipment.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.Status)
            .HasColumnName(nameof(Shipment.Status))
            .HasColumnOrder(1)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingService)
            .HasColumnName(nameof(Shipment.ShippingService))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingOrderId)
            .HasColumnName(nameof(Shipment.ShippingOrderId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.TrackingNumber)
            .HasColumnName(nameof(Shipment.TrackingNumber))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Shipment.TRACKING_NUMBER_MAX_LENGTH})")
            .HasMaxLength(Shipment.TRACKING_NUMBER_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateCreated)
            .HasColumnName(nameof(Shipment.DateCreated))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateModified)
            .HasColumnName(nameof(Shipment.DateModified))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateDeleted)
            .HasColumnName(nameof(Shipment.DateDeleted))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.RowVersion)
            .HasColumnName(nameof(Shipment.RowVersion))
            .HasColumnOrder(8)
            .IsRowVersion();

        // Configuration des relations pour Shipments
        _ = modelBuilder.Entity<Shipment>()
            .HasOne(s => s.ShippingOrder)
            .WithOne()
            .HasForeignKey<Shipment>(s => s.ShippingOrderId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion


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
