using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
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
/// Management window for <see cref="Shipment"/>
/// </summary>

internal partial class ShipmentView : Form {
    private bool isInitalized = false;
    private readonly WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>
    /// The working <see cref="Shipment"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Shipment CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="ShipmentView"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public ShipmentView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'une expédition", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'une expédition", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier une expéditioon", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer une expédition", "Supprimer");
        return this.ShowDialog();
    }

    private void PreOpenSetup(Shipment instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
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

    private Shipment LoadDataInControls(Shipment shipment) {
        this.idValue.Value = shipment.Id;
        this.statusValue.SelectedItem = shipment.Status; // ajouter null (combobox)
        this.shippingServiceValue.SelectedItem = shipment.ShippingService;
        this.shippingOrderIdValue.Value = shipment.ShippingOrderId;
        this.trackingNumberValue.Text = shipment.TrackingNumber;
        this.dateCreatedValue.Value = shipment.DateCreated;
        this.dateModifiedValue.Value = shipment.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = shipment.DateDeleted ?? DateTime.Now;
        return shipment;
    }

    private Shipment SaveDataFromControls(Shipment shipment) {
        shipment.Status = (ShipmentStatusEnum) this.statusValue.SelectedItem; // arranger
        shipment.ShippingService = (ShippingProvidersEnum) this.shippingServiceValue.SelectedItem; // aranger
        shipment.ShippingOrderId = (int) this.shippingOrderIdValue.Value;
        // ajouter tracking number
        return shipment;
    }

    /// <summary>
    /// Enables the <see cref="ShipmentView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.statusValue.Enabled = true;
        this.shippingServiceValue.Enabled = true;
        this.trackingNumberValue.Enabled = true;
        this.shippingOrderIdValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="AddressView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.statusValue.Enabled = false;
        this.shippingServiceValue.Enabled = false;
        this.trackingNumberValue.Enabled = false;
        this.shippingOrderIdValue.Enabled = false;
    }


    private void actionButton_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.ShipmentService.CreateShipment(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.ShipmentService.UpdateShipment(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.ShipmentService.DeleteShipment(this.CurrentEntityInstance);
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
