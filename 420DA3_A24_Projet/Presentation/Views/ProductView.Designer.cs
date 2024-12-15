namespace _420DA3_A24_Projet.Presentation.Views;

partial class ProductView {
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
        this.Top_bar = new Panel();
        this.Bottom_bar = new Panel();
        this.tblPanel_Main = new TableLayoutPanel();
        this.pnl_Main_Search = new Panel();
        this.panel3 = new Panel();
        this.panel1 = new Panel();
        this.panel2 = new Panel();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.pnl_Search_Titles = new Panel();
        this.pnl_Main_Details = new Panel();
        this.groupBox1 = new GroupBox();
        this.pnl_Details_Titles = new Panel();
        this.tblPanel_Main.SuspendLayout();
        this.pnl_Main_Search.SuspendLayout();
        this.panel1.SuspendLayout();
        this.pnl_Main_Details.SuspendLayout();
        this.SuspendLayout();
        // 
        // Top_bar
        // 
        this.Top_bar.Dock = DockStyle.Top;
        this.Top_bar.Location = new Point(0, 0);
        this.Top_bar.Name = "Top_bar";
        this.Top_bar.Size = new Size(1482, 80);
        this.Top_bar.TabIndex = 0;
        // 
        // Bottom_bar
        // 
        this.Bottom_bar.Dock = DockStyle.Bottom;
        this.Bottom_bar.Location = new Point(0, 1073);
        this.Bottom_bar.Name = "Bottom_bar";
        this.Bottom_bar.Size = new Size(1482, 80);
        this.Bottom_bar.TabIndex = 1;
        // 
        // tblPanel_Main
        // 
        this.tblPanel_Main.ColumnCount = 4;
        this.tblPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
        this.tblPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        this.tblPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        this.tblPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
        this.tblPanel_Main.Controls.Add(this.pnl_Main_Search, 1, 0);
        this.tblPanel_Main.Controls.Add(this.pnl_Main_Details, 2, 0);
        this.tblPanel_Main.Dock = DockStyle.Fill;
        this.tblPanel_Main.Location = new Point(0, 80);
        this.tblPanel_Main.Name = "tblPanel_Main";
        this.tblPanel_Main.RowCount = 1;
        this.tblPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Main.Size = new Size(1482, 993);
        this.tblPanel_Main.TabIndex = 2;
        // 
        // pnl_Main_Search
        // 
        this.pnl_Main_Search.Controls.Add(this.panel3);
        this.pnl_Main_Search.Controls.Add(this.panel1);
        this.pnl_Main_Search.Controls.Add(this.tableLayoutPanel2);
        this.pnl_Main_Search.Controls.Add(this.tableLayoutPanel1);
        this.pnl_Main_Search.Controls.Add(this.pnl_Search_Titles);
        this.pnl_Main_Search.Dock = DockStyle.Fill;
        this.pnl_Main_Search.Location = new Point(121, 3);
        this.pnl_Main_Search.Name = "pnl_Main_Search";
        this.pnl_Main_Search.Size = new Size(616, 987);
        this.pnl_Main_Search.TabIndex = 0;
        // 
        // panel3
        // 
        this.panel3.Dock = DockStyle.Right;
        this.panel3.Location = new Point(324, 882);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(292, 105);
        this.panel3.TabIndex = 5;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Dock = DockStyle.Left;
        this.panel1.Location = new Point(0, 882);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(292, 105);
        this.panel1.TabIndex = 3;
        // 
        // panel2
        // 
        this.panel2.Dock = DockStyle.Right;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(292, 105);
        this.panel2.TabIndex = 4;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 3;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.Dock = DockStyle.Top;
        this.tableLayoutPanel2.Location = new Point(0, 225);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new Size(616, 657);
        this.tableLayoutPanel2.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Dock = DockStyle.Top;
        this.tableLayoutPanel1.Location = new Point(0, 125);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(616, 100);
        this.tableLayoutPanel1.TabIndex = 1;
        // 
        // pnl_Search_Titles
        // 
        this.pnl_Search_Titles.Dock = DockStyle.Top;
        this.pnl_Search_Titles.Location = new Point(0, 0);
        this.pnl_Search_Titles.Name = "pnl_Search_Titles";
        this.pnl_Search_Titles.Size = new Size(616, 125);
        this.pnl_Search_Titles.TabIndex = 0;
        // 
        // pnl_Main_Details
        // 
        this.pnl_Main_Details.Controls.Add(this.groupBox1);
        this.pnl_Main_Details.Controls.Add(this.pnl_Details_Titles);
        this.pnl_Main_Details.Dock = DockStyle.Fill;
        this.pnl_Main_Details.Location = new Point(743, 3);
        this.pnl_Main_Details.Name = "pnl_Main_Details";
        this.pnl_Main_Details.Size = new Size(616, 987);
        this.pnl_Main_Details.TabIndex = 1;
        // 
        // groupBox1
        // 
        this.groupBox1.Location = new Point(3, 131);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(580, 853);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Details";
        // 
        // pnl_Details_Titles
        // 
        this.pnl_Details_Titles.Dock = DockStyle.Top;
        this.pnl_Details_Titles.Location = new Point(0, 0);
        this.pnl_Details_Titles.Name = "pnl_Details_Titles";
        this.pnl_Details_Titles.Size = new Size(616, 125);
        this.pnl_Details_Titles.TabIndex = 0;
        // 
        // ProductView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1482, 1153);
        this.Controls.Add(this.tblPanel_Main);
        this.Controls.Add(this.Bottom_bar);
        this.Controls.Add(this.Top_bar);
        this.MinimumSize = new Size(1500, 1018);
        this.Name = "ProductView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Products";
        this.tblPanel_Main.ResumeLayout(false);
        this.pnl_Main_Search.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.pnl_Main_Details.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel Top_bar;
    private Panel Bottom_bar;
    private TableLayoutPanel tblPanel_Main;
    private Panel pnl_Main_Search;
    private Panel pnl_Main_Details;
    private Panel pnl_Search_Titles;
    private Panel pnl_Details_Titles;
    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel3;
    private Panel panel2;
    private GroupBox groupBox1;
}