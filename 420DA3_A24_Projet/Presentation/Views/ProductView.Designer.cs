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
        this.pnl_Delete = new Panel();
        this.tblPanel_SearchList = new TableLayoutPanel();
        this.tblPanel_Confirm_Search = new TableLayoutPanel();
        this.pnl_Search_Titles = new Panel();
        this.pnl_Main_Details = new Panel();
        this.grpBox_Details = new GroupBox();
        this.pnl_Details_Titles = new Panel();
        this.panel1 = new Panel();
        this.pnl_Create = new Panel();
        this.tblPanel_Modify = new TableLayoutPanel();
        this.tblPanel_Main.SuspendLayout();
        this.pnl_Main_Search.SuspendLayout();
        this.pnl_Main_Details.SuspendLayout();
        this.panel1.SuspendLayout();
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
        this.pnl_Main_Search.Controls.Add(this.pnl_Delete);
        this.pnl_Main_Search.Controls.Add(this.panel1);
        this.pnl_Main_Search.Controls.Add(this.tblPanel_SearchList);
        this.pnl_Main_Search.Controls.Add(this.tblPanel_Confirm_Search);
        this.pnl_Main_Search.Controls.Add(this.pnl_Search_Titles);
        this.pnl_Main_Search.Dock = DockStyle.Fill;
        this.pnl_Main_Search.Location = new Point(121, 3);
        this.pnl_Main_Search.Name = "pnl_Main_Search";
        this.pnl_Main_Search.Size = new Size(616, 987);
        this.pnl_Main_Search.TabIndex = 0;
        // 
        // pnl_Delete
        // 
        this.pnl_Delete.Dock = DockStyle.Right;
        this.pnl_Delete.Location = new Point(298, 882);
        this.pnl_Delete.Name = "pnl_Delete";
        this.pnl_Delete.Size = new Size(318, 105);
        this.pnl_Delete.TabIndex = 5;
        // 
        // tblPanel_SearchList
        // 
        this.tblPanel_SearchList.ColumnCount = 3;
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.Dock = DockStyle.Top;
        this.tblPanel_SearchList.Location = new Point(0, 225);
        this.tblPanel_SearchList.Name = "tblPanel_SearchList";
        this.tblPanel_SearchList.RowCount = 1;
        this.tblPanel_SearchList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_SearchList.Size = new Size(616, 657);
        this.tblPanel_SearchList.TabIndex = 2;
        // 
        // tblPanel_Confirm_Search
        // 
        this.tblPanel_Confirm_Search.ColumnCount = 3;
        this.tblPanel_Confirm_Search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Confirm_Search.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
        this.tblPanel_Confirm_Search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Confirm_Search.Dock = DockStyle.Top;
        this.tblPanel_Confirm_Search.Location = new Point(0, 125);
        this.tblPanel_Confirm_Search.Name = "tblPanel_Confirm_Search";
        this.tblPanel_Confirm_Search.RowCount = 1;
        this.tblPanel_Confirm_Search.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Confirm_Search.Size = new Size(616, 100);
        this.tblPanel_Confirm_Search.TabIndex = 1;
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
        this.pnl_Main_Details.Controls.Add(this.tblPanel_Modify);
        this.pnl_Main_Details.Controls.Add(this.grpBox_Details);
        this.pnl_Main_Details.Controls.Add(this.pnl_Details_Titles);
        this.pnl_Main_Details.Dock = DockStyle.Fill;
        this.pnl_Main_Details.Location = new Point(743, 3);
        this.pnl_Main_Details.Name = "pnl_Main_Details";
        this.pnl_Main_Details.Size = new Size(616, 987);
        this.pnl_Main_Details.TabIndex = 1;
        // 
        // grpBox_Details
        // 
        this.grpBox_Details.Location = new Point(15, 131);
        this.grpBox_Details.Name = "grpBox_Details";
        this.grpBox_Details.Size = new Size(585, 745);
        this.grpBox_Details.TabIndex = 1;
        this.grpBox_Details.TabStop = false;
        this.grpBox_Details.Text = "Details";
        // 
        // pnl_Details_Titles
        // 
        this.pnl_Details_Titles.Dock = DockStyle.Top;
        this.pnl_Details_Titles.Location = new Point(0, 0);
        this.pnl_Details_Titles.Name = "pnl_Details_Titles";
        this.pnl_Details_Titles.Size = new Size(616, 125);
        this.pnl_Details_Titles.TabIndex = 0;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.pnl_Create);
        this.panel1.Dock = DockStyle.Left;
        this.panel1.Location = new Point(0, 882);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(292, 105);
        this.panel1.TabIndex = 3;
        // 
        // pnl_Create
        // 
        this.pnl_Create.Dock = DockStyle.Left;
        this.pnl_Create.Location = new Point(0, 0);
        this.pnl_Create.Name = "pnl_Create";
        this.pnl_Create.Size = new Size(297, 105);
        this.pnl_Create.TabIndex = 4;
        // 
        // tblPanel_Modify
        // 
        this.tblPanel_Modify.ColumnCount = 3;
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.Dock = DockStyle.Bottom;
        this.tblPanel_Modify.Location = new Point(0, 882);
        this.tblPanel_Modify.Name = "tblPanel_Modify";
        this.tblPanel_Modify.RowCount = 1;
        this.tblPanel_Modify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Modify.Size = new Size(616, 105);
        this.tblPanel_Modify.TabIndex = 4;
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
        this.pnl_Main_Details.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
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
    private TableLayoutPanel tblPanel_SearchList;
    private TableLayoutPanel tblPanel_Confirm_Search;
    private Panel pnl_Delete;
    private GroupBox grpBox_Details;
    private Panel panel1;
    private Panel pnl_Create;
    private TableLayoutPanel tblPanel_Modify;
}