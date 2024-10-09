
global using global::System;
global using global::System.Collections.Generic;
global using global::System.Drawing;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using global::System.Windows.Forms;
using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.Presentation;

namespace _420DA3_A24_Exemple_Enseignant.Business;
internal class ExempleApplication {
    private readonly ExempleDbContext dbContext;
    private readonly MainMenu mainMenu;
    public MedecinService MedecinService { get; private set; }
    public PatientService PatientService { get; private set; }
    public RendezVousService RendezVousService { get; private set; }

    public ExempleApplication() {
        ApplicationConfiguration.Initialize();
        this.dbContext = new ExempleDbContext();
        this.mainMenu = new MainMenu();
        this.MedecinService = new MedecinService(this, this.dbContext);
        this.PatientService = new PatientService(this, this.dbContext);
        this.RendezVousService = new RendezVousService(this, this.dbContext);
    }

    public void Start() {
        Application.Run(this.mainMenu);
    }

    public void Shutdown() {
        Application.Exit();
    }
}
