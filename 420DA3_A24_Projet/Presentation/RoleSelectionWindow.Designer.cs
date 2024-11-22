namespace _420DA3_A24_Projet.Presentation;

partial class RoleSelectionWindow {
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
        this.mainTableLayoutPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.roleSelectionListBox = new ListBox();
        this.roleSelectButton = new Button();
        this.helpHeader = new Label();
        this.headerLabel = new Label();
        this.mainTableLayoutPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // mainTableLayoutPanel
        // 
        this.mainTableLayoutPanel.ColumnCount = 3;
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.Controls.Add(this.centerPanel, 1, 1);
        this.mainTableLayoutPanel.Controls.Add(this.headerLabel, 1, 0);
        this.mainTableLayoutPanel.Dock = DockStyle.Fill;
        this.mainTableLayoutPanel.Location = new Point(0, 0);
        this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        this.mainTableLayoutPanel.RowCount = 3;
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.Size = new Size(284, 311);
        this.mainTableLayoutPanel.TabIndex = 1;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.roleSelectionListBox);
        this.centerPanel.Controls.Add(this.roleSelectButton);
        this.centerPanel.Controls.Add(this.helpHeader);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(45, 58);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(194, 194);
        this.centerPanel.TabIndex = 0;
        // 
        // roleSelectionListBox
        // 
        this.roleSelectionListBox.Dock = DockStyle.Fill;
        this.roleSelectionListBox.FormattingEnabled = true;
        this.roleSelectionListBox.ItemHeight = 15;
        this.roleSelectionListBox.Location = new Point(0, 23);
        this.roleSelectionListBox.Name = "roleSelectionListBox";
        this.roleSelectionListBox.Size = new Size(194, 141);
        this.roleSelectionListBox.TabIndex = 2;
        this.roleSelectionListBox.SelectedIndexChanged += this.RoleSelectionListBox_SelectedIndexChanged;
        // 
        // roleSelectButton
        // 
        this.roleSelectButton.Dock = DockStyle.Bottom;
        this.roleSelectButton.Enabled = false;
        this.roleSelectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleSelectButton.Location = new Point(0, 164);
        this.roleSelectButton.Name = "roleSelectButton";
        this.roleSelectButton.Size = new Size(194, 30);
        this.roleSelectButton.TabIndex = 1;
        this.roleSelectButton.Text = "Choisir";
        this.roleSelectButton.UseVisualStyleBackColor = true;
        this.roleSelectButton.Click += this.RoleSelectButton_Click;
        // 
        // helpHeader
        // 
        this.helpHeader.Dock = DockStyle.Top;
        this.helpHeader.Location = new Point(0, 0);
        this.helpHeader.Name = "helpHeader";
        this.helpHeader.Size = new Size(194, 23);
        this.helpHeader.TabIndex = 0;
        this.helpHeader.Text = "Sélectionnez un rôle:";
        this.helpHeader.TextAlign = ContentAlignment.BottomLeft;
        // 
        // headerLabel
        // 
        this.headerLabel.Dock = DockStyle.Fill;
        this.headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.headerLabel.Location = new Point(45, 0);
        this.headerLabel.Name = "headerLabel";
        this.headerLabel.Size = new Size(194, 55);
        this.headerLabel.TabIndex = 1;
        this.headerLabel.Text = "Sélection du rôle";
        this.headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // RoleSelectionWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 311);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Name = "RoleSelectionWindow";
        this.Text = "Sélection de rôle";
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainTableLayoutPanel;
    private Panel centerPanel;
    private Label headerLabel;
    private ListBox roleSelectionListBox;
    private Button roleSelectButton;
    private Label helpHeader;
}