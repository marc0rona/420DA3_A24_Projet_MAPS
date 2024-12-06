namespace _420DA3_A24_Projet.Presentation.Views;

partial class ClientView {
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
        this.clientProductsValues = new ListBox();
        this.clientProductsLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.whEmpWarehouseValue = new ComboBox();
        this.telephoneValue = new TextBox();
        this.emailValue = new TextBox();
        this.contactFirstNameValue = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.whEmpWarehouseLabel = new Label();
        this.telephoneLabel = new Label();
        this.emailLabel = new Label();
        this.contactFirstNameLabel = new Label();
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
        this.contactLastNamelabel = new Label();
        this.contactLastNameValue = new TextBox();
        this.clientNameLabel = new Label();
        this.clientNameValue = new TextBox();
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
        this.centerBarTabLayPanel.TabIndex = 5;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.clientNameValue);
        this.centerPanel.Controls.Add(this.clientNameLabel);
        this.centerPanel.Controls.Add(this.contactLastNameValue);
        this.centerPanel.Controls.Add(this.contactLastNamelabel);
        this.centerPanel.Controls.Add(this.clientProductsValues);
        this.centerPanel.Controls.Add(this.clientProductsLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.whEmpWarehouseValue);
        this.centerPanel.Controls.Add(this.telephoneValue);
        this.centerPanel.Controls.Add(this.emailValue);
        this.centerPanel.Controls.Add(this.contactFirstNameValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.whEmpWarehouseLabel);
        this.centerPanel.Controls.Add(this.telephoneLabel);
        this.centerPanel.Controls.Add(this.emailLabel);
        this.centerPanel.Controls.Add(this.contactFirstNameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(290, 5);
        this.centerPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(563, 759);
        this.centerPanel.TabIndex = 0;
        // 
        // clientProductsValues
        // 
        this.clientProductsValues.FormattingEnabled = true;
        this.clientProductsValues.ItemHeight = 25;
        this.clientProductsValues.Location = new Point(224, 493);
        this.clientProductsValues.Margin = new Padding(4, 5, 4, 5);
        this.clientProductsValues.Name = "clientProductsValues";
        this.clientProductsValues.SelectionMode = SelectionMode.MultiSimple;
        this.clientProductsValues.Size = new Size(333, 254);
        this.clientProductsValues.TabIndex = 17;
        // 
        // clientProductsLabel
        // 
        this.clientProductsLabel.Location = new Point(7, 493);
        this.clientProductsLabel.Margin = new Padding(7, 8, 7, 8);
        this.clientProductsLabel.Name = "clientProductsLabel";
        this.clientProductsLabel.Size = new Size(206, 38);
        this.clientProductsLabel.TabIndex = 16;
        this.clientProductsLabel.Text = "Products du client :";
        this.clientProductsLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(224, 450);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(333, 31);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(224, 395);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(333, 31);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(224, 340);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(333, 31);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // whEmpWarehouseValue
        // 
        this.whEmpWarehouseValue.FormattingEnabled = true;
        this.whEmpWarehouseValue.Location = new Point(224, 287);
        this.whEmpWarehouseValue.Margin = new Padding(4, 5, 4, 5);
        this.whEmpWarehouseValue.Name = "whEmpWarehouseValue";
        this.whEmpWarehouseValue.Size = new Size(333, 33);
        this.whEmpWarehouseValue.TabIndex = 12;
        // 
        // telephoneValue
        // 
        this.telephoneValue.Enabled = false;
        this.telephoneValue.Location = new Point(224, 240);
        this.telephoneValue.Margin = new Padding(4, 5, 4, 5);
        this.telephoneValue.Name = "telephoneValue";
        this.telephoneValue.PlaceholderText = "Telephone du contact";
        this.telephoneValue.Size = new Size(333, 31);
        this.telephoneValue.TabIndex = 11;
        // 
        // emailValue
        // 
        this.emailValue.Location = new Point(224, 196);
        this.emailValue.Margin = new Padding(4, 5, 4, 5);
        this.emailValue.Name = "emailValue";
        this.emailValue.PlaceholderText = "Email du Contact";
        this.emailValue.Size = new Size(333, 31);
        this.emailValue.TabIndex = 10;
        this.emailValue.UseSystemPasswordChar = true;
        // 
        // contactFirstNameValue
        // 
        this.contactFirstNameValue.Location = new Point(224, 103);
        this.contactFirstNameValue.Margin = new Padding(4, 5, 4, 5);
        this.contactFirstNameValue.Name = "contactFirstNameValue";
        this.contactFirstNameValue.PlaceholderText = "Prenom du contact";
        this.contactFirstNameValue.Size = new Size(333, 31);
        this.contactFirstNameValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(7, 450);
        this.dateDeletedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(206, 38);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(7, 395);
        this.dateModifiedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(206, 38);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(7, 340);
        this.dateCreatedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(206, 38);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // whEmpWarehouseLabel
        // 
        this.whEmpWarehouseLabel.Location = new Point(7, 285);
        this.whEmpWarehouseLabel.Margin = new Padding(7, 8, 7, 8);
        this.whEmpWarehouseLabel.Name = "whEmpWarehouseLabel";
        this.whEmpWarehouseLabel.Size = new Size(206, 38);
        this.whEmpWarehouseLabel.TabIndex = 5;
        this.whEmpWarehouseLabel.Text = "Entrepôt :";
        this.whEmpWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // telephoneLabel
        // 
        this.telephoneLabel.Location = new Point(7, 238);
        this.telephoneLabel.Margin = new Padding(7, 8, 7, 8);
        this.telephoneLabel.Name = "telephoneLabel";
        this.telephoneLabel.Size = new Size(206, 38);
        this.telephoneLabel.TabIndex = 4;
        this.telephoneLabel.Text = "Telephone du contact :";
        this.telephoneLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // emailLabel
        // 
        this.emailLabel.Location = new Point(7, 194);
        this.emailLabel.Margin = new Padding(7, 8, 7, 8);
        this.emailLabel.Name = "emailLabel";
        this.emailLabel.Size = new Size(206, 38);
        this.emailLabel.TabIndex = 3;
        this.emailLabel.Text = "Email du Contact :";
        this.emailLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactFirstNameLabel
        // 
        this.contactFirstNameLabel.Location = new Point(7, 101);
        this.contactFirstNameLabel.Margin = new Padding(7, 8, 7, 8);
        this.contactFirstNameLabel.Name = "contactFirstNameLabel";
        this.contactFirstNameLabel.Size = new Size(206, 38);
        this.contactFirstNameLabel.TabIndex = 2;
        this.contactFirstNameLabel.Text = "Prenom du Contact :";
        this.contactFirstNameLabel.TextAlign = ContentAlignment.MiddleRight;
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
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 852);
        this.bottomBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1143, 83);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(851, 20);
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
        this.cancelButton.Location = new Point(1023, 20);
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
        this.btnAction.Location = new Point(1790, 8);
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
        this.btnCancel.Location = new Point(1962, 8);
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
        this.topBarPanel.TabIndex = 3;
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
        // contactLastNamelabel
        // 
        this.contactLastNamelabel.Location = new Point(7, 145);
        this.contactLastNamelabel.Margin = new Padding(7, 8, 7, 8);
        this.contactLastNamelabel.Name = "contactLastNamelabel";
        this.contactLastNamelabel.Size = new Size(206, 38);
        this.contactLastNamelabel.TabIndex = 18;
        this.contactLastNamelabel.Text = "Nom du Contact :";
        this.contactLastNamelabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactLastNameValue
        // 
        this.contactLastNameValue.Location = new Point(226, 152);
        this.contactLastNameValue.Margin = new Padding(4, 5, 4, 5);
        this.contactLastNameValue.Name = "contactLastNameValue";
        this.contactLastNameValue.PlaceholderText = "Nom du contact";
        this.contactLastNameValue.Size = new Size(333, 31);
        this.contactLastNameValue.TabIndex = 19;
        // 
        // clientNameLabel
        // 
        this.clientNameLabel.Location = new Point(7, 58);
        this.clientNameLabel.Margin = new Padding(7, 8, 7, 8);
        this.clientNameLabel.Name = "clientNameLabel";
        this.clientNameLabel.Size = new Size(206, 38);
        this.clientNameLabel.TabIndex = 20;
        this.clientNameLabel.Text = "Nom du Client :";
        this.clientNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // clientNameValue
        // 
        this.clientNameValue.Location = new Point(224, 58);
        this.clientNameValue.Margin = new Padding(4, 5, 4, 5);
        this.clientNameValue.Name = "clientNameValue";
        this.clientNameValue.PlaceholderText = "Nom du client";
        this.clientNameValue.Size = new Size(333, 31);
        this.clientNameValue.TabIndex = 21;
        // 
        // ClientView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1143, 935);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(705, 629);
        this.Name = "ClientView";
        this.Text = "Gestion d'un Client";
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
    private ListBox clientProductsValues;
    private Label clientProductsLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private ComboBox whEmpWarehouseValue;
    private TextBox telephoneValue;
    private TextBox emailValue;
    private TextBox contactFirstNameValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label whEmpWarehouseLabel;
    private Label telephoneLabel;
    private Label emailLabel;
    private Label contactFirstNameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Panel bottomBarPanel;
    private Button btnAction;
    private Button btnCancel;
    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button actionButton;
    private Button cancelButton;
    private TextBox contactLastNameValue;
    private Label contactLastNamelabel;
    private TextBox clientNameValue;
    private Label clientNameLabel;
}