using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }




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
        ///Configur de Table 'PRODUCTS' situé dans la BD. On cherche par son nom + Configur sa Clé Primaire 
        _ = modelBuilder.Entity<Product>()                   //Return Entity Product (en methode générique List<T> pour mieux compiler sil y a des Erreurs)
            .ToTable("Products").HasKey(product => product.Id);    //Liée à table 'Products' + dont la Clé Primaire = propriété 'Id' du Entity

        ///Configur que l'index soit toujours UNIQUE (en fonction du Nom du Produit)
        _ = modelBuilder.Entity<Product>()
            .HasIndex(product => product.Name).IsUnique(true);  //Cherche Name et vérifie si Unique

        ///CONFIGURATION DU ENTITY 'PRODUCT' À TOUTES LES COLONNES DE LA TABLE 'Products' !!!
        /* 0 - ID */
        _ = modelBuilder.Entity<Product>()           // Entity Product
            .Property(prod => prod.Id)               // Clé Primaire ('Id' Property in Domain)
            .HasColumnName("Id").HasColumnOrder(0)   // Liée à colonne 'Id' dans table 'Product' et qui est index 0 (colonne 1) dans la table
            .HasColumnType("int")                    // seed  + incrementation de 1 a chaque création de nouvelle rangée (de donnée)
            .UseIdentityColumn(1, 1);                

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

        /// CONFIGURATION DE RELATIONS AVEC ENTITY CLIENT(Table)   /* Relation 0,n -> 1 */
        _ = modelBuilder.Entity<Product>()                  // (1 client possède plusieurs produits. Produit specifique a client) 
            .HasOne(prod => prod.OwnerClient)               // Possède 1 Client ( dans class Product / region #2- Propriété Navigation )
            .WithMany(client => client.Products)            // Supplier possède MANY produits ('List<Product>' dans class)
            .HasForeignKey(prod => prod.OwnerClient_Id)     //relie à un FK qui va a la table en 1 relation ('Product' FK => PK 'Client' dans ce cas)
            .IsRequired(true)   //obligatoire
            .OnDelete(DeleteBehavior.Cascade);              //Cascade = si un Client est supprimé : Produits reliés à se Client vont être supprimés

        /// CONFIGURATION DE RELATIONS AVEC ENTITY SUPPLIER  /* Relation 0,n -> 1 */
        _ = modelBuilder.Entity<Product>()                  // (juste 1 supplier pour plusieurs produits) 
            .HasOne(prod => prod.Supplier)                  // Possède 1 Supplier ( dans class Product )
            .WithMany(supplier => supplier.ProductList)     // Supplier possède MANY produits
            .HasForeignKey(prod => prod.Supplier_Id)        //relie à un FK qui va a la table en 1 relation ('Product' FK => PK 'Supplier' dans ce cas)
            .IsRequired(true)  
            .OnDelete(DeleteBehavior.Restrict);     //Restrict = si un Supplier est supprimé : restriction de supprimer sil y a des Produits. (1 produit doit toujours avoir un fournisseur [SupplierId NOT NULL] )


        /// CONFIGURATION DE RELATIONS AUX ENTITIES  PURCHASE_ORDER + SHIPPING_ORDER
        _ = modelBuilder.Entity<Product>()   /* PurchaseOrder : Relation 1 -> 0,n */
            .HasMany(prod => prod.OrderPurchases)       
            .WithOne(order => order.OrderedProduct)      //L'Ordre possède 1... ben,le Produit a vendre
            .HasForeignKey(order => order.ProductId)     ///ABOUBACAR, MET LE ID POUR LE PRODUIT DANS TA CLASSE. THANK YOU
            .IsRequired(true)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<Product>()  /* ShippingOrder : Relation 1 -> 0,n */
            .HasMany(prod => prod.OrderShipments)
            .WithOne(ship => ship.Product)       ///TODO: besoin d'une propriété Product pour association.
            .HasForeignKey(ship => ship.ProductId)    
            .IsRequired(true)
            .OnDelete(DeleteBehavior.Cascade);
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

        /// CONFIGURATION DE RELATIONS AVEC ENTITY PRODUCT
        _ = modelBuilder.Entity<Supplier>() /* Product : Relation 1 -> 0,n  */
            .HasMany(supp => supp.ProductList) //  (1 supplier pour plusieurs produits) 
            .WithOne(prod => prod.Supplier)
            .HasForeignKey(prod => prod.Supplier_Id) //FK = id du Supplier (dans 'Product' Table)
            .IsRequired(true)
            .OnDelete(DeleteBehavior.SetNull); //Si Supplier est supprimer = Produit relie vont avoir des valeurs NULl dans colones 'Suppliers'
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

        #region CLIENT
        _ = modelBuilder.Entity<Client>()
            .ToTable("Clients")
            .HasKey(client => client.Id);

        _ = modelBuilder.Entity<Client>()
            .HasIndex(client => client.ClientName)
            .IsUnique(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.Id)
            .HasColumnName(nameof(Client.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ClientName)
            .HasColumnName(nameof(Client.ClientName))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Client.CLIENTNAME_MAX_LENGTH})")
            .HasMaxLength(Client.CLIENTNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.WarehouseId)
            .HasColumnName(nameof(Client.WarehouseId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactFirstName)
            .HasColumnName(nameof(Client.ContactFirstName))
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Client.CLIENTNAME_MAX_LENGTH})")
            .HasMaxLength(Client.CONTACTFIRSTNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactLastName)
            .HasColumnName(nameof(Client.ContactLastName))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Client.CONTACTLASTNAME_MAX_LENGTH})")
            .HasMaxLength(Client.CONTACTLASTNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactEmail)
            .HasColumnName(nameof(Client.ContactEmail))
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Client.CONTACTEMAIL_MAX_LENGTH})")
            .HasMaxLength(Client.CONTACTEMAIL_MAX_LENGTH)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactTelephone)
            .HasColumnName(nameof(Client.ContactTelephone))
            .HasColumnOrder(6)
            .HasColumnType($"nvarchar({Client.CONTACTTELEPHONE_MAX_LENGTH})")
            .HasMaxLength(Client.CONTACTTELEPHONE_MAX_LENGTH)
            .IsRequired(false);


        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateCreated)
            .HasColumnName(nameof(Client.DateCreated))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateModified)
            .HasColumnName(nameof(Client.DateModified))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateDeleted)
            .HasColumnName(nameof(Client.DateDeleted))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.RowVersion)
            .HasColumnName(nameof(Client.RowVersion))
            .HasColumnOrder(10)
            .IsRowVersion();

        _ = modelBuilder.Entity<Client>()
            .HasOne(client => client.AssignedWarehouse)
            .WithMany(warehouse => warehouse.Clients)
            .HasForeignKey(client => client.WarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.ShippingOrders)
            .WithOne(order => order.SourceClient)
            .HasForeignKey(order => order.Id)
            .HasPrincipalKey(client => client.Id)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.Products)
            .WithOne(product => product.OwnerClient)
            .HasForeignKey(product => product.OwnerClient_Id)
            .HasPrincipalKey(client => client.Id)
            .IsRequired(false);

        #endregion

        #region WAREHOUSE
        _ = modelBuilder.Entity<Warehouse>()
            .ToTable("Warehouses")
            .HasKey(warehouse => warehouse.Id);

        _ = modelBuilder.Entity<Warehouse>()
            .HasIndex(warehouse => warehouse.WarehouseName)
            .IsUnique(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.Id)
            .HasColumnName(nameof(Warehouse.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.WarehouseName)
            .HasColumnName(nameof(Warehouse.WarehouseName))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Warehouse.WAREHOUSENAME_MAX_LENGTH})")
            .HasMaxLength(Warehouse.WAREHOUSENAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse)
            .HasColumnName(nameof(Warehouse.AddressId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateCreated)
            .HasColumnName(nameof(Warehouse.DateCreated))
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateModified)
            .HasColumnName(nameof(Warehouse.DateModified))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateDeleted)
            .HasColumnName(nameof(Warehouse.DateDeleted))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.RowVersion)
            .HasColumnName(nameof(Warehouse.RowVersion))
            .HasColumnOrder(6)
            .IsRowVersion();

        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.Clients)
            .WithOne(clients => clients.AssignedWarehouse)
            .HasForeignKey(client => client.WarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<Warehouse>()
            .HasOne(warehouse => warehouse.AssignedAddress)
            .WithOne(address => address.OwnerWarehouse)
            //.HasForeignKey()
            //.HasPrincipalKey(warehouse => warehouse.AddressId)
            .OnDelete(DeleteBehavior.SetNull);

        #endregion

        #region SHIPPINGORDER

        _ = modelBuilder.Entity<ShippingOrder>()
            .ToTable(nameof(this.ShippingOrders))
            .HasKey(shippingOrder => shippingOrder.Id);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Id)
            .HasColumnName(nameof(ShippingOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Status)
            .HasColumnName(nameof(ShippingOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({ShippingOrder.STATUS_MAX_LENGTH})")
            .HasMaxLength(ShippingOrder.STATUS_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
           .Property(shippingOrder => shippingOrder.Client_Id)
           .HasColumnName(nameof(ShippingOrder.Client_Id))
           .HasColumnOrder(2)
           .HasColumnType("int")
           .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Creator)
            .HasColumnName(nameof(ShippingOrder.Creator))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Address_Id)
            .HasColumnName(nameof(ShippingOrder.Address_Id))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Employee_Warehouse_Id)
            .HasColumnName(nameof(ShippingOrder.Employee_Warehouse_Id))
            .HasColumnOrder(5)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(shippingOrder => shippingOrder.Shipping_Id)
            .HasColumnName(nameof(ShippingOrder.Shipping_Id))
            .HasColumnOrder(6)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<ShippingOrder>()
          .Property(shippingOrder => shippingOrder.DateCreated)
          .HasColumnName(nameof(ShippingOrder.DateCreated))
          .HasColumnOrder(7)
          .HasColumnType("DateTime")
          .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
         .Property(shippingOrder => shippingOrder.DateModified)
         .HasColumnName(nameof(ShippingOrder.DateModified))
         .HasColumnOrder(8)
         .HasColumnType("DateTime")
         .IsRequired(true);


        _ = modelBuilder.Entity<ShippingOrder>()
          .Property(shippingOrder => shippingOrder.DateDeleted)
          .HasColumnName(nameof(ShippingOrder.DateDeleted))
          .HasColumnOrder(9)
          .HasColumnType("DateTime")
          .IsRequired(true);


        #endregion

        #region PURCHASEORDER

        _ = modelBuilder.Entity<PurchaseOrder>()
    .ToTable(nameof(this.PurchaseOrders))
    .HasKey(PurchaseOrder => PurchaseOrder.Id);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(PurchaseOrder => PurchaseOrder.Id)
            .HasColumnName(nameof(PurchaseOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(PurchaseOrder => PurchaseOrder.Status)
            .HasColumnName(nameof(PurchaseOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({PurchaseOrder.STATUS_MAX_LENGTH})")
            .HasMaxLength(PurchaseOrder.STATUS_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
           .Property(PurchaseOrder => PurchaseOrder.ProductToRestock)
           .HasColumnName(nameof(PurchaseOrder.ProductToRestock))
           .HasColumnOrder(2)
           .HasColumnType("int")
           .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(PurchaseOrder => PurchaseOrder.Warehouse)
            .HasColumnName(nameof(PurchaseOrder.Warehouse))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(PurchaseOrder => PurchaseOrder.QuantityToOrder)
            .HasColumnName(nameof(PurchaseOrder.QuantityToOrder))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<PurchaseOrder>()
        .Property(PurchaseOrder => PurchaseOrder.DateCreated)
        .HasColumnName(nameof(PurchaseOrder.DateCreated))
        .HasColumnOrder(5)
        .HasColumnType("DateTime")
        .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
        .Property(PurchaseOrder => PurchaseOrder.DateModified)
        .HasColumnName(nameof(PurchaseOrder.DateModified))
        .HasColumnOrder(6)
        .HasColumnType("DateTime")
        .IsRequired(true);


        _ = modelBuilder.Entity<PurchaseOrder>()
          .Property(PurchaseOrder => PurchaseOrder.DateDeleted)
          .HasColumnName(nameof(PurchaseOrder.DateDeleted))
          .HasColumnOrder(7)
          .HasColumnType("DateTime")
          .IsRequired(true);

      


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
