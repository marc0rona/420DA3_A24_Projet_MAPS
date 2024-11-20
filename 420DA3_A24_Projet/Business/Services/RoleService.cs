using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class RoleService {

    private WsysApplication parentApp;
    private RoleDAO dao;
    private RoleView view;

    public RoleService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }
}
