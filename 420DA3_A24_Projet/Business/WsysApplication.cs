using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private AppDbContext context;

    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }

    // TODO @Équipe ajoutez des propriétés pour vos services ici

    public WsysApplication(AppDbContext context) {
        this.context = new AppDbContext();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
        //finir le reste des services...
    }


}