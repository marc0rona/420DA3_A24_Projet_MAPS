namespace _420DA3_A24_Projet.Presentation;

partial class LoginWindow {
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
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.buttonsCenterPanel = new Panel();
        this.connectButton = new Button();
        this.buttonQuit = new Button();
        this.passwordTextBox = new TextBox();
        this.spacingPanel1 = new Panel();
        this.usernameTextBox = new TextBox();
        this.headerLabel = new Label();
        this.tableLayoutPanel1.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.buttonsCenterPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.centerPanel, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.headerLabel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Size = new Size(284, 261);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.tableLayoutPanel2);
        this.centerPanel.Controls.Add(this.passwordTextBox);
        this.centerPanel.Controls.Add(this.spacingPanel1);
        this.centerPanel.Controls.Add(this.usernameTextBox);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(45, 58);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(194, 144);
        this.centerPanel.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 3;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.Controls.Add(this.buttonsCenterPanel, 1, 0);
        this.tableLayoutPanel2.Location = new Point(3, 67);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new Size(188, 74);
        this.tableLayoutPanel2.TabIndex = 3;
        // 
        // buttonsCenterPanel
        // 
        this.buttonsCenterPanel.Controls.Add(this.connectButton);
        this.buttonsCenterPanel.Controls.Add(this.buttonQuit);
        this.buttonsCenterPanel.Dock = DockStyle.Fill;
        this.buttonsCenterPanel.Location = new Point(32, 3);
        this.buttonsCenterPanel.Name = "buttonsCenterPanel";
        this.buttonsCenterPanel.Size = new Size(124, 68);
        this.buttonsCenterPanel.TabIndex = 0;
        // 
        // connectButton
        // 
        this.connectButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.connectButton.Location = new Point(3, 3);
        this.connectButton.Name = "connectButton";
        this.connectButton.Size = new Size(118, 33);
        this.connectButton.TabIndex = 1;
        this.connectButton.Text = "Connexion!";
        this.connectButton.UseVisualStyleBackColor = true;
        this.connectButton.Click += this.ConnectButton_Click;
        // 
        // buttonQuit
        // 
        this.buttonQuit.Location = new Point(3, 42);
        this.buttonQuit.Name = "buttonQuit";
        this.buttonQuit.Size = new Size(118, 23);
        this.buttonQuit.TabIndex = 0;
        this.buttonQuit.Text = "Quitter";
        this.buttonQuit.UseVisualStyleBackColor = true;
        this.buttonQuit.Click += this.ButtonQuit_Click;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Dock = DockStyle.Top;
        this.passwordTextBox.Location = new Point(0, 38);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.PlaceholderText = "Mot de passe";
        this.passwordTextBox.Size = new Size(194, 23);
        this.passwordTextBox.TabIndex = 2;
        this.passwordTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // spacingPanel1
        // 
        this.spacingPanel1.Dock = DockStyle.Top;
        this.spacingPanel1.Location = new Point(0, 23);
        this.spacingPanel1.Name = "spacingPanel1";
        this.spacingPanel1.Size = new Size(194, 15);
        this.spacingPanel1.TabIndex = 1;
        // 
        // usernameTextBox
        // 
        this.usernameTextBox.Dock = DockStyle.Top;
        this.usernameTextBox.Location = new Point(0, 0);
        this.usernameTextBox.Name = "usernameTextBox";
        this.usernameTextBox.PlaceholderText = "Nom d'utilisateur";
        this.usernameTextBox.Size = new Size(194, 23);
        this.usernameTextBox.TabIndex = 0;
        this.usernameTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // headerLabel
        // 
        this.headerLabel.Dock = DockStyle.Fill;
        this.headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.headerLabel.Location = new Point(45, 0);
        this.headerLabel.Name = "headerLabel";
        this.headerLabel.Size = new Size(194, 55);
        this.headerLabel.TabIndex = 1;
        this.headerLabel.Text = "Connexion utilisateur";
        this.headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 261);
        this.Controls.Add(this.tableLayoutPanel1);
        this.MaximumSize = new Size(300, 300);
        this.MinimumSize = new Size(300, 0);
        this.Name = "LoginWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Connexion";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.buttonsCenterPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel centerPanel;
    private TextBox usernameTextBox;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel buttonsCenterPanel;
    private Button connectButton;
    private Button buttonQuit;
    private TextBox passwordTextBox;
    private Panel spacingPanel1;
    private Label headerLabel;
}