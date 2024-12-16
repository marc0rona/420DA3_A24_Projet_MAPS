namespace _420DA3_A24_Projet.Presentation.Views;

partial class AddressView {
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
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.button2 = new Button();
        this.button1 = new Button();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.civicNumberValue = new TextBox();
        this.adresseeValue = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.civicNumberLabel = new Label();
        this.addresseeLabel = new Label();
        this.addressTypeLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.stateValue = new TextBox();
        this.cityValue = new TextBox();
        this.streetValue = new TextBox();
        this.stateLabel = new Label();
        this.cityLabel = new Label();
        this.streetLabel = new Label();
        this.postalCodeValue = new TextBox();
        this.countryValue = new TextBox();
        this.postalCodeLabel = new Label();
        this.countryLabel = new Label();
        this.addressTypeValue = new ComboBox();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerBarTabLayPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 50);
        this.topBarPanel.TabIndex = 1;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(53, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(72, 15);
        this.openendModeValue.TabIndex = 1;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(3, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(44, 15);
        this.openedModeLabel.TabIndex = 0;
        this.openedModeLabel.Text = "Mode :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.button2);
        this.bottomBarPanel.Controls.Add(this.button1);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 479);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 50);
        this.bottomBarPanel.TabIndex = 2;
        // 
        // button2
        // 
        this.button2.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button2.Location = new Point(722, 15);
        this.button2.Name = "button2";
        this.button2.Size = new Size(75, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "Annuler";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.button1.Location = new Point(602, 15);
        this.button1.Name = "button1";
        this.button1.Size = new Size(114, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "ACTION";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(1193, -35);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(114, 23);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1313, -35);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // centerBarTabLayPanel
        // 
        this.centerBarTabLayPanel.ColumnCount = 3;
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerBarTabLayPanel.Dock = DockStyle.Fill;
        this.centerBarTabLayPanel.Location = new Point(0, 50);
        this.centerBarTabLayPanel.Name = "centerBarTabLayPanel";
        this.centerBarTabLayPanel.RowCount = 1;
        this.centerBarTabLayPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerBarTabLayPanel.Size = new Size(800, 429);
        this.centerBarTabLayPanel.TabIndex = 3;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.addressTypeValue);
        this.centerPanel.Controls.Add(this.postalCodeValue);
        this.centerPanel.Controls.Add(this.countryValue);
        this.centerPanel.Controls.Add(this.postalCodeLabel);
        this.centerPanel.Controls.Add(this.countryLabel);
        this.centerPanel.Controls.Add(this.stateValue);
        this.centerPanel.Controls.Add(this.cityValue);
        this.centerPanel.Controls.Add(this.streetValue);
        this.centerPanel.Controls.Add(this.stateLabel);
        this.centerPanel.Controls.Add(this.cityLabel);
        this.centerPanel.Controls.Add(this.streetLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.civicNumberValue);
        this.centerPanel.Controls.Add(this.adresseeValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.civicNumberLabel);
        this.centerPanel.Controls.Add(this.addresseeLabel);
        this.centerPanel.Controls.Add(this.addressTypeLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(203, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(394, 423);
        this.centerPanel.TabIndex = 0;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(157, 375);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(234, 23);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(157, 342);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(234, 23);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(157, 309);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(234, 23);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // civicNumberValue
        // 
        this.civicNumberValue.Enabled = false;
        this.civicNumberValue.Location = new Point(157, 115);
        this.civicNumberValue.Name = "civicNumberValue";
        this.civicNumberValue.PlaceholderText = "Entrez un numéro civique";
        this.civicNumberValue.Size = new Size(234, 23);
        this.civicNumberValue.TabIndex = 11;
        // 
        // adresseeValue
        // 
        this.adresseeValue.Location = new Point(157, 82);
        this.adresseeValue.Name = "adresseeValue";
        this.adresseeValue.PlaceholderText = "Entrez un destinataire";
        this.adresseeValue.Size = new Size(234, 23);
        this.adresseeValue.TabIndex = 10;
        this.adresseeValue.UseSystemPasswordChar = true;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 375);
        this.dateDeletedLabel.Margin = new Padding(5);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(144, 23);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 342);
        this.dateModifiedLabel.Margin = new Padding(5);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(144, 23);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 309);
        this.dateCreatedLabel.Margin = new Padding(5);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(144, 23);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // civicNumberLabel
        // 
        this.civicNumberLabel.Location = new Point(5, 114);
        this.civicNumberLabel.Margin = new Padding(5);
        this.civicNumberLabel.Name = "civicNumberLabel";
        this.civicNumberLabel.Size = new Size(144, 23);
        this.civicNumberLabel.TabIndex = 4;
        this.civicNumberLabel.Text = "Numéro civique";
        this.civicNumberLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addresseeLabel
        // 
        this.addresseeLabel.Location = new Point(5, 81);
        this.addresseeLabel.Margin = new Padding(5);
        this.addresseeLabel.Name = "addresseeLabel";
        this.addresseeLabel.Size = new Size(144, 23);
        this.addresseeLabel.TabIndex = 3;
        this.addresseeLabel.Text = "Destinataire";
        this.addresseeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addressTypeLabel
        // 
        this.addressTypeLabel.Location = new Point(5, 48);
        this.addressTypeLabel.Margin = new Padding(5);
        this.addressTypeLabel.Name = "addressTypeLabel";
        this.addressTypeLabel.Size = new Size(144, 23);
        this.addressTypeLabel.TabIndex = 2;
        this.addressTypeLabel.Text = "Type d'adresse";
        this.addressTypeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(157, 17);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(234, 23);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(5, 15);
        this.idLabel.Margin = new Padding(5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(144, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // stateValue
        // 
        this.stateValue.Enabled = false;
        this.stateValue.Location = new Point(157, 214);
        this.stateValue.Name = "stateValue";
        this.stateValue.PlaceholderText = "Entrez un état/province/territoire";
        this.stateValue.Size = new Size(234, 23);
        this.stateValue.TabIndex = 23;
        // 
        // cityValue
        // 
        this.cityValue.Location = new Point(157, 181);
        this.cityValue.Name = "cityValue";
        this.cityValue.PlaceholderText = "Entrez une ville";
        this.cityValue.Size = new Size(234, 23);
        this.cityValue.TabIndex = 22;
        this.cityValue.UseSystemPasswordChar = true;
        // 
        // streetValue
        // 
        this.streetValue.Location = new Point(157, 148);
        this.streetValue.Name = "streetValue";
        this.streetValue.PlaceholderText = "Entrez une rue";
        this.streetValue.Size = new Size(234, 23);
        this.streetValue.TabIndex = 21;
        // 
        // stateLabel
        // 
        this.stateLabel.Location = new Point(5, 213);
        this.stateLabel.Margin = new Padding(5);
        this.stateLabel.Name = "stateLabel";
        this.stateLabel.Size = new Size(144, 23);
        this.stateLabel.TabIndex = 20;
        this.stateLabel.Text = "État/Province";
        this.stateLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cityLabel
        // 
        this.cityLabel.Location = new Point(5, 180);
        this.cityLabel.Margin = new Padding(5);
        this.cityLabel.Name = "cityLabel";
        this.cityLabel.Size = new Size(144, 23);
        this.cityLabel.TabIndex = 19;
        this.cityLabel.Text = "Ville";
        this.cityLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // streetLabel
        // 
        this.streetLabel.Location = new Point(5, 147);
        this.streetLabel.Margin = new Padding(5);
        this.streetLabel.Name = "streetLabel";
        this.streetLabel.Size = new Size(144, 23);
        this.streetLabel.TabIndex = 18;
        this.streetLabel.Text = "Rue";
        this.streetLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // postalCodeValue
        // 
        this.postalCodeValue.Enabled = false;
        this.postalCodeValue.Location = new Point(157, 277);
        this.postalCodeValue.Name = "postalCodeValue";
        this.postalCodeValue.PlaceholderText = "Entrez un code postal";
        this.postalCodeValue.Size = new Size(234, 23);
        this.postalCodeValue.TabIndex = 27;
        // 
        // countryValue
        // 
        this.countryValue.Location = new Point(157, 244);
        this.countryValue.Name = "countryValue";
        this.countryValue.PlaceholderText = "Entrez un pays";
        this.countryValue.Size = new Size(234, 23);
        this.countryValue.TabIndex = 26;
        this.countryValue.UseSystemPasswordChar = true;
        // 
        // postalCodeLabel
        // 
        this.postalCodeLabel.Location = new Point(5, 276);
        this.postalCodeLabel.Margin = new Padding(5);
        this.postalCodeLabel.Name = "postalCodeLabel";
        this.postalCodeLabel.Size = new Size(144, 23);
        this.postalCodeLabel.TabIndex = 25;
        this.postalCodeLabel.Text = "Code Postal";
        this.postalCodeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // countryLabel
        // 
        this.countryLabel.Location = new Point(5, 243);
        this.countryLabel.Margin = new Padding(5);
        this.countryLabel.Name = "countryLabel";
        this.countryLabel.Size = new Size(144, 23);
        this.countryLabel.TabIndex = 24;
        this.countryLabel.Text = "Pays";
        this.countryLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addressTypeValue
        // 
        this.addressTypeValue.FormattingEnabled = true;
        this.addressTypeValue.Location = new Point(157, 53);
        this.addressTypeValue.Name = "addressTypeValue";
        this.addressTypeValue.Size = new Size(234, 23);
        this.addressTypeValue.TabIndex = 28;
        // 
        // AddressView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 529);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(500, 400);
        this.Name = "AddressView";
        this.Text = "Gestion d'une adresse";
        this.Load += this.AddressView_Load;
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Panel bottomBarPanel;
    private Button btnAction;
    private Button btnCancel;
    private Button button1;
    private Button button2;
    private TableLayoutPanel centerBarTabLayPanel;
    private Panel centerPanel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private TextBox civicNumberValue;
    private TextBox adresseeValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label civicNumberLabel;
    private Label addresseeLabel;
    private Label addressTypeLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private TextBox postalCodeValue;
    private TextBox countryValue;
    private Label postalCodeLabel;
    private Label countryLabel;
    private TextBox stateValue;
    private TextBox cityValue;
    private TextBox streetValue;
    private Label stateLabel;
    private Label cityLabel;
    private Label streetLabel;
    private ComboBox addressTypeValue;
}