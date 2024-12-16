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
internal partial class ProductView : Form {
    //Main system
    private readonly WsysApplication wsys;
    //current Actions by User
    public ViewActionsEnum UserAction { get; private set; }
    public ProductView? CurrentEntityInstance { get; private set; }
    //pour Affichage
    private List<Product> products = new List<Product>();

    public ProductView(WsysApplication application) {
        this.wsys = application;
        this.InitializeComponent();
    }

    private void btn_Quit_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void Txt_SearchBox_TextChanged(object sender, EventArgs e) 
    {
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
}
