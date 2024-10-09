namespace _420DA3_A24_Exemple_Enseignant.Presentation;

partial class MainMenu {
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
        this.centerTableLayoutPanel = new TableLayoutPanel();
        this.rdvManagementPanel = new Panel();
        this.rdvPanelHeaderPanel = new Panel();
        this.rdvHeaderLabel = new Label();
        this.medecinManagementPanel = new Panel();
        this.medecinPanelMainPanel = new Panel();
        this.groupBox1 = new GroupBox();
        this.medecinSearchResultsListBox = new ListBox();
        this.medecinActionButtonsPanel = new Panel();
        this.btnMedecinModifier = new Button();
        this.btnMedecinSupprimer = new Button();
        this.btnMedecinViewDetails = new Button();
        this.medecinSearchBox = new TextBox();
        this.createMedecinTableLayout = new TableLayoutPanel();
        this.btnCreateMedecin = new Button();
        this.medecinPanelHeaderPanel = new Panel();
        this.medecinHeaderLabel = new Label();
        this.patientManagementPanel = new Panel();
        this.patientPanelHeaderPanel = new Panel();
        this.patientHeaderLabel = new Label();
        this.centerTableLayoutPanel.SuspendLayout();
        this.rdvManagementPanel.SuspendLayout();
        this.rdvPanelHeaderPanel.SuspendLayout();
        this.medecinManagementPanel.SuspendLayout();
        this.medecinPanelMainPanel.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.medecinActionButtonsPanel.SuspendLayout();
        this.createMedecinTableLayout.SuspendLayout();
        this.medecinPanelHeaderPanel.SuspendLayout();
        this.patientManagementPanel.SuspendLayout();
        this.patientPanelHeaderPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1197, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 549);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1197, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // centerTableLayoutPanel
        // 
        this.centerTableLayoutPanel.ColumnCount = 3;
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        this.centerTableLayoutPanel.Controls.Add(this.rdvManagementPanel, 2, 0);
        this.centerTableLayoutPanel.Controls.Add(this.medecinManagementPanel, 0, 0);
        this.centerTableLayoutPanel.Controls.Add(this.patientManagementPanel, 1, 0);
        this.centerTableLayoutPanel.Dock = DockStyle.Fill;
        this.centerTableLayoutPanel.Location = new Point(0, 50);
        this.centerTableLayoutPanel.Name = "centerTableLayoutPanel";
        this.centerTableLayoutPanel.RowCount = 1;
        this.centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTableLayoutPanel.Size = new Size(1197, 499);
        this.centerTableLayoutPanel.TabIndex = 2;
        // 
        // rdvManagementPanel
        // 
        this.rdvManagementPanel.Controls.Add(this.rdvPanelHeaderPanel);
        this.rdvManagementPanel.Dock = DockStyle.Fill;
        this.rdvManagementPanel.Location = new Point(800, 3);
        this.rdvManagementPanel.Name = "rdvManagementPanel";
        this.rdvManagementPanel.Size = new Size(394, 493);
        this.rdvManagementPanel.TabIndex = 2;
        // 
        // rdvPanelHeaderPanel
        // 
        this.rdvPanelHeaderPanel.Controls.Add(this.rdvHeaderLabel);
        this.rdvPanelHeaderPanel.Dock = DockStyle.Top;
        this.rdvPanelHeaderPanel.Location = new Point(0, 0);
        this.rdvPanelHeaderPanel.Name = "rdvPanelHeaderPanel";
        this.rdvPanelHeaderPanel.Size = new Size(394, 50);
        this.rdvPanelHeaderPanel.TabIndex = 0;
        // 
        // rdvHeaderLabel
        // 
        this.rdvHeaderLabel.Dock = DockStyle.Fill;
        this.rdvHeaderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        this.rdvHeaderLabel.Location = new Point(0, 0);
        this.rdvHeaderLabel.Name = "rdvHeaderLabel";
        this.rdvHeaderLabel.Size = new Size(394, 50);
        this.rdvHeaderLabel.TabIndex = 1;
        this.rdvHeaderLabel.Text = "Gestion des rendez-vous";
        this.rdvHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // medecinManagementPanel
        // 
        this.medecinManagementPanel.Controls.Add(this.medecinPanelMainPanel);
        this.medecinManagementPanel.Controls.Add(this.medecinPanelHeaderPanel);
        this.medecinManagementPanel.Dock = DockStyle.Fill;
        this.medecinManagementPanel.Location = new Point(3, 3);
        this.medecinManagementPanel.Name = "medecinManagementPanel";
        this.medecinManagementPanel.Size = new Size(392, 493);
        this.medecinManagementPanel.TabIndex = 0;
        // 
        // medecinPanelMainPanel
        // 
        this.medecinPanelMainPanel.Controls.Add(this.groupBox1);
        this.medecinPanelMainPanel.Controls.Add(this.createMedecinTableLayout);
        this.medecinPanelMainPanel.Dock = DockStyle.Fill;
        this.medecinPanelMainPanel.Location = new Point(0, 50);
        this.medecinPanelMainPanel.Name = "medecinPanelMainPanel";
        this.medecinPanelMainPanel.Size = new Size(392, 443);
        this.medecinPanelMainPanel.TabIndex = 1;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.medecinSearchResultsListBox);
        this.groupBox1.Controls.Add(this.medecinActionButtonsPanel);
        this.groupBox1.Controls.Add(this.medecinSearchBox);
        this.groupBox1.Dock = DockStyle.Fill;
        this.groupBox1.Location = new Point(0, 40);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(392, 403);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Médecins existants";
        // 
        // medecinSearchResultsListBox
        // 
        this.medecinSearchResultsListBox.Dock = DockStyle.Fill;
        this.medecinSearchResultsListBox.FormattingEnabled = true;
        this.medecinSearchResultsListBox.ItemHeight = 15;
        this.medecinSearchResultsListBox.Location = new Point(3, 42);
        this.medecinSearchResultsListBox.Name = "medecinSearchResultsListBox";
        this.medecinSearchResultsListBox.Size = new Size(386, 308);
        this.medecinSearchResultsListBox.TabIndex = 2;
        this.medecinSearchResultsListBox.SelectedIndexChanged += this.MedecinSearchResultsListBox_SelectedIndexChanged;
        // 
        // medecinActionButtonsPanel
        // 
        this.medecinActionButtonsPanel.Controls.Add(this.btnMedecinModifier);
        this.medecinActionButtonsPanel.Controls.Add(this.btnMedecinSupprimer);
        this.medecinActionButtonsPanel.Controls.Add(this.btnMedecinViewDetails);
        this.medecinActionButtonsPanel.Dock = DockStyle.Bottom;
        this.medecinActionButtonsPanel.Location = new Point(3, 350);
        this.medecinActionButtonsPanel.Name = "medecinActionButtonsPanel";
        this.medecinActionButtonsPanel.Size = new Size(386, 50);
        this.medecinActionButtonsPanel.TabIndex = 1;
        // 
        // btnMedecinModifier
        // 
        this.btnMedecinModifier.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.btnMedecinModifier.Enabled = false;
        this.btnMedecinModifier.Location = new Point(144, 6);
        this.btnMedecinModifier.Name = "btnMedecinModifier";
        this.btnMedecinModifier.Size = new Size(102, 23);
        this.btnMedecinModifier.TabIndex = 2;
        this.btnMedecinModifier.Text = "Modifier";
        this.btnMedecinModifier.UseVisualStyleBackColor = true;
        this.btnMedecinModifier.Click += this.BtnMedecinModifier_Click;
        // 
        // btnMedecinSupprimer
        // 
        this.btnMedecinSupprimer.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        this.btnMedecinSupprimer.Enabled = false;
        this.btnMedecinSupprimer.Location = new Point(281, 6);
        this.btnMedecinSupprimer.Name = "btnMedecinSupprimer";
        this.btnMedecinSupprimer.Size = new Size(102, 23);
        this.btnMedecinSupprimer.TabIndex = 1;
        this.btnMedecinSupprimer.Text = "Supprimer";
        this.btnMedecinSupprimer.UseVisualStyleBackColor = true;
        this.btnMedecinSupprimer.Click += this.BtnMedecinSupprimer_Click;
        // 
        // btnMedecinViewDetails
        // 
        this.btnMedecinViewDetails.Enabled = false;
        this.btnMedecinViewDetails.Location = new Point(6, 6);
        this.btnMedecinViewDetails.Name = "btnMedecinViewDetails";
        this.btnMedecinViewDetails.Size = new Size(102, 23);
        this.btnMedecinViewDetails.TabIndex = 0;
        this.btnMedecinViewDetails.Text = "Voir Détails";
        this.btnMedecinViewDetails.UseVisualStyleBackColor = true;
        this.btnMedecinViewDetails.Click += this.BtnMedecinViewDetails_Click;
        // 
        // medecinSearchBox
        // 
        this.medecinSearchBox.Dock = DockStyle.Top;
        this.medecinSearchBox.Location = new Point(3, 19);
        this.medecinSearchBox.Name = "medecinSearchBox";
        this.medecinSearchBox.PlaceholderText = "Recherche de médecin";
        this.medecinSearchBox.Size = new Size(386, 23);
        this.medecinSearchBox.TabIndex = 0;
        this.medecinSearchBox.TextChanged += this.MedecinSearchBox_TextChanged;
        // 
        // createMedecinTableLayout
        // 
        this.createMedecinTableLayout.ColumnCount = 3;
        this.createMedecinTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.createMedecinTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        this.createMedecinTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.createMedecinTableLayout.Controls.Add(this.btnCreateMedecin, 1, 0);
        this.createMedecinTableLayout.Dock = DockStyle.Top;
        this.createMedecinTableLayout.Location = new Point(0, 0);
        this.createMedecinTableLayout.Name = "createMedecinTableLayout";
        this.createMedecinTableLayout.RowCount = 1;
        this.createMedecinTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createMedecinTableLayout.Size = new Size(392, 40);
        this.createMedecinTableLayout.TabIndex = 0;
        // 
        // btnCreateMedecin
        // 
        this.btnCreateMedecin.Dock = DockStyle.Fill;
        this.btnCreateMedecin.Location = new Point(81, 3);
        this.btnCreateMedecin.Name = "btnCreateMedecin";
        this.btnCreateMedecin.Size = new Size(229, 34);
        this.btnCreateMedecin.TabIndex = 0;
        this.btnCreateMedecin.Text = "Créer Nouveau Médecin";
        this.btnCreateMedecin.UseVisualStyleBackColor = true;
        this.btnCreateMedecin.Click += this.BtnCreateMedecin_Click;
        // 
        // medecinPanelHeaderPanel
        // 
        this.medecinPanelHeaderPanel.Controls.Add(this.medecinHeaderLabel);
        this.medecinPanelHeaderPanel.Dock = DockStyle.Top;
        this.medecinPanelHeaderPanel.Location = new Point(0, 0);
        this.medecinPanelHeaderPanel.Name = "medecinPanelHeaderPanel";
        this.medecinPanelHeaderPanel.Size = new Size(392, 50);
        this.medecinPanelHeaderPanel.TabIndex = 0;
        // 
        // medecinHeaderLabel
        // 
        this.medecinHeaderLabel.Dock = DockStyle.Fill;
        this.medecinHeaderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        this.medecinHeaderLabel.Location = new Point(0, 0);
        this.medecinHeaderLabel.Name = "medecinHeaderLabel";
        this.medecinHeaderLabel.Size = new Size(392, 50);
        this.medecinHeaderLabel.TabIndex = 0;
        this.medecinHeaderLabel.Text = "Gestion des médecins";
        this.medecinHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // patientManagementPanel
        // 
        this.patientManagementPanel.Controls.Add(this.patientPanelHeaderPanel);
        this.patientManagementPanel.Dock = DockStyle.Fill;
        this.patientManagementPanel.Location = new Point(401, 3);
        this.patientManagementPanel.Name = "patientManagementPanel";
        this.patientManagementPanel.Size = new Size(393, 493);
        this.patientManagementPanel.TabIndex = 1;
        // 
        // patientPanelHeaderPanel
        // 
        this.patientPanelHeaderPanel.Controls.Add(this.patientHeaderLabel);
        this.patientPanelHeaderPanel.Dock = DockStyle.Top;
        this.patientPanelHeaderPanel.Location = new Point(0, 0);
        this.patientPanelHeaderPanel.Name = "patientPanelHeaderPanel";
        this.patientPanelHeaderPanel.Size = new Size(393, 50);
        this.patientPanelHeaderPanel.TabIndex = 0;
        // 
        // patientHeaderLabel
        // 
        this.patientHeaderLabel.Dock = DockStyle.Fill;
        this.patientHeaderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        this.patientHeaderLabel.Location = new Point(0, 0);
        this.patientHeaderLabel.Name = "patientHeaderLabel";
        this.patientHeaderLabel.Size = new Size(393, 50);
        this.patientHeaderLabel.TabIndex = 1;
        this.patientHeaderLabel.Text = "Gestion des patients";
        this.patientHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1197, 599);
        this.Controls.Add(this.centerTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "MainMenu";
        this.Text = "MainMenu";
        this.centerTableLayoutPanel.ResumeLayout(false);
        this.rdvManagementPanel.ResumeLayout(false);
        this.rdvPanelHeaderPanel.ResumeLayout(false);
        this.medecinManagementPanel.ResumeLayout(false);
        this.medecinPanelMainPanel.ResumeLayout(false);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.medecinActionButtonsPanel.ResumeLayout(false);
        this.createMedecinTableLayout.ResumeLayout(false);
        this.medecinPanelHeaderPanel.ResumeLayout(false);
        this.patientManagementPanel.ResumeLayout(false);
        this.patientPanelHeaderPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTableLayoutPanel;
    private Panel medecinManagementPanel;
    private Panel medecinPanelHeaderPanel;
    private Label medecinHeaderLabel;
    private Panel patientManagementPanel;
    private Panel rdvManagementPanel;
    private Panel rdvPanelHeaderPanel;
    private Label rdvHeaderLabel;
    private Panel patientPanelHeaderPanel;
    private Label patientHeaderLabel;
    private Panel medecinPanelMainPanel;
    private TableLayoutPanel createMedecinTableLayout;
    private GroupBox groupBox1;
    private Button btnCreateMedecin;
    private TextBox medecinSearchBox;
    private ListBox medecinSearchResultsListBox;
    private Panel medecinActionButtonsPanel;
    private Button btnMedecinModifier;
    private Button btnMedecinSupprimer;
    private Button btnMedecinViewDetails;
}