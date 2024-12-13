namespace _420DA3_A24_Projet.Presentation.Views;

partial class RoleView {
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
        this.openedModeValue = new Label();
        this.openedModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.descriptionValue = new TextBox();
        this.descriptionLabel = new Label();
        this.nameValue = new TextBox();
        this.nameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openedModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // openedModeValue
        // 
        this.openedModeValue.AutoSize = true;
        this.openedModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openedModeValue.Location = new Point(62, 9);
        this.openedModeValue.Name = "openedModeValue";
        this.openedModeValue.Size = new Size(72, 15);
        this.openedModeValue.TabIndex = 3;
        this.openedModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(12, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(44, 15);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 291);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Location = new Point(587, 15);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(120, 23);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "PLACEHOLDER";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(713, 15);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(75, 23);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 3;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerPanel, 1, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(800, 241);
        this.centerTLP.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.descriptionValue);
        this.centerPanel.Controls.Add(this.descriptionLabel);
        this.centerPanel.Controls.Add(this.nameValue);
        this.centerPanel.Controls.Add(this.nameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(173, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(454, 235);
        this.centerPanel.TabIndex = 0;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(189, 170);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(262, 23);
        this.dateDeletedValue.TabIndex = 11;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(189, 141);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(262, 23);
        this.dateModifiedValue.TabIndex = 10;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(189, 112);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(262, 23);
        this.dateCreatedValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(3, 169);
        this.dateDeletedLabel.Margin = new Padding(3);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(180, 23);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date deleted :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(3, 140);
        this.dateModifiedLabel.Margin = new Padding(3);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(180, 23);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date last modified :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(3, 111);
        this.dateCreatedLabel.Margin = new Padding(3);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(180, 23);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date created :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // descriptionValue
        // 
        this.descriptionValue.Location = new Point(189, 83);
        this.descriptionValue.Name = "descriptionValue";
        this.descriptionValue.PlaceholderText = "Role description";
        this.descriptionValue.Size = new Size(262, 23);
        this.descriptionValue.TabIndex = 5;
        // 
        // descriptionLabel
        // 
        this.descriptionLabel.Location = new Point(3, 82);
        this.descriptionLabel.Margin = new Padding(3);
        this.descriptionLabel.Name = "descriptionLabel";
        this.descriptionLabel.Size = new Size(180, 23);
        this.descriptionLabel.TabIndex = 4;
        this.descriptionLabel.Text = "Role description :";
        this.descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(189, 54);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "Role name";
        this.nameValue.Size = new Size(262, 23);
        this.nameValue.TabIndex = 3;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(3, 53);
        this.nameLabel.Margin = new Padding(3);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(180, 23);
        this.nameLabel.TabIndex = 2;
        this.nameLabel.Text = "Role name :";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(189, 26);
        this.idValue.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(262, 23);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 24);
        this.idLabel.Margin = new Padding(3);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(180, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 341);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(500, 380);
        this.Name = "RoleView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Role Management Window";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTLP;
    private Panel centerPanel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Label nameLabel;
    private TextBox nameValue;
    private TextBox descriptionValue;
    private Label descriptionLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Button actionButton;
    private Button cancelButton;
    private Label openedModeValue;
    private Label openedModeLabel;
}