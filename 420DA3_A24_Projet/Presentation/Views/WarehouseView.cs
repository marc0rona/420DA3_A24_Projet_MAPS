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
internal partial class WarehouseView : Form {
    private bool isInitialized = false;
    private WsysApplication app;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public Warehouse CurrentEntityInstance { get; private set; }
    public WarehouseView(WsysApplication application) {
        this.app = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un entrepot", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un entrepot", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un entrepot", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un entrepot", "Supprimer");
        return this.ShowDialog();
    }

    private void PreOpenSetup(Warehouse instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
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
        this.warehouseClientsListBox.Items.Clear();
        foreach (Client client in this.app.ClientService.GetAllClients()) { //GetAllClients n'existe encore
            _ = this.warehouseClientsListBox.Items.Add(client);
        }
        this.warehouseEmployeesListBox.Items.Clear();
        foreach (User user in this.app.UserService.GetEmployeeWarehouse()) { //GetEmployeeWarehouse n'existe encore
            _ = this.warehouseEmployeesListBox.Items.Add(user);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    private Warehouse LoadDataInControls(Warehouse warehouse) {
        this.idValue.Value = warehouse.Id;
        this.warehouseNameValue.Text = warehouse.WarehouseName;
        this.addressValue.Text = warehouse.AssignedAddress.Addressee;
        this.dateCreatedValue.Value = warehouse.DateCreated;
        this.dateModifiedValue.Value = warehouse.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = warehouse.DateDeleted ?? DateTime.Now;
        this.warehouseClientsListBox.SelectedItems.Clear();
        foreach (Client client in warehouse.Clients) {
            this.warehouseClientsListBox.SelectedItems.Add(client);
        }
        foreach (User user in warehouse.WarehouseEmployees) {
            this.warehouseEmployeesListBox.SelectedItems.Add(user);
        }
        return warehouse;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    private Warehouse GetDataFromControls(Warehouse warehouse) {
        warehouse.WarehouseName = this.warehouseNameValue.Text;
        //warehouse.AssignedAddress = this.addressValue.Text;
        warehouse.Clients = new List<Client>();
        foreach (Client client in this.warehouseClientsListBox.SelectedItems) {
            warehouse.Clients.Add(client);
        }
        warehouse.WarehouseEmployees = new List<User>();
        foreach (User user in this.warehouseEmployeesListBox.SelectedItems) {
            warehouse.WarehouseEmployees.Add(user);
        }
        return warehouse;
    }

    private void ActivateControls() {
        this.warehouseNameValue.Enabled = true;
        this.addressValue.Enabled = true;
        this.warehouseClientsListBox.Enabled = true;
        this.warehouseEmployeesListBox.Enabled = true;

    }

    private void DeactivateControls() {
        this.warehouseNameValue.Enabled = false;
        this.addressValue.Enabled = false;
        this.warehouseClientsListBox.Enabled = false;
        this.warehouseEmployeesListBox.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void actButton_Click(object sender, EventArgs e) {
        // TODO @PROF: implémenter processus des actions selon l'action courante
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void canButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

}
