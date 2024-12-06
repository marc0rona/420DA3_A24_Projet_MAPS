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
        this.bottomBarPanel = new Panel();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.topBarPanel = new Panel();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.button1 = new Button();
        this.button2 = new Button();
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
        this.centerBarTabLayPanel.Size = new Size(1159, 797);
        this.centerBarTabLayPanel.TabIndex = 5;
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
        this.centerPanel.Location = new Point(298, 5);
        this.centerPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(563, 787);
        this.centerPanel.TabIndex = 0;
        // 
        // userRolesValues
        // 
        this.userRolesValues.FormattingEnabled = true;
        this.userRolesValues.ItemHeight = 25;
        this.userRolesValues.Location = new Point(224, 493);
        this.userRolesValues.Margin = new Padding(4, 5, 4, 5);
        this.userRolesValues.Name = "userRolesValues";
        this.userRolesValues.SelectionMode = SelectionMode.MultiSimple;
        this.userRolesValues.Size = new Size(333, 254);
        this.userRolesValues.TabIndex = 17;
        // 
        // userRolesLabel
        // 
        this.userRolesLabel.Location = new Point(7, 493);
        this.userRolesLabel.Margin = new Padding(7, 8, 7, 8);
        this.userRolesLabel.Name = "userRolesLabel";
        this.userRolesLabel.Size = new Size(206, 38);
        this.userRolesLabel.TabIndex = 16;
        this.userRolesLabel.Text = "Rôles de l'utilisateur :";
        this.userRolesLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(224, 410);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(333, 31);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(224, 355);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(333, 31);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(224, 300);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(333, 31);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // whEmpWarehouseValue
        // 
        this.whEmpWarehouseValue.FormattingEnabled = true;
        this.whEmpWarehouseValue.Location = new Point(224, 247);
        this.whEmpWarehouseValue.Margin = new Padding(4, 5, 4, 5);
        this.whEmpWarehouseValue.Name = "whEmpWarehouseValue";
        this.whEmpWarehouseValue.Size = new Size(333, 33);
        this.whEmpWarehouseValue.TabIndex = 12;
        // 
        // passwordHashValue
        // 
        this.passwordHashValue.Enabled = false;
        this.passwordHashValue.Location = new Point(224, 192);
        this.passwordHashValue.Margin = new Padding(4, 5, 4, 5);
        this.passwordHashValue.Name = "passwordHashValue";
        this.passwordHashValue.PlaceholderText = "Hash du mot de passe";
        this.passwordHashValue.Size = new Size(333, 31);
        this.passwordHashValue.TabIndex = 11;
        // 
        // passwordValue
        // 
        this.passwordValue.Location = new Point(224, 137);
        this.passwordValue.Margin = new Padding(4, 5, 4, 5);
        this.passwordValue.Name = "passwordValue";
        this.passwordValue.PlaceholderText = "Mot de passe";
        this.passwordValue.Size = new Size(333, 31);
        this.passwordValue.TabIndex = 10;
        this.passwordValue.UseSystemPasswordChar = true;
        // 
        // usernameValue
        // 
        this.usernameValue.Location = new Point(224, 82);
        this.usernameValue.Margin = new Padding(4, 5, 4, 5);
        this.usernameValue.Name = "usernameValue";
        this.usernameValue.PlaceholderText = "Nom d'utilisateur";
        this.usernameValue.Size = new Size(333, 31);
        this.usernameValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(7, 410);
        this.dateDeletedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(206, 38);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(7, 355);
        this.dateModifiedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(206, 38);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(7, 300);
        this.dateCreatedLabel.Margin = new Padding(7, 8, 7, 8);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(206, 38);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // whEmpWarehouseLabel
        // 
        this.whEmpWarehouseLabel.Location = new Point(7, 245);
        this.whEmpWarehouseLabel.Margin = new Padding(7, 8, 7, 8);
        this.whEmpWarehouseLabel.Name = "whEmpWarehouseLabel";
        this.whEmpWarehouseLabel.Size = new Size(206, 38);
        this.whEmpWarehouseLabel.TabIndex = 5;
        this.whEmpWarehouseLabel.Text = "Entrepôt :";
        this.whEmpWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordHashLabel
        // 
        this.passwordHashLabel.Location = new Point(7, 190);
        this.passwordHashLabel.Margin = new Padding(7, 8, 7, 8);
        this.passwordHashLabel.Name = "passwordHashLabel";
        this.passwordHashLabel.Size = new Size(206, 38);
        this.passwordHashLabel.TabIndex = 4;
        this.passwordHashLabel.Text = "Mot de passe encrypté :";
        this.passwordHashLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordLabel
        // 
        this.passwordLabel.Location = new Point(7, 135);
        this.passwordLabel.Margin = new Padding(7, 8, 7, 8);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(206, 38);
        this.passwordLabel.TabIndex = 3;
        this.passwordLabel.Text = "Mot de passe :";
        this.passwordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // usernameLabel
        // 
        this.usernameLabel.Location = new Point(7, 80);
        this.usernameLabel.Margin = new Padding(7, 8, 7, 8);
        this.usernameLabel.Name = "usernameLabel";
        this.usernameLabel.Size = new Size(206, 38);
        this.usernameLabel.TabIndex = 2;
        this.usernameLabel.Text = "Nom d'utilisateur :";
        this.usernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(224, 28);
        this.idValue.Margin = new Padding(4, 5, 4, 5);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(334, 31);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(7, 25);
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
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 880);
        this.bottomBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1159, 83);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(1806, 8);
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
        this.btnCancel.Location = new Point(1978, 8);
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
        this.topBarPanel.Size = new Size(1159, 83);
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
        // button1
        // 
        this.button1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.button1.Location = new Point(440, 22);
        this.button1.Margin = new Padding(4, 5, 4, 5);
        this.button1.Name = "button1";
        this.button1.Size = new Size(163, 38);
        this.button1.TabIndex = 3;
        this.button1.Text = "ACTION";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button2.Location = new Point(612, 22);
        this.button2.Margin = new Padding(4, 5, 4, 5);
        this.button2.Name = "button2";
        this.button2.Size = new Size(107, 38);
        this.button2.TabIndex = 2;
        this.button2.Text = "Annuler";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // ClientView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1159, 963);
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
    private ListBox userRolesValues;
    private Label userRolesLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private ComboBox whEmpWarehouseValue;
    private TextBox passwordHashValue;
    private TextBox passwordValue;
    private TextBox usernameValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label whEmpWarehouseLabel;
    private Label passwordHashLabel;
    private Label passwordLabel;
    private Label usernameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Panel bottomBarPanel;
    private Button btnAction;
    private Button btnCancel;
    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button button1;
    private Button button2;
}