namespace _420DA3_A24_Projet.Presentation.Views;

partial class WarehouseView {
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
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.warehouseNameValue = new TextBox();
        this.warehouseNameLabel = new Label();
        this.warehouseClientsValues = new ListBox();
        this.warehouseClientsLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.addressValue = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.addressLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.topBarPanel = new Panel();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.button1 = new Button();
        this.button2 = new Button();
        this.warehouseEmployeesValue = new ListBox();
        this.warehouseEmployeesLabel = new Label();
        this.centerBarTabLayPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.bottomBarPanel.SuspendLayout();
        this.topBarPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // centerBarTabLayPanel
        // 
        this.centerBarTabLayPanel.ColumnCount = 3;
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 571F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerBarTabLayPanel.Dock = DockStyle.Fill;
        this.centerBarTabLayPanel.Location = new Point(0, 83);
        this.centerBarTabLayPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerBarTabLayPanel.Name = "centerBarTabLayPanel";
        this.centerBarTabLayPanel.RowCount = 1;
        this.centerBarTabLayPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerBarTabLayPanel.Size = new Size(1143, 769);
        this.centerBarTabLayPanel.TabIndex = 8;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.warehouseEmployeesValue);
        this.centerPanel.Controls.Add(this.warehouseEmployeesLabel);
        this.centerPanel.Controls.Add(this.warehouseNameValue);
        this.centerPanel.Controls.Add(this.warehouseNameLabel);
        this.centerPanel.Controls.Add(this.warehouseClientsValues);
        this.centerPanel.Controls.Add(this.warehouseClientsLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.addressValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.addressLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(290, 5);
        this.centerPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(563, 759);
        this.centerPanel.TabIndex = 0;
        // 
        // warehouseNameValue
        // 
        this.warehouseNameValue.Location = new Point(224, 58);
        this.warehouseNameValue.Margin = new Padding(4, 5, 4, 5);
        this.warehouseNameValue.Name = "warehouseNameValue";
        this.warehouseNameValue.PlaceholderText = "Nom de l'entrepôt";
        this.warehouseNameValue.Size = new Size(333, 31);
        this.warehouseNameValue.TabIndex = 21;
        // 
        // warehouseNameLabel
        // 
        this.warehouseNameLabel.Location = new Point(7, 58);
        this.warehouseNameLabel.Margin = new Padding(7, 8, 7, 8);
        this.warehouseNameLabel.Name = "warehouseNameLabel";
        this.warehouseNameLabel.Size = new Size(206, 38);
        this.warehouseNameLabel.TabIndex = 20;
        this.warehouseNameLabel.Text = "Nom de l'entrepôt :";
        this.warehouseNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseClientsValues
        // 
        this.warehouseClientsValues.FormattingEnabled = true;
        this.warehouseClientsValues.ItemHeight = 25;
        this.warehouseClientsValues.Location = new Point(227, 309);
        this.warehouseClientsValues.Margin = new Padding(4, 5, 4, 5);
        this.warehouseClientsValues.Name = "warehouseClientsValues";
        this.warehouseClientsValues.SelectionMode = SelectionMode.MultiSimple;
        this.warehouseClientsValues.Size = new Size(326, 204);
        this.warehouseClientsValues.TabIndex = 17;
        // 
        // warehouseClientsLabel
        // 
        this.warehouseClientsLabel.Location = new Point(7, 309);
        this.warehouseClientsLabel.Margin = new Padding(7, 8, 7, 8);
        this.warehouseClientsLabel.Name = "warehouseClientsLabel";
        this.warehouseClientsLabel.Size = new Size(206, 38);
        this.warehouseClientsLabel.TabIndex = 16;
        this.warehouseClientsLabel.Text = "Clients de l'entrepôt :";
        this.warehouseClientsLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(224, 259);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(333, 31);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(224, 208);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(333, 31);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(224, 157);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(333, 31);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // addressValue
        // 
        this.addressValue.Location = new Point(224, 103);
        this.addressValue.Margin = new Padding(4, 5, 4, 5);
        this.addressValue.Name = "addressValue";
        this.addressValue.PlaceholderText = "Adresse de l'entrepot ¿?";
        this.addressValue.Size = new Size(333, 31);
        this.addressValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(7, 259);
        this.dateDeletedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(206, 38);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(7, 208);
        this.dateModifiedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(206, 38);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(7, 157);
        this.dateCreatedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(206, 38);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addressLabel
        // 
        this.addressLabel.Location = new Point(7, 101);
        this.addressLabel.Margin = new Padding(7, 8, 7, 8);
        this.addressLabel.Name = "addressLabel";
        this.addressLabel.Size = new Size(206, 38);
        this.addressLabel.TabIndex = 2;
        this.addressLabel.Text = "Adresse de l'entrepôt :";
        this.addressLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(224, 12);
        this.idValue.Margin = new Padding(4, 5, 4, 5);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(334, 31);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(7, 9);
        this.idLabel.Margin = new Padding(7, 8, 7, 8);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(206, 38);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.button1);
        this.bottomBarPanel.Controls.Add(this.button2);
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 852);
        this.bottomBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1143, 83);
        this.bottomBarPanel.TabIndex = 7;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(1794, 3);
        this.actionButton.Margin = new Padding(4, 5, 4, 5);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(163, 38);
        this.actionButton.TabIndex = 3;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(1966, 3);
        this.cancelButton.Margin = new Padding(4, 5, 4, 5);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(107, 38);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(2733, -9);
        this.btnAction.Margin = new Padding(4, 5, 4, 5);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(163, 38);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(2905, -9);
        this.btnCancel.Margin = new Padding(4, 5, 4, 5);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(107, 38);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1143, 83);
        this.topBarPanel.TabIndex = 6;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(76, 15);
        this.openendModeValue.Margin = new Padding(4, 0, 4, 0);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(112, 25);
        this.openendModeValue.TabIndex = 1;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(4, 15);
        this.openedModeLabel.Margin = new Padding(4, 0, 4, 0);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(68, 25);
        this.openedModeLabel.TabIndex = 0;
        this.openedModeLabel.Text = "Mode :";
        // 
        // button1
        // 
        this.button1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.button1.Location = new Point(837, 21);
        this.button1.Margin = new Padding(4, 5, 4, 5);
        this.button1.Name = "button1";
        this.button1.Size = new Size(163, 38);
        this.button1.TabIndex = 5;
        this.button1.Text = "ACTION";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button2.Location = new Point(1009, 21);
        this.button2.Margin = new Padding(4, 5, 4, 5);
        this.button2.Name = "button2";
        this.button2.Size = new Size(107, 38);
        this.button2.TabIndex = 4;
        this.button2.Text = "Annuler";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // warehouseEmployeesValue
        // 
        this.warehouseEmployeesValue.FormattingEnabled = true;
        this.warehouseEmployeesValue.ItemHeight = 25;
        this.warehouseEmployeesValue.Location = new Point(227, 536);
        this.warehouseEmployeesValue.Margin = new Padding(4, 5, 4, 5);
        this.warehouseEmployeesValue.Name = "warehouseEmployeesValue";
        this.warehouseEmployeesValue.SelectionMode = SelectionMode.MultiSimple;
        this.warehouseEmployeesValue.Size = new Size(326, 204);
        this.warehouseEmployeesValue.TabIndex = 23;
        // 
        // warehouseEmployeesLabel
        // 
        this.warehouseEmployeesLabel.Location = new Point(3, 535);
        this.warehouseEmployeesLabel.Margin = new Padding(7, 8, 7, 8);
        this.warehouseEmployeesLabel.Name = "warehouseEmployeesLabel";
        this.warehouseEmployeesLabel.Size = new Size(219, 38);
        this.warehouseEmployeesLabel.TabIndex = 22;
        this.warehouseEmployeesLabel.Text = "Employees de l'entrepôt :";
        this.warehouseEmployeesLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // WarehouseView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1143, 935);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(705, 629);
        this.Name = "WarehouseView";
        this.Text = "Gestion d'un Entrepot";
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.bottomBarPanel.ResumeLayout(false);
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel centerBarTabLayPanel;
    private Panel centerPanel;
    private TextBox warehouseNameValue;
    private Label warehouseNameLabel;
    private TextBox contactLastNameValue;
    private Label contactLastNamelabel;
    private ListBox clientProductsValues;
    private Label warehouseClientsLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private ComboBox whEmpWarehouseValue;
    private TextBox telephoneValue;
    private TextBox emailValue;
    private TextBox addressValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label whEmpWarehouseLabel;
    private Label telephoneLabel;
    private Label emailLabel;
    private Label addressLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Panel bottomBarPanel;
    private Button actionButton;
    private Button cancelButton;
    private Button btnAction;
    private Button btnCancel;
    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button button1;
    private Button button2;
    private ListBox warehouseEmployeesValue;
    private Label warehouseEmployeesLabel;
}