namespace _420DA3_A24_Projet.Presentation;

partial class WhEmpMainMenu {
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
        this.centerTLP = new TableLayoutPanel();
        this.unassignedSoPanel = new Panel();
        this.processingSOPanel = new Panel();
        this.packagedSOPanel = new Panel();
        this.expectedPOPanel = new Panel();
        this.centerTLP.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1356, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 603);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1356, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 6;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        this.centerTLP.Controls.Add(this.unassignedSoPanel, 1, 0);
        this.centerTLP.Controls.Add(this.processingSOPanel, 2, 0);
        this.centerTLP.Controls.Add(this.packagedSOPanel, 3, 0);
        this.centerTLP.Controls.Add(this.expectedPOPanel, 4, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(1356, 553);
        this.centerTLP.TabIndex = 2;
        // 
        // unassignedSoPanel
        // 
        this.unassignedSoPanel.Dock = DockStyle.Fill;
        this.unassignedSoPanel.Location = new Point(23, 3);
        this.unassignedSoPanel.Name = "unassignedSoPanel";
        this.unassignedSoPanel.Size = new Size(323, 547);
        this.unassignedSoPanel.TabIndex = 0;
        // 
        // processingSOPanel
        // 
        this.processingSOPanel.Dock = DockStyle.Fill;
        this.processingSOPanel.Location = new Point(352, 3);
        this.processingSOPanel.Name = "processingSOPanel";
        this.processingSOPanel.Size = new Size(323, 547);
        this.processingSOPanel.TabIndex = 1;
        // 
        // packagedSOPanel
        // 
        this.packagedSOPanel.Dock = DockStyle.Fill;
        this.packagedSOPanel.Location = new Point(681, 3);
        this.packagedSOPanel.Name = "packagedSOPanel";
        this.packagedSOPanel.Size = new Size(323, 547);
        this.packagedSOPanel.TabIndex = 2;
        // 
        // expectedPOPanel
        // 
        this.expectedPOPanel.Dock = DockStyle.Fill;
        this.expectedPOPanel.Location = new Point(1010, 3);
        this.expectedPOPanel.Name = "expectedPOPanel";
        this.expectedPOPanel.Size = new Size(323, 547);
        this.expectedPOPanel.TabIndex = 3;
        // 
        // WhEmpMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1356, 653);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "WhEmpMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Warehouse Employee Main Menu";
        this.WindowState = FormWindowState.Maximized;
        this.centerTLP.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTLP;
    private Panel unassignedSoPanel;
    private Panel processingSOPanel;
    private Panel packagedSOPanel;
    private Panel expectedPOPanel;
}