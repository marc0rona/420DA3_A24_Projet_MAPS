using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation;
internal partial class WhEmpMainMenu : Form {

    private WsysApplication parentApp;
    public WhEmpMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult ShowWhEmpMainMenu() {
        return this.ShowDialog();
    }
}
