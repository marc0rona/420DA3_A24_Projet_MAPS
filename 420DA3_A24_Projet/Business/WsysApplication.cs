using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private AppDbContext context;

    public PasswordService PasswordService { get; private set; }
    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }
    public LoginService LoginService { get; private set; }

    // TODO @Équipe ajoutez des propriétés pour vos services ici

    // @Pierre
    public AddressService AddressService { get; private set; }
    public ShipmentService ShipmentService { get; private set; }
    public TrackingNumberFactory TrackingNumberFactory { get; private set; }

    public WsysApplication(AppDbContext context) {
        this.context = new AppDbContext();
        this.PasswordService = PasswordService.GetInstance();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
        //finir le reste des services...

        // @Pierre
        this.AddressService = new AddressService(this, this.context);
        this.ShipmentService = new ShipmentService(this, this.context);
        this.TrackingNumberFactory = TrackingNumberFactory.GetInstance();

        
        this.LoginService = new LoginService(this);
    }


}