using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
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
public partial class PurchaseOrderView : Form {
    public PurchaseOrderView() {
        InitializeComponent();
       

    }

    private void warehouseNameLabel_Click(object sender, EventArgs e) {

    }

    private void warehouseClientsLabel_Click(object sender, EventArgs e) {

    }

    private void idValue_ValueChanged(object sender, EventArgs e) {

    }

    private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e) 
    {
       

    }

    private void produitNumericUpDown_ValueChanged(object sender, EventArgs e) {
        if (purchaseOrderListBox.SelectedItem is PurchaseOrder selectedOrder) {
            selectedOrder.ProductId = (int) produitNumericUpDown.Value;
            PurchaseOrderService.UpdatePurchaseOrder(selectedOrder);
        }
    }

    private void quantiteNumericUpDown_ValueChanged(object sender, EventArgs e) 
    {
        if (purchaseOrderListBox.SelectedItem is PurchaseOrder selectedOrder) {
            selectedOrder.Quantity = (int) quantiteNumericUpDown.Value;
            PurchaseOrderService.UpdatePurchaseOrder(selectedOrder);
        }

    }

    private void dateCreatedValue_ValueChanged(object sender, EventArgs e) {

    }

    private void dateModifiedValue_ValueChanged(object sender, EventArgs e) {

    }

    private void dateDeletedValue_ValueChanged(object sender, EventArgs e) {

    }

    private void purchaseOrderListBox_SelectedIndexChanged(object sender, EventArgs e) 
    {
        if (purchaseOrderListBox.SelectedItem is PurchaseOrder selectedOrder) {
            idValue.Value = selectedOrder.Id;
            produitNumericUpDown.Value = selectedOrder.ProductId;
            quantiteNumericUpDown.Value = selectedOrder.Quantity;
            statusComboBox.SelectedItem = selectedOrder.Status;
            dateCreatedValue.Value = selectedOrder.DateCreated;
            dateModifiedValue.Value = selectedOrder.DateModified ?? DateTime.Now;
            dateDeletedValue.Value = selectedOrder.DateDeleted ?? DateTime.Now;
        }

    }

    private void warehouseListBox_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void idLabel_Click(object sender, EventArgs e) {

    }

    private void productLabel_Click(object sender, EventArgs e) {

    }

    private void quantityLabel_Click(object sender, EventArgs e) {

    }

    private void dateCreatedLabel_Click(object sender, EventArgs e) {

    }

    private void dateModifiedLabel_Click(object sender, EventArgs e) {

    }

    private void dateDeletedLabel_Click(object sender, EventArgs e) {

    }

    private void warehouseLabel_Click(object sender, EventArgs e) {

    }
}
