using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business;
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
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class SupplierView : Form {
    //Main system
    private readonly WsysApplication wsys;
    //current Actions by User
    public ViewActionsEnum UserAction { get; private set; }
    public Supplier? CurrentEntityInstance { get; private set; }
    //pour Affichage
    private List<Supplier> suppliers = new List<Supplier>();
    //variables pour fonctions void
    private bool isInitialized = false;

    public SupplierView(WsysApplication application) {
        this.wsys = application;
        this.InitializeComponent();
    }

    private void BtnQuit_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    //Void methodes
    private void ReloadSelectors() {
        try {
            this.listBox_Suppliers.Items.Clear();
            List<Supplier> supplierz = this.wsys.SupplierService.GetAllSuppliers();
            foreach (Supplier supplier in supplierz) {
                _ = this.listBox_Suppliers.Items.Add(supplier);
            }
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to load data.", ex);
        }
    }
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }
    private void PreOpenSetup(Supplier instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        this.UserAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        this.Text = windowTitle;
        this.Btn_Action.Text = actionButtonText;
        // load data from the current instance in the controls
        _ = this.LoadInstanceInControls(instance);
    }

    private Supplier LoadInstanceInControls(Supplier supplier) {
        if (supplier is not null) {
            this.txt_Id.Text = supplier.Id.ToString();
            this.txt_Company.Text = supplier.Name;
            this.txt_Prenom.Text = supplier.Contact_FirstName;
            this.txt_Nom.Text = supplier.Contact_LastName;
            this.txt_Email.Text = supplier.Contact_Email;
            this.txt_Phone.Text = supplier.Contact_Phone;
            this.dateCreatedValue.Value = supplier.DateCreated;
            this.dateModifiedValue.Value = supplier.DateModified ?? DateTime.Now;
            this.dateDeletedValue.Value = supplier.DateDeleted ?? DateTime.Now;
        }
        this.listBox_Products.SelectedItems.Clear();
        return supplier;
    }
    public Supplier? GetCurrentInstance() {
        return this.CurrentEntityInstance;
    }
    private Supplier SaveDataFromControls(Supplier supplier) {
        try {
            supplier.Name = this.txt_Company.Text.Trim();
            supplier.Contact_FirstName = this.txt_Prenom.Text.Trim();
            supplier.Contact_LastName = this.txt_Nom.Text.Trim();
            supplier.Contact_Email = this.txt_Email.Text.Trim();
            supplier.Contact_Phone = this.txt_Phone.Text.Trim();
            foreach (Product prod in this.listBox_Products.Items) {
                supplier.ProductList.Add(prod);
            }
            return supplier;
        } catch (Exception ex) {
            // Show a message box with the error details
            MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return supplier;
        }
    }
    private void Btn_Action_Click(object sender, EventArgs e) {
        try {

            switch (this.UserAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.wsys.SupplierService.Create(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.wsys.SupplierService.Update(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    string msg = this.wsys.SupplierService.Delete(this.CurrentEntityInstance);
                    MessageBox.Show($"supplier {msg} supprimé", "Confirmation");
                    break;
                case ViewActionsEnum.Visualization:
                    // nothing to do
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.UserAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.wsys.HandleException(ex);
        }
    }
    //Dialoge Results
    public DialogResult OpenForCreation(Supplier instance) 
    {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un Fournisseur", "Créer");
        return this.ShowDialog();
    }

    public DialogResult OpenForDetailsView(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un Fournisseur", "OK");
        return this.ShowDialog();
    }
    public DialogResult OpenForModification(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un Fournisseur", "Enregistrer");
        return this.ShowDialog();
    }
    public DialogResult OpenForDeletion(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un Fournisseur", "Supprimer");
        return this.ShowDialog();
    }

    private void listBox_Suppliers_SelectedIndexChanged(object sender, EventArgs e) 
    {
        string searched = this.txt_Search.Text;
        List<Supplier> searchResults /*lister produits en results */ = this.suppliers.Where
            (supp => supp.Id.ToString().Contains(searched) //seachBar contient Id
                  || supp.Name.Contains(searched) //seachBar contient Nom
                  || supp.Contact_FirstName.Contains(searched)
                  || supp.Contact_LastName.Contains(searched)
                  || supp.Contact_Email.Contains(searched)
            ).ToList();

        int? select_SuppId = (this.listBox_Suppliers.SelectedItem as Supplier)?.Id;
        //Vider listBox
        this.listBox_Suppliers.Items.Clear();
        this.listBox_Suppliers.SelectedItem = null;
        //Re-remplir searchBox
        foreach (Supplier supplier in searchResults) {
            _ = this.listBox_Suppliers.Items.Add(supplier);
            //Assure que le Id existe
            if (select_SuppId is not null && supplier.Id == select_SuppId) { this.listBox_Suppliers.SelectedItem = supplier; }
        }
    }
}
