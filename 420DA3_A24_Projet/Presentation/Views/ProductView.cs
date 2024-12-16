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
internal partial class ProductView : Form {
    //Main system
    private readonly WsysApplication wsys;
    //current Actions by User
    public ViewActionsEnum UserAction { get; private set; }
    public Product? CurrentEntityInstance { get; private set; }
    //pour Affichage
    private List<Product> products = new List<Product>();
    //variables pour fonctions void
    private bool isInitialized = false;
    public ProductView(WsysApplication application) {
        this.wsys = application;
        this.InitializeComponent();
    }

    private void btn_Quit_Click(object sender, EventArgs e) {
        this.Close();
    }

    //Void methodes
    private void ReloadSelectors() {
        try {
            this.listBox_Products.Items.Clear();
            List<Product> prod = this.wsys.ProductService.GetAllProducts();
            foreach (Product product in prod) {
                _ = this.listBox_Products.Items.Add(product);
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
    private void PreOpenSetup(Product instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
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
    private Product LoadInstanceInControls(Product product) {
        if (product is not null) {
            this.txt_Id.Text = product.Id.ToString();
            this.txt_Name.Text = product.Name;
            this.txt_Description.Text = product.Description;
            this.txt_codeUPC.Text = product.Code_UPC;
            this.txt_codeSupplier.Text = product.Code_Supplier;
            this.txt_Client.Text = product.OwnerClient.ToString();
            this.txt_Supplier.Text = product.Supplier.ToString();
            this.txt_Qty_InStock.Text = product.Qty_InStock.ToString();
            this.txt_Qty_Desired.Text = product.Qty_Desired.ToString();
            this.txt_Weight.Text = product.Weight_inKg.ToString();
            this.dateCreatedValue.Value = product.DateCreated;
            this.dateModifiedValue.Value = product.DateModified ?? DateTime.Now;
            this.dateDeletedValue.Value = product.DateDeleted ?? DateTime.Now;
        }
        this.listBox_Products.SelectedItems.Clear();
        return product;
    }
    public Product? GetCurrentInstance() {
        return this.CurrentEntityInstance;
    }
    private void Txt_SearchBox_TextChanged(object sender, EventArgs e) {
        string searched = this.Txt_SearchBox.Text;
        List<Product> searchResults /*lister produits en results */ = this.products.Where
            (prod => prod.Id.ToString().Contains(searched) //seachBar contient Id
                  || prod.Name.Contains(searched) //seachBar contient Nom
                                                  //valeurs qui peuvent etre nullables
                  || prod.Code_Supplier.Contains(searched)
                  || prod.OwnerClient.ToString().Contains(searched) //Id du Client
                  || prod.Supplier.ToString().Contains(searched) //Id du Supplier
            ).ToList();

        int? select_ProdId = (this.listBox_Products.SelectedItem as Product)?.Id;
        //Vider listBox
        this.listBox_Products.Items.Clear();
        this.listBox_Products.SelectedItem = null;
        //Re-remplir searchBox
        foreach (Product product in searchResults) {
            _ = this.listBox_Products.Items.Add(product);
            //Assure que le Id existe
            if (select_ProdId is not null && product.Id == select_ProdId) { this.listBox_Products.SelectedItem = product; }
        }
    }

    private void Btn_Action_Click(object sender, EventArgs e) {

    }
    //Dialoge Results
    public DialogResult OpenForCreation(Product instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }
}
