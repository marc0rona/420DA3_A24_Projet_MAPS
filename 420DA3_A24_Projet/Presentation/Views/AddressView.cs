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

/* Auteur de la classe AddressView.cs : Pierre-Sylvestre Cypré */

internal partial class AddressView : Form {
    private bool isInitalized = false;
    private WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>
    /// The working <see cref="Address"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Address CurrentEntityInstance { get; private set; }

    /// <summary>
    /// Constructeur de  <see cref="AddressView"/>
    /// </summary>
    /// <param name="application"></param>
    public AddressView(WsysApplication application) {
        this.parentApp = application;
        InitializeComponent();
    }

    /// <summary>
    /// Ouvre une fenètre modal en mode création d'entité pour <see cref="AddressView"/>
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Address instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'une adresse", "Créer");
        return DialogResult.OK;
    }

    /// <summary>
    /// Ouvre une fenètre modal en mode visualisation d'entité pour <see cref="AddressView"/>
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Address instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'une adresse", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Ouvre une fenètre modal en mode modification d'entité pour <see cref="AddressView"/>
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Address instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier une adresse", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Ouvre une fenètre modal en mode suppression d'entité pour <see cref="AddressView"/>
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Address instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer une adresse", "Supprimer");
        return this.ShowDialog();
    }

    private void PreOpenSetup(Address instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        this.Initialize();
        this.CurrentAction = action;
        this.CurrentEntityInstance = instance;
        this.Text = windowTitle;
        this.btnAction.Text = actionButtonText;
        this.openedModeValue.Text = Enum.GetName(action);
        _ = this.LoadDataInControls(instance);
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }

    private void ReloadSelectors() {
        //@TODO
    }

    private void AddressView_Load(object sender, EventArgs e) {

    }
}
