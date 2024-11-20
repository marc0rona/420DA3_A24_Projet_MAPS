namespace _420DA3_A24_Projet.Presentation.Views;

partial class UserView {
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
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.userRolesValues = new ListBox();
        this.userRolesLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.whEmpWarehouseValue = new ComboBox();
        this.passwordHashValue = new TextBox();
        this.passwordValue = new TextBox();
        this.usernameValue = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.whEmpWarehouseLabel = new Label();
        this.passwordHashLabel = new Label();
        this.passwordLabel = new Label();
        this.usernameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
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
        this.topBarPanel.TabIndex = 0;
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
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 511);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(593, 15);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(114, 23);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.BtnAction_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(713, 15);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += this.BtnCancel_Click;
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
        this.centerBarTabLayPanel.Size = new Size(800, 461);
        this.centerBarTabLayPanel.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.userRolesValues);
        this.centerPanel.Controls.Add(this.userRolesLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.whEmpWarehouseValue);
        this.centerPanel.Controls.Add(this.passwordHashValue);
        this.centerPanel.Controls.Add(this.passwordValue);
        this.centerPanel.Controls.Add(this.usernameValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.whEmpWarehouseLabel);
        this.centerPanel.Controls.Add(this.passwordHashLabel);
        this.centerPanel.Controls.Add(this.passwordLabel);
        this.centerPanel.Controls.Add(this.usernameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(203, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(394, 455);
        this.centerPanel.TabIndex = 0;
        // 
        // userRolesValues
        // 
        this.userRolesValues.FormattingEnabled = true;
        this.userRolesValues.ItemHeight = 15;
        this.userRolesValues.Location = new Point(157, 296);
        this.userRolesValues.Name = "userRolesValues";
        this.userRolesValues.SelectionMode = SelectionMode.MultiSimple;
        this.userRolesValues.Size = new Size(234, 154);
        this.userRolesValues.TabIndex = 17;
        // 
        // userRolesLabel
        // 
        this.userRolesLabel.Location = new Point(5, 296);
        this.userRolesLabel.Margin = new Padding(5);
        this.userRolesLabel.Name = "userRolesLabel";
        this.userRolesLabel.Size = new Size(144, 23);
        this.userRolesLabel.TabIndex = 16;
        this.userRolesLabel.Text = "Rôles de l'utilisateur :";
        this.userRolesLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(157, 246);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(234, 23);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(157, 213);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(234, 23);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(157, 180);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(234, 23);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // whEmpWarehouseValue
        // 
        this.whEmpWarehouseValue.FormattingEnabled = true;
        this.whEmpWarehouseValue.Location = new Point(157, 148);
        this.whEmpWarehouseValue.Name = "whEmpWarehouseValue";
        this.whEmpWarehouseValue.Size = new Size(234, 23);
        this.whEmpWarehouseValue.TabIndex = 12;
        // 
        // passwordHashValue
        // 
        this.passwordHashValue.Enabled = false;
        this.passwordHashValue.Location = new Point(157, 115);
        this.passwordHashValue.Name = "passwordHashValue";
        this.passwordHashValue.PlaceholderText = "Hash du mot de passe";
        this.passwordHashValue.Size = new Size(234, 23);
        this.passwordHashValue.TabIndex = 11;
        // 
        // passwordValue
        // 
        this.passwordValue.Location = new Point(157, 82);
        this.passwordValue.Name = "passwordValue";
        this.passwordValue.PlaceholderText = "Mot de passe";
        this.passwordValue.Size = new Size(234, 23);
        this.passwordValue.TabIndex = 10;
        this.passwordValue.UseSystemPasswordChar = true;
        // 
        // usernameValue
        // 
        this.usernameValue.Location = new Point(157, 49);
        this.usernameValue.Name = "usernameValue";
        this.usernameValue.PlaceholderText = "Nom d'utilisateur";
        this.usernameValue.Size = new Size(234, 23);
        this.usernameValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 246);
        this.dateDeletedLabel.Margin = new Padding(5);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(144, 23);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 213);
        this.dateModifiedLabel.Margin = new Padding(5);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(144, 23);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 180);
        this.dateCreatedLabel.Margin = new Padding(5);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(144, 23);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // whEmpWarehouseLabel
        // 
        this.whEmpWarehouseLabel.Location = new Point(5, 147);
        this.whEmpWarehouseLabel.Margin = new Padding(5);
        this.whEmpWarehouseLabel.Name = "whEmpWarehouseLabel";
        this.whEmpWarehouseLabel.Size = new Size(144, 23);
        this.whEmpWarehouseLabel.TabIndex = 5;
        this.whEmpWarehouseLabel.Text = "Entrepôt :";
        this.whEmpWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordHashLabel
        // 
        this.passwordHashLabel.Location = new Point(5, 114);
        this.passwordHashLabel.Margin = new Padding(5);
        this.passwordHashLabel.Name = "passwordHashLabel";
        this.passwordHashLabel.Size = new Size(144, 23);
        this.passwordHashLabel.TabIndex = 4;
        this.passwordHashLabel.Text = "Mot de passe encrypté :";
        this.passwordHashLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordLabel
        // 
        this.passwordLabel.Location = new Point(5, 81);
        this.passwordLabel.Margin = new Padding(5);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(144, 23);
        this.passwordLabel.TabIndex = 3;
        this.passwordLabel.Text = "Mot de passe :";
        this.passwordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // usernameLabel
        // 
        this.usernameLabel.Location = new Point(5, 48);
        this.usernameLabel.Margin = new Padding(5);
        this.usernameLabel.Name = "usernameLabel";
        this.usernameLabel.Size = new Size(144, 23);
        this.usernameLabel.TabIndex = 2;
        this.usernameLabel.Text = "Nom d'utilisateur :";
        this.usernameLabel.TextAlign = ContentAlignment.MiddleRight;
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
        // UserView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 561);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(500, 400);
        this.Name = "UserView";
        this.Text = "Gestion d'un utilisateur";
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
    private Panel bottomBarPanel;
    private TableLayoutPanel centerBarTabLayPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button btnAction;
    private Button btnCancel;
    private Panel centerPanel;
    private Label usernameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Label passwordHashLabel;
    private Label passwordLabel;
    private Label whEmpWarehouseLabel;
    private TextBox passwordHashValue;
    private TextBox passwordValue;
    private TextBox usernameValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private ComboBox whEmpWarehouseValue;
    private ListBox userRolesValues;
    private Label userRolesLabel;
}