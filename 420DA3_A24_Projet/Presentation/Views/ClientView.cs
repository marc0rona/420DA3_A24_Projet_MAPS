using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ClientView : Form {
    private bool isInitialized = false;
    private WsysApplication app;
    
    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public Client CurrentEntityInstance { get; private set; }
    public ClientView(WsysApplication application) {
        this.app = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Client instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un client", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Client instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un client", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Client instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un client", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Client instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un client", "Supprimer");
        return this.ShowDialog();
    }

}
