namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShippingOrderView {
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
        this.buttonAnnuler = new Button();
        this.buttonAction = new Button();
        this.actButton = new Button();
        this.canButton = new Button();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.statusComboBox = new ComboBox();
        this.fullfillerEmployeeLabel = new Label();
        this.shippingOrderProductLabel = new Label();
        this.shippingOrderProductListBox = new ListBox();
        this.creatorEmployeedIdLabel = new Label();
        this.statusLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.ShippingDateLabel = new Label();
        this.sourceClientIdLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.sourceClientIdNameValue = new TextBox();
        this.creatorEmployeeIdNameValue = new TextBox();
        this.destinationAdressIdNameValue = new TextBox();
        this.destinationAdressIdLabel = new Label();
        this.ShipmentNameValue = new TextBox();
        this.shipmentLabel = new Label();
        this.fulfillerEmployeeListBox = new ListBox();
        this.bottomBarPanel.SuspendLayout();
        this.centerBarTabLayPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(5, 6, 5, 6);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1586, 106);
        this.topBarPanel.TabIndex = 8;
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
        this.bottomBarPanel.Location = new Point(0, 1447);
        this.bottomBarPanel.Margin = new Padding(5, 6, 5, 6);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1586, 106);
        this.bottomBarPanel.TabIndex = 9;
        // 
        // buttonAnnuler
        // 
        this.buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAnnuler.Location = new Point(2692, 35);
        this.buttonAnnuler.Margin = new Padding(5, 6, 5, 6);
        this.buttonAnnuler.Name = "buttonAnnuler";
        this.buttonAnnuler.Size = new Size(139, 49);
        this.buttonAnnuler.TabIndex = 7;
        this.buttonAnnuler.Text = "Annuler";
        this.buttonAnnuler.UseVisualStyleBackColor = true;
        // 
        // buttonAction
        // 
        this.buttonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonAction.Location = new Point(2426, 35);
        this.buttonAction.Margin = new Padding(5, 6, 5, 6);
        this.buttonAction.Name = "buttonAction";
        this.buttonAction.Size = new Size(212, 49);
        this.buttonAction.TabIndex = 6;
        this.buttonAction.Text = "ACTION";
        this.buttonAction.UseVisualStyleBackColor = true;
        // 
        // actButton
        // 
        this.actButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actButton.Location = new Point(3760, 39);
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
        this.canButton.Location = new Point(3984, 39);
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
        this.actionButton.Location = new Point(5004, 16);
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
        this.cancelButton.Location = new Point(5228, 16);
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
        this.btnAction.Location = new Point(6225, 0);
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
        this.btnCancel.Location = new Point(6448, 0);
        this.btnCancel.Margin = new Padding(5, 6, 5, 6);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(139, 49);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
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
        this.centerBarTabLayPanel.Size = new Size(1586, 1341);
        this.centerBarTabLayPanel.TabIndex = 10;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.fulfillerEmployeeListBox);
        this.centerPanel.Controls.Add(this.shipmentLabel);
        this.centerPanel.Controls.Add(this.ShipmentNameValue);
        this.centerPanel.Controls.Add(this.destinationAdressIdLabel);
        this.centerPanel.Controls.Add(this.destinationAdressIdNameValue);
        this.centerPanel.Controls.Add(this.creatorEmployeeIdNameValue);
        this.centerPanel.Controls.Add(this.sourceClientIdNameValue);
        this.centerPanel.Controls.Add(this.statusComboBox);
        this.centerPanel.Controls.Add(this.fullfillerEmployeeLabel);
        this.centerPanel.Controls.Add(this.shippingOrderProductLabel);
        this.centerPanel.Controls.Add(this.shippingOrderProductListBox);
        this.centerPanel.Controls.Add(this.creatorEmployeedIdLabel);
        this.centerPanel.Controls.Add(this.statusLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.ShippingDateLabel);
        this.centerPanel.Controls.Add(this.sourceClientIdLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(427, 6);
        this.centerPanel.Margin = new Padding(5, 6, 5, 6);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(732, 1329);
        this.centerPanel.TabIndex = 0;
        // 
        // statusComboBox
        // 
        this.statusComboBox.FormattingEnabled = true;
        this.statusComboBox.Location = new Point(291, 72);
        this.statusComboBox.Name = "statusComboBox";
        this.statusComboBox.Size = new Size(430, 40);
        this.statusComboBox.TabIndex = 33;
        // 
        // fullfillerEmployeeLabel
        // 
        this.fullfillerEmployeeLabel.Location = new Point(3, 911);
        this.fullfillerEmployeeLabel.Margin = new Padding(9, 10, 9, 10);
        this.fullfillerEmployeeLabel.Name = "fullfillerEmployeeLabel";
        this.fullfillerEmployeeLabel.Size = new Size(268, 49);
        this.fullfillerEmployeeLabel.TabIndex = 32;
        this.fullfillerEmployeeLabel.Text = "Fiche d'employee :";
        this.fullfillerEmployeeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // shippingOrderProductLabel
        // 
        this.shippingOrderProductLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
        this.shippingOrderProductLabel.Location = new Point(-36, 540);
        this.shippingOrderProductLabel.Margin = new Padding(9, 10, 9, 10);
        this.shippingOrderProductLabel.Name = "shippingOrderProductLabel";
        this.shippingOrderProductLabel.Size = new Size(311, 49);
        this.shippingOrderProductLabel.TabIndex = 30;
        this.shippingOrderProductLabel.Text = "Ordre d'expedition produit :";
        this.shippingOrderProductLabel.TextAlign = ContentAlignment.MiddleRight;
        this.shippingOrderProductLabel.Click += this.shippingOrderProductLabel_Click;
        // 
        // shippingOrderProductListBox
        // 
        this.shippingOrderProductListBox.FormattingEnabled = true;
        this.shippingOrderProductListBox.ItemHeight = 32;
        this.shippingOrderProductListBox.Location = new Point(289, 555);
        this.shippingOrderProductListBox.Margin = new Padding(5, 6, 5, 6);
        this.shippingOrderProductListBox.Name = "shippingOrderProductListBox";
        this.shippingOrderProductListBox.SelectionMode = SelectionMode.MultiSimple;
        this.shippingOrderProductListBox.Size = new Size(430, 324);
        this.shippingOrderProductListBox.TabIndex = 29;
        // 
        // creatorEmployeedIdLabel
        // 
        this.creatorEmployeedIdLabel.Location = new Point(9, 180);
        this.creatorEmployeedIdLabel.Margin = new Padding(9, 10, 9, 10);
        this.creatorEmployeedIdLabel.Name = "creatorEmployeedIdLabel";
        this.creatorEmployeedIdLabel.Size = new Size(268, 49);
        this.creatorEmployeedIdLabel.TabIndex = 28;
        this.creatorEmployeedIdLabel.Text = "Creer employees :";
        this.creatorEmployeedIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(9, 68);
        this.statusLabel.Margin = new Padding(9, 10, 9, 10);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(268, 49);
        this.statusLabel.TabIndex = 20;
        this.statusLabel.Text = "Status :";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(286, 482);
        this.dateDeletedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(432, 39);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(287, 421);
        this.dateModifiedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(431, 39);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(288, 361);
        this.dateCreatedValue.Margin = new Padding(5, 6, 5, 6);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(432, 39);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(8, 479);
        this.dateModifiedLabel.Margin = new Padding(9, 10, 9, 10);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(268, 49);
        this.dateModifiedLabel.TabIndex = 8;
        this.dateModifiedLabel.Text = "Date de modication :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(8, 417);
        this.dateCreatedLabel.Margin = new Padding(9, 10, 9, 10);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(268, 49);
        this.dateCreatedLabel.TabIndex = 7;
        this.dateCreatedLabel.Text = "Date de creation :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ShippingDateLabel
        // 
        this.ShippingDateLabel.Location = new Point(9, 358);
        this.ShippingDateLabel.Margin = new Padding(9, 10, 9, 10);
        this.ShippingDateLabel.Name = "ShippingDateLabel";
        this.ShippingDateLabel.Size = new Size(268, 49);
        this.ShippingDateLabel.TabIndex = 6;
        this.ShippingDateLabel.Text = "Date d'expedition :";
        this.ShippingDateLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // sourceClientIdLabel
        // 
        this.sourceClientIdLabel.Location = new Point(9, 125);
        this.sourceClientIdLabel.Margin = new Padding(9, 10, 9, 10);
        this.sourceClientIdLabel.Name = "sourceClientIdLabel";
        this.sourceClientIdLabel.Size = new Size(268, 49);
        this.sourceClientIdLabel.TabIndex = 2;
        this.sourceClientIdLabel.Text = "Client :";
        this.sourceClientIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(291, 17);
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
        // sourceClientIdNameValue
        // 
        this.sourceClientIdNameValue.Location = new Point(290, 130);
        this.sourceClientIdNameValue.Margin = new Padding(5, 6, 5, 6);
        this.sourceClientIdNameValue.Name = "sourceClientIdNameValue";
        this.sourceClientIdNameValue.PlaceholderText = "Nom de client";
        this.sourceClientIdNameValue.Size = new Size(432, 39);
        this.sourceClientIdNameValue.TabIndex = 34;
        // 
        // creatorEmployeeIdNameValue
        // 
        this.creatorEmployeeIdNameValue.Location = new Point(289, 185);
        this.creatorEmployeeIdNameValue.Margin = new Padding(5, 6, 5, 6);
        this.creatorEmployeeIdNameValue.Name = "creatorEmployeeIdNameValue";
        this.creatorEmployeeIdNameValue.PlaceholderText = "Nom de l'employee";
        this.creatorEmployeeIdNameValue.Size = new Size(432, 39);
        this.creatorEmployeeIdNameValue.TabIndex = 35;
        // 
        // destinationAdressIdNameValue
        // 
        this.destinationAdressIdNameValue.Location = new Point(289, 240);
        this.destinationAdressIdNameValue.Margin = new Padding(5, 6, 5, 6);
        this.destinationAdressIdNameValue.Name = "destinationAdressIdNameValue";
        this.destinationAdressIdNameValue.PlaceholderText = "Adresse de destination";
        this.destinationAdressIdNameValue.Size = new Size(432, 39);
        this.destinationAdressIdNameValue.TabIndex = 36;
        // 
        // destinationAdressIdLabel
        // 
        this.destinationAdressIdLabel.Location = new Point(0, 235);
        this.destinationAdressIdLabel.Margin = new Padding(9, 10, 9, 10);
        this.destinationAdressIdLabel.Name = "destinationAdressIdLabel";
        this.destinationAdressIdLabel.Size = new Size(277, 49);
        this.destinationAdressIdLabel.TabIndex = 37;
        this.destinationAdressIdLabel.Text = "Adresse de destination :";
        this.destinationAdressIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ShipmentNameValue
        // 
        this.ShipmentNameValue.Location = new Point(287, 299);
        this.ShipmentNameValue.Margin = new Padding(5, 6, 5, 6);
        this.ShipmentNameValue.Name = "ShipmentNameValue";
        this.ShipmentNameValue.PlaceholderText = "Expedition";
        this.ShipmentNameValue.Size = new Size(432, 39);
        this.ShipmentNameValue.TabIndex = 40;
        // 
        // shipmentLabel
        // 
        this.shipmentLabel.Location = new Point(0, 289);
        this.shipmentLabel.Margin = new Padding(9, 10, 9, 10);
        this.shipmentLabel.Name = "shipmentLabel";
        this.shipmentLabel.Size = new Size(277, 49);
        this.shipmentLabel.TabIndex = 41;
        this.shipmentLabel.Text = "Expedition :";
        this.shipmentLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // fulfillerEmployeeListBox
        // 
        this.fulfillerEmployeeListBox.FormattingEnabled = true;
        this.fulfillerEmployeeListBox.ItemHeight = 32;
        this.fulfillerEmployeeListBox.Location = new Point(289, 911);
        this.fulfillerEmployeeListBox.Margin = new Padding(5, 6, 5, 6);
        this.fulfillerEmployeeListBox.Name = "fulfillerEmployeeListBox";
        this.fulfillerEmployeeListBox.SelectionMode = SelectionMode.MultiSimple;
        this.fulfillerEmployeeListBox.Size = new Size(430, 324);
        this.fulfillerEmployeeListBox.TabIndex = 42;
        // 
        // ShippingOrderView
        // 
        this.AutoScaleDimensions = new SizeF(13F, 32F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1586, 1553);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "ShippingOrderView";
        this.Text = "ShippingOrderView";
        this.bottomBarPanel.ResumeLayout(false);
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private Button buttonAnnuler;
    private Button buttonAction;
    private Button actButton;
    private Button canButton;
    private Button actionButton;
    private Button cancelButton;
    private Button btnAction;
    private Button btnCancel;
    private TableLayoutPanel centerBarTabLayPanel;
    private Panel centerPanel;
    private ComboBox statusComboBox;
    private Label fullfillerEmployeeLabel;
    private Label shippingOrderProductLabel;
    private ListBox shippingOrderProductListBox;
    private Label creatorEmployeedIdLabel;
    private Label statusLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label ShippingDateLabel;
    private Label sourceClientIdLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private TextBox sourceClientIdNameValue;
    private TextBox creatorEmployeeIdNameValue;
    private Label destinationAdressIdLabel;
    private TextBox destinationAdressIdNameValue;
    private TextBox ShipmentNameValue;
    private Label shipmentLabel;
    private ListBox fulfillerEmployeeListBox;
}