using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
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

/// <summary>
/// Management window for <see cref="Address"/> entities.
/// </summary>

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
    public Address CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// Constructeur de  <see cref="AddressView"/>
    /// </summary>
    /// <param name="application"></param>
    public AddressView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
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
        // avoir en mémoire l'action actuelle
        this.CurrentAction = action;
        // savoir quelle instance avec laquelle on travaille
        this.CurrentEntityInstance = instance;
        // Changer le titre de la fenêtre
        this.Text = windowTitle;
        // changer le bouton d'action
        this.btnAction.Text = actionButtonText;
        // montrer l'action en cours dans la barre en haut
        this.openendModeValue.Text = Enum.GetName(action);
        // charger les données de l'instance actuelle dans les contrôles
        _ = this.LoadDataInControls(instance);
        // activer ou désactiver les contrôles modifiables dépendant de l'action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    private Address LoadDataInControls(Address address) {
        this.idValue.Value = address.Id;
        this.addressTypeValue.SelectedItem = address.AddressType;
        this.addresseeValue.Text = address.Addressee;
        this.civicNumberValue.Text = address.CivicNumber;
        this.streetValue.Text = address.Street;
        this.cityValue.Text = address.City;
        this.stateLabel.Text = address.State;
        this.countryLabel.Text = address.Country;
        this.postalCodeValue.Text = address.PostalCode;
        this.dateCreatedValue.Value = address.DateCreated;
        this.dateModifiedValue.Value = address.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = address.DateDeleted ?? DateTime.Now;
        return address;
    }

    private Address SaveDataFromControls(Address address) {
        // address.AddressType = this.addressTypeValue.SelectedItem;
        address.Addressee = this.addresseeValue.Text.Trim();
        address.CivicNumber = this.civicNumberValue.Text.Trim();
        address.Street = this.streetValue.Text.Trim();
        address.City = this.cityValue.Text.Trim();
        address.State = this.stateLabel.Text.Trim();
        address.Country = this.countryValue.Text.Trim();
        address.PostalCode = this.postalCodeValue.Text.Trim();
        return address;
    }


    private void ActivateControls() {
        this.addressTypeValue.Enabled = true;
        this.addresseeValue.Enabled = true;
        this.civicNumberValue.Enabled = true;
        this.streetValue.Enabled = true;
        this.cityValue.Enabled = true;
        this.stateLabel.Enabled = true;
        this.countryLabel.Enabled = true;
        this.postalCodeValue.Enabled = true;
    }

    private void DeactivateControls() {
        this.addressTypeValue.Enabled = false;
        this.addresseeValue.Enabled = false;
        this.civicNumberValue.Enabled = false;
        this.streetValue.Enabled = false;
        this.cityValue.Enabled = false;
        this.stateLabel.Enabled = false;
        this.countryLabel.Enabled = false;
        this.postalCodeValue.Enabled = false;
    }

    private void AddressView_Load(object sender, EventArgs e) {

    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.AddressService.CreateAddress(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.AddressService.UpdateAddress(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.AddressService.DeleteAddress(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    // nothing to do
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }
}
