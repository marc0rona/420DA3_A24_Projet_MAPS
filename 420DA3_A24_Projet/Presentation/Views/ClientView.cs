using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Presentation;
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
    public Client? CurrentEntityInstance { get; private set; }
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

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Client instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.ActionButton.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void ReloadSelectors() {
        this.clientProductsValues.Items.Clear();
        foreach (Product product in this.app.ProductService.GetAllProducts()) { //ProductService n'est crée encore
            _ = this.clientProductsValues.Items.Add(product);
        }
        this.whEmpWarehouseValue.Items.Clear();
        foreach (Warehouse warehouse in this.app.WarehouseService.GetAllWarehouses()) { 
            _ = this.whEmpWarehouseValue.Items.Add(warehouse);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    private Client LoadDataInControls(Client client) {
        this.idValue.Value = client.Id;
        this.clientNameValue.Text = client.ClientName;
        this.contactFirstNameValue.Text = client.ContactFirstName;
        this.contactLastNameValue.Text = client.ContactLastName;
        this.emailValue.Text = client.ContactEmail;
        this.telephoneValue.Text = client.ContactTelephone;
        this.whEmpWarehouseValue.SelectedItem = client.AssignedWarehouse is not null
            ?client.AssignedWarehouse
            : null;
        this.dateCreatedValue.Value = client.DateCreated;
        this.dateModifiedValue.Value = client.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = client.DateDeleted ?? DateTime.Now;
        this.clientProductsValues.SelectedItems.Clear();
        foreach (Product product in client.Products) {
            this.clientProductsValues.SelectedItems.Add(product);
        }
        return client;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    private Client GetDataFromControls(Client client) {
        client.ClientName = this.clientNameValue.Text;
        client.ContactFirstName = this.contactFirstNameValue.Text;
        client.ContactLastName = this.contactLastNameValue.Text;
        client.ContactEmail = this.emailValue.Text;
        client.ContactTelephone = this.telephoneValue.Text;
        client.AssignedWarehouse = this.whEmpWarehouseValue.SelectedItem as Warehouse;
        client.Products = new List<Product>();
        foreach (Product product in this.clientProductsValues.SelectedItems) {
            client.Products.Add(product);
        }
        return client;
    }

    private void ActivateControls() {
        this.clientNameValue.Enabled = true;
        this.contactFirstNameValue.Enabled = true;
        this.contactLastNameValue.Enabled = true;
        this.emailValue.Enabled = true;
        this.telephoneValue.Enabled = true;
        this.whEmpWarehouseValue.Enabled = true;
        this.clientProductsValues.Enabled = true;
    }

    private void DeactivateControls() {
        this.clientNameValue.Enabled = false;
        this.contactFirstNameValue.Enabled = false;
        this.contactLastNameValue.Enabled = false;
        this.emailValue.Enabled = false;
        this.telephoneValue.Enabled = false;
        this.whEmpWarehouseValue.Enabled = false;
        this.clientProductsValues.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActionButton_Click(object sender, EventArgs e) {
        // TODO @PROF: implémenter processus des actions selon l'action courante
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

}
