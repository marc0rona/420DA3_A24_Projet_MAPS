namespace _420DA3_A24_Projet.Presentation.Views;

partial class PurchaseOrderView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBarPanel = new Panel();
        this.bottomBarPanel = new Panel();
        this.actButton = new Button();
        this.canButton = new Button();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.buttonAction = new Button();
        this.buttonAnnuler = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.statusLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.productLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.produitNumericUpDown = new NumericUpDown();
        this.quantiteNumericUpDown = new NumericUpDown();
        this.quantityLabel = new Label();
        this.purchaseOrderListBox = new ListBox();
        this.purchaseOrderLabel = new Label();
        this.warehouseListBox = new ListBox();
        this.warehouseLabel = new Label();
        this.statusComboBox = new ComboBox();
        this.bottomBarPanel.SuspendLayout();
        this.centerBarTabLayPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.produitNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.quantiteNumericUpDown).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(5, 6, 5, 6);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1486, 106);
        this.topBarPanel.TabIndex = 7;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonAnnuler);
        this.bottomBarPanel.Controls.Add(this.buttonAction);
        this.bottomBarPanel.Controls.Add(this.actButton);
        this.bottomBarPanel.Controls.Add(this.canButton);
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 1091);
        this.bottomBarPanel.Margin = new Padding(5, 6, 5, 6);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1486, 106);
        this.bottomBarPanel.TabIndex = 8;
        // 
        // actButton
        // 
        this.actButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actButton.Location = new Point(2374, 33);
        this.actButton.Margin = new Padding(5, 6, 5, 6);
        this.actButton.Name = "actButton";
        this.actButton.Size = new Size(212, 49);
        this.actButton.TabIndex = 5;
        this.actButton.Text = "ACTION";
        this.actButton.UseVisualStyleBackColor = true;
        // 
        // canButton
        // 
        this.canButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.canButton.Location = new Point(2598, 33);
        this.canButton.Margin = new Padding(5, 6, 5, 6);
        this.canButton.Name = "canButton";
        this.canButton.Size = new Size(139, 49);
        this.canButton.TabIndex = 4;
        this.canButton.Text = "Annuler";
        this.canButton.UseVisualStyleBackColor = true;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(3618, 10);
        this.actionButton.Margin = new Padding(5, 6, 5, 6);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(212, 49);
        this.actionButton.TabIndex = 3;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(3842, 10);
        this.cancelButton.Margin = new Padding(5, 6, 5, 6);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(139, 49);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(4839, -6);
        this.btnAction.Margin = new Padding(5, 6, 5, 6);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(212, 49);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(5062, -6);
        this.btnCancel.Margin = new Padding(5, 6, 5, 6);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(139, 49);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // buttonAction
        // 
        this.buttonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonAction.Location = new Point(1040, 29);
        this.buttonAction.Margin = new Padding(5, 6, 5, 6);
        this.buttonAction.Name = "buttonAction";
        this.buttonAction.Size = new Size(212, 49);
        this.buttonAction.TabIndex = 6;
        this.buttonAction.Text = "ACTION";
        this.buttonAction.UseVisualStyleBackColor = true;
        // 
        // buttonAnnuler
        // 
        this.buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAnnuler.Location = new Point(1306, 29);
        this.buttonAnnuler.Margin = new Padding(5, 6, 5, 6);
        this.buttonAnnuler.Name = "buttonAnnuler";
        this.buttonAnnuler.Size = new Size(139, 49);
        this.buttonAnnuler.TabIndex = 7;
        this.buttonAnnuler.Text = "Annuler";
        this.buttonAnnuler.UseVisualStyleBackColor = true;
        // 
        // centerBarTabLayPanel
        // 
        this.centerBarTabLayPanel.ColumnCount = 3;
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 742F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerBarTabLayPanel.Dock = DockStyle.Fill;
        this.centerBarTabLayPanel.Location = new Point(0, 106);
        this.centerBarTabLayPanel.Margin = new Padding(5, 6, 5, 6);
        this.centerBarTabLayPanel.Name = "centerBarTabLayPanel";
        this.centerBarTabLayPanel.RowCount = 1;
        this.centerBarTabLayPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerBarTabLayPanel.Size = new Size(1486, 985);
        this.centerBarTabLayPanel.TabIndex = 9;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.statusComboBox);
        this.centerPanel.Controls.Add(this.warehouseLabel);
        this.centerPanel.Controls.Add(this.warehouseListBox);
        this.centerPanel.Controls.Add(this.purchaseOrderLabel);
        this.centerPanel.Controls.Add(this.purchaseOrderListBox);
        this.centerPanel.Controls.Add(this.quantityLabel);
        this.centerPanel.Controls.Add(this.quantiteNumericUpDown);
        this.centerPanel.Controls.Add(this.produitNumericUpDown);
        this.centerPanel.Controls.Add(this.statusLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.productLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(377, 6);
        this.centerPanel.Margin = new Padding(5, 6, 5, 6);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(732, 973);
        this.centerPanel.TabIndex = 0;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(9, 74);
        this.statusLabel.Margin = new Padding(9, 10, 9, 10);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(268, 49);
        this.statusLabel.TabIndex = 20;
        this.statusLabel.Text = "Status :";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        this.statusLabel.Click += this.warehouseNameLabel_Click;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(291, 398);
        this.dateDeletedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(432, 39);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(291, 329);
        this.dateModifiedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(432, 39);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(291, 260);
        this.dateCreatedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(432, 39);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(9, 393);
        this.dateDeletedLabel.Margin = new Padding(9, 10, 9, 10);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(268, 49);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(9, 324);
        this.dateModifiedLabel.Margin = new Padding(9, 10, 9, 10);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(268, 49);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(9, 255);
        this.dateCreatedLabel.Margin = new Padding(9, 10, 9, 10);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(268, 49);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productLabel
        // 
        this.productLabel.Location = new Point(9, 129);
        this.productLabel.Margin = new Padding(9, 10, 9, 10);
        this.productLabel.Name = "productLabel";
        this.productLabel.Size = new Size(268, 49);
        this.productLabel.TabIndex = 2;
        this.productLabel.Text = "Pruduit :";
        this.productLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(291, 15);
        this.idValue.Margin = new Padding(5, 6, 5, 6);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(434, 39);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(9, 12);
        this.idLabel.Margin = new Padding(9, 10, 9, 10);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(268, 49);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // produitNumericUpDown
        // 
        this.produitNumericUpDown.Enabled = false;
        this.produitNumericUpDown.Location = new Point(289, 135);
        this.produitNumericUpDown.Margin = new Padding(5, 6, 5, 6);
        this.produitNumericUpDown.Name = "produitNumericUpDown";
        this.produitNumericUpDown.Size = new Size(434, 39);
        this.produitNumericUpDown.TabIndex = 26;
        // 
        // quantiteNumericUpDown
        // 
        this.quantiteNumericUpDown.Enabled = false;
        this.quantiteNumericUpDown.Location = new Point(288, 195);
        this.quantiteNumericUpDown.Margin = new Padding(5, 6, 5, 6);
        this.quantiteNumericUpDown.Name = "quantiteNumericUpDown";
        this.quantiteNumericUpDown.Size = new Size(434, 39);
        this.quantiteNumericUpDown.TabIndex = 27;
        // 
        // quantityLabel
        // 
        this.quantityLabel.Location = new Point(9, 191);
        this.quantityLabel.Margin = new Padding(9, 10, 9, 10);
        this.quantityLabel.Name = "quantityLabel";
        this.quantityLabel.Size = new Size(268, 49);
        this.quantityLabel.TabIndex = 28;
        this.quantityLabel.Text = "Quantite :";
        this.quantityLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // purchaseOrderListBox
        // 
        this.purchaseOrderListBox.FormattingEnabled = true;
        this.purchaseOrderListBox.ItemHeight = 32;
        this.purchaseOrderListBox.Location = new Point(291, 466);
        this.purchaseOrderListBox.Margin = new Padding(5, 6, 5, 6);
        this.purchaseOrderListBox.Name = "purchaseOrderListBox";
        this.purchaseOrderListBox.SelectionMode = SelectionMode.MultiSimple;
        this.purchaseOrderListBox.Size = new Size(430, 228);
        this.purchaseOrderListBox.TabIndex = 29;
        // 
        // purchaseOrderLabel
        // 
        this.purchaseOrderLabel.Location = new Point(9, 456);
        this.purchaseOrderLabel.Margin = new Padding(9, 10, 9, 10);
        this.purchaseOrderLabel.Name = "purchaseOrderLabel";
        this.purchaseOrderLabel.Size = new Size(268, 49);
        this.purchaseOrderLabel.TabIndex = 30;
        this.purchaseOrderLabel.Text = "Ordre des produits :";
        this.purchaseOrderLabel.TextAlign = ContentAlignment.MiddleRight;
        this.purchaseOrderLabel.Click += this.warehouseClientsLabel_Click;
        // 
        // warehouseListBox
        // 
        this.warehouseListBox.FormattingEnabled = true;
        this.warehouseListBox.ItemHeight = 32;
        this.warehouseListBox.Location = new Point(291, 722);
        this.warehouseListBox.Margin = new Padding(5, 6, 5, 6);
        this.warehouseListBox.Name = "warehouseListBox";
        this.warehouseListBox.SelectionMode = SelectionMode.MultiSimple;
        this.warehouseListBox.Size = new Size(430, 228);
        this.warehouseListBox.TabIndex = 31;
        // 
        // warehouseLabel
        // 
        this.warehouseLabel.Location = new Point(9, 711);
        this.warehouseLabel.Margin = new Padding(9, 10, 9, 10);
        this.warehouseLabel.Name = "warehouseLabel";
        this.warehouseLabel.Size = new Size(268, 49);
        this.warehouseLabel.TabIndex = 32;
        this.warehouseLabel.Text = "Entrepot :";
        this.warehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusComboBox
        // 
        this.statusComboBox.FormattingEnabled = true;
        this.statusComboBox.Location = new Point(291, 78);
        this.statusComboBox.Name = "statusComboBox";
        this.statusComboBox.Size = new Size(430, 40);
        this.statusComboBox.TabIndex = 33;
        // 
        // PurchaseOrderView
        // 
        this.AutoScaleDimensions = new SizeF(13F, 32F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1486, 1197);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "PurchaseOrderView";
        this.Text = "PurchaseOrderView";
        this.bottomBarPanel.ResumeLayout(false);
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.produitNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.quantiteNumericUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private Button actButton;
    private Button canButton;
    private Button actionButton;
    private Button cancelButton;
    private Button btnAction;
    private Button btnCancel;
    private Button buttonAction;
    private Button buttonAnnuler;
    private TableLayoutPanel centerBarTabLayPanel;
    private Panel centerPanel;
    private Label statusLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label productLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private NumericUpDown produitNumericUpDown;
    private Label quantityLabel;
    private NumericUpDown quantiteNumericUpDown;
    private ListBox purchaseOrderListBox;
    private Label purchaseOrderLabel;
    private ListBox warehouseListBox;
    private Label warehouseLabel;
    private ComboBox statusComboBox;
}