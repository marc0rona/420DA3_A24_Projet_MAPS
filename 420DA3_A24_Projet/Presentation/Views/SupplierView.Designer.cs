namespace _420DA3_A24_Projet.Presentation.Views;

partial class SupplierView {
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
        this.Top_Bar = new Panel();
        this.Bottom_Bar = new Panel();
        this.tblPanel_Main = new TableLayoutPanel();
        this.pnl_Main_Search = new Panel();
        this.pnl_Delete = new Panel();
        this.pnl_Create = new Panel();
        this.tblPanel_SearchList = new TableLayoutPanel();
        this.tblPanel_ConfirmSearch = new TableLayoutPanel();
        this.pnl_Search_Titles = new Panel();
        this.pnl_Main_Details = new Panel();
        this.tblPanel_Modify = new TableLayoutPanel();
        this.grpBox_Details = new GroupBox();
        this.pnl_Details_Titles = new Panel();
        this.lbl_Gestion_Titres = new Label();
        this.lbl_Details_Titres = new Label();
        this.pnl_ConfirmSearch = new Panel();
        this.pnl_SearchList = new Panel();
        this.pnl_Modify = new Panel();
        this.txt_Search = new TextBox();
        this.listBox_Suppliers = new ListBox();
        this.btn_Details = new Button();
        this.btn_Add = new Button();
        this.btn_Delete = new Button();
        this.btn_Update = new Button();
        this.btn_Quit = new Button();
        this.Bottom_Bar.SuspendLayout();
        this.tblPanel_Main.SuspendLayout();
        this.pnl_Main_Search.SuspendLayout();
        this.pnl_Delete.SuspendLayout();
        this.pnl_Create.SuspendLayout();
        this.tblPanel_SearchList.SuspendLayout();
        this.tblPanel_ConfirmSearch.SuspendLayout();
        this.pnl_Search_Titles.SuspendLayout();
        this.pnl_Main_Details.SuspendLayout();
        this.tblPanel_Modify.SuspendLayout();
        this.pnl_Details_Titles.SuspendLayout();
        this.pnl_ConfirmSearch.SuspendLayout();
        this.pnl_SearchList.SuspendLayout();
        this.pnl_Modify.SuspendLayout();
        this.SuspendLayout();
        // 
        // Top_Bar
        // 
        this.Top_Bar.Dock = DockStyle.Top;
        this.Top_Bar.Location = new Point(0, 0);
        this.Top_Bar.Name = "Top_Bar";
        this.Top_Bar.Size = new Size(1182, 80);
        this.Top_Bar.TabIndex = 0;
        // 
        // Bottom_Bar
        // 
        this.Bottom_Bar.Controls.Add(this.btn_Quit);
        this.Bottom_Bar.Dock = DockStyle.Bottom;
        this.Bottom_Bar.Location = new Point(0, 873);
        this.Bottom_Bar.Name = "Bottom_Bar";
        this.Bottom_Bar.Size = new Size(1182, 80);
        this.Bottom_Bar.TabIndex = 1;
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
        this.tblPanel_Main.Size = new Size(1182, 793);
        this.tblPanel_Main.TabIndex = 2;
        // 
        // pnl_Main_Search
        // 
        this.pnl_Main_Search.Controls.Add(this.pnl_Delete);
        this.pnl_Main_Search.Controls.Add(this.pnl_Create);
        this.pnl_Main_Search.Controls.Add(this.tblPanel_SearchList);
        this.pnl_Main_Search.Controls.Add(this.tblPanel_ConfirmSearch);
        this.pnl_Main_Search.Controls.Add(this.pnl_Search_Titles);
        this.pnl_Main_Search.Dock = DockStyle.Fill;
        this.pnl_Main_Search.Location = new Point(97, 3);
        this.pnl_Main_Search.Name = "pnl_Main_Search";
        this.pnl_Main_Search.Size = new Size(490, 787);
        this.pnl_Main_Search.TabIndex = 0;
        // 
        // pnl_Delete
        // 
        this.pnl_Delete.Controls.Add(this.btn_Delete);
        this.pnl_Delete.Dock = DockStyle.Right;
        this.pnl_Delete.Location = new Point(253, 698);
        this.pnl_Delete.Name = "pnl_Delete";
        this.pnl_Delete.Size = new Size(237, 89);
        this.pnl_Delete.TabIndex = 7;
        // 
        // pnl_Create
        // 
        this.pnl_Create.Controls.Add(this.btn_Add);
        this.pnl_Create.Dock = DockStyle.Left;
        this.pnl_Create.Location = new Point(0, 698);
        this.pnl_Create.Name = "pnl_Create";
        this.pnl_Create.Size = new Size(254, 89);
        this.pnl_Create.TabIndex = 6;
        // 
        // tblPanel_SearchList
        // 
        this.tblPanel_SearchList.ColumnCount = 3;
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.Controls.Add(this.pnl_SearchList, 1, 0);
        this.tblPanel_SearchList.Dock = DockStyle.Top;
        this.tblPanel_SearchList.Location = new Point(0, 208);
        this.tblPanel_SearchList.Name = "tblPanel_SearchList";
        this.tblPanel_SearchList.RowCount = 1;
        this.tblPanel_SearchList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_SearchList.Size = new Size(490, 490);
        this.tblPanel_SearchList.TabIndex = 2;
        // 
        // tblPanel_ConfirmSearch
        // 
        this.tblPanel_ConfirmSearch.ColumnCount = 3;
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_ConfirmSearch.Controls.Add(this.pnl_ConfirmSearch, 1, 0);
        this.tblPanel_ConfirmSearch.Dock = DockStyle.Top;
        this.tblPanel_ConfirmSearch.Location = new Point(0, 115);
        this.tblPanel_ConfirmSearch.Name = "tblPanel_ConfirmSearch";
        this.tblPanel_ConfirmSearch.RowCount = 1;
        this.tblPanel_ConfirmSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_ConfirmSearch.Size = new Size(490, 93);
        this.tblPanel_ConfirmSearch.TabIndex = 1;
        // 
        // pnl_Search_Titles
        // 
        this.pnl_Search_Titles.Controls.Add(this.lbl_Gestion_Titres);
        this.pnl_Search_Titles.Dock = DockStyle.Top;
        this.pnl_Search_Titles.Location = new Point(0, 0);
        this.pnl_Search_Titles.Name = "pnl_Search_Titles";
        this.pnl_Search_Titles.Size = new Size(490, 115);
        this.pnl_Search_Titles.TabIndex = 0;
        // 
        // pnl_Main_Details
        // 
        this.pnl_Main_Details.Controls.Add(this.tblPanel_Modify);
        this.pnl_Main_Details.Controls.Add(this.grpBox_Details);
        this.pnl_Main_Details.Controls.Add(this.pnl_Details_Titles);
        this.pnl_Main_Details.Dock = DockStyle.Fill;
        this.pnl_Main_Details.Location = new Point(593, 3);
        this.pnl_Main_Details.Name = "pnl_Main_Details";
        this.pnl_Main_Details.Size = new Size(490, 787);
        this.pnl_Main_Details.TabIndex = 1;
        // 
        // tblPanel_Modify
        // 
        this.tblPanel_Modify.ColumnCount = 3;
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.Controls.Add(this.pnl_Modify, 1, 0);
        this.tblPanel_Modify.Dock = DockStyle.Bottom;
        this.tblPanel_Modify.Location = new Point(0, 698);
        this.tblPanel_Modify.Name = "tblPanel_Modify";
        this.tblPanel_Modify.RowCount = 1;
        this.tblPanel_Modify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Modify.Size = new Size(490, 89);
        this.tblPanel_Modify.TabIndex = 3;
        // 
        // grpBox_Details
        // 
        this.grpBox_Details.Location = new Point(15, 127);
        this.grpBox_Details.Name = "grpBox_Details";
        this.grpBox_Details.Size = new Size(456, 547);
        this.grpBox_Details.TabIndex = 2;
        this.grpBox_Details.TabStop = false;
        this.grpBox_Details.Text = "Details";
        // 
        // pnl_Details_Titles
        // 
        this.pnl_Details_Titles.Controls.Add(this.lbl_Details_Titres);
        this.pnl_Details_Titles.Dock = DockStyle.Top;
        this.pnl_Details_Titles.Location = new Point(0, 0);
        this.pnl_Details_Titles.Name = "pnl_Details_Titles";
        this.pnl_Details_Titles.Size = new Size(490, 115);
        this.pnl_Details_Titles.TabIndex = 1;
        // 
        // lbl_Gestion_Titres
        // 
        this.lbl_Gestion_Titres.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
        this.lbl_Gestion_Titres.Location = new Point(3, 2);
        this.lbl_Gestion_Titres.Name = "lbl_Gestion_Titres";
        this.lbl_Gestion_Titres.Size = new Size(484, 110);
        this.lbl_Gestion_Titres.TabIndex = 1;
        this.lbl_Gestion_Titres.Text = "Gestion des Fournisseurs";
        this.lbl_Gestion_Titres.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_Details_Titres
        // 
        this.lbl_Details_Titres.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
        this.lbl_Details_Titres.Location = new Point(3, 2);
        this.lbl_Details_Titres.Name = "lbl_Details_Titres";
        this.lbl_Details_Titres.Size = new Size(484, 110);
        this.lbl_Details_Titres.TabIndex = 2;
        this.lbl_Details_Titres.Text = "Détails du Fournisseur";
        this.lbl_Details_Titres.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnl_ConfirmSearch
        // 
        this.pnl_ConfirmSearch.Controls.Add(this.btn_Details);
        this.pnl_ConfirmSearch.Location = new Point(123, 3);
        this.pnl_ConfirmSearch.Name = "pnl_ConfirmSearch";
        this.pnl_ConfirmSearch.Size = new Size(244, 87);
        this.pnl_ConfirmSearch.TabIndex = 0;
        // 
        // pnl_SearchList
        // 
        this.pnl_SearchList.Controls.Add(this.listBox_Suppliers);
        this.pnl_SearchList.Controls.Add(this.txt_Search);
        this.pnl_SearchList.Dock = DockStyle.Fill;
        this.pnl_SearchList.Location = new Point(73, 3);
        this.pnl_SearchList.Name = "pnl_SearchList";
        this.pnl_SearchList.Size = new Size(344, 484);
        this.pnl_SearchList.TabIndex = 0;
        // 
        // pnl_Modify
        // 
        this.pnl_Modify.Controls.Add(this.btn_Update);
        this.pnl_Modify.Location = new Point(123, 3);
        this.pnl_Modify.Name = "pnl_Modify";
        this.pnl_Modify.Size = new Size(244, 83);
        this.pnl_Modify.TabIndex = 0;
        // 
        // txt_Search
        // 
        this.txt_Search.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Search.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.txt_Search.Location = new Point(3, 15);
        this.txt_Search.Name = "txt_Search";
        this.txt_Search.PlaceholderText = " Recherchez un Fournisseur";
        this.txt_Search.Size = new Size(338, 34);
        this.txt_Search.TabIndex = 1;
        // 
        // listBox_Suppliers
        // 
        this.listBox_Suppliers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
        this.listBox_Suppliers.FormattingEnabled = true;
        this.listBox_Suppliers.ItemHeight = 22;
        this.listBox_Suppliers.Location = new Point(9, 65);
        this.listBox_Suppliers.Name = "listBox_Suppliers";
        this.listBox_Suppliers.Size = new Size(327, 400);
        this.listBox_Suppliers.TabIndex = 2;
        // 
        // btn_Details
        // 
        this.btn_Details.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Details.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Details.Location = new Point(11, 16);
        this.btn_Details.Name = "btn_Details";
        this.btn_Details.Size = new Size(230, 55);
        this.btn_Details.TabIndex = 1;
        this.btn_Details.Text = "Voir Details";
        this.btn_Details.UseVisualStyleBackColor = true;
        // 
        // btn_Add
        // 
        this.btn_Add.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Add.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Add.Location = new Point(14, 11);
        this.btn_Add.Name = "btn_Add";
        this.btn_Add.Size = new Size(233, 66);
        this.btn_Add.TabIndex = 2;
        this.btn_Add.Text = "Ajouter un nouveau Fournisseur";
        this.btn_Add.UseVisualStyleBackColor = true;
        // 
        // btn_Delete
        // 
        this.btn_Delete.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Delete.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Delete.Location = new Point(9, 11);
        this.btn_Delete.Name = "btn_Delete";
        this.btn_Delete.Size = new Size(217, 66);
        this.btn_Delete.TabIndex = 2;
        this.btn_Delete.Text = "Supprimer un Fournisseur";
        this.btn_Delete.UseVisualStyleBackColor = true;
        // 
        // btn_Update
        // 
        this.btn_Update.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Update.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Update.Location = new Point(14, 8);
        this.btn_Update.Name = "btn_Update";
        this.btn_Update.Size = new Size(217, 66);
        this.btn_Update.TabIndex = 3;
        this.btn_Update.Text = "Modifier Fournisseur";
        this.btn_Update.UseVisualStyleBackColor = true;
        // 
        // btn_Quit
        // 
        this.btn_Quit.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btn_Quit.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Quit.Location = new Point(918, 13);
        this.btn_Quit.Name = "btn_Quit";
        this.btn_Quit.Size = new Size(252, 55);
        this.btn_Quit.TabIndex = 2;
        this.btn_Quit.Text = "Quitter";
        this.btn_Quit.UseVisualStyleBackColor = true;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1182, 953);
        this.Controls.Add(this.tblPanel_Main);
        this.Controls.Add(this.Bottom_Bar);
        this.Controls.Add(this.Top_Bar);
        this.MinimumSize = new Size(1200, 1000);
        this.Name = "SupplierView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Suppliers";
        this.Bottom_Bar.ResumeLayout(false);
        this.tblPanel_Main.ResumeLayout(false);
        this.pnl_Main_Search.ResumeLayout(false);
        this.pnl_Delete.ResumeLayout(false);
        this.pnl_Create.ResumeLayout(false);
        this.tblPanel_SearchList.ResumeLayout(false);
        this.tblPanel_ConfirmSearch.ResumeLayout(false);
        this.pnl_Search_Titles.ResumeLayout(false);
        this.pnl_Main_Details.ResumeLayout(false);
        this.tblPanel_Modify.ResumeLayout(false);
        this.pnl_Details_Titles.ResumeLayout(false);
        this.pnl_ConfirmSearch.ResumeLayout(false);
        this.pnl_SearchList.ResumeLayout(false);
        this.pnl_SearchList.PerformLayout();
        this.pnl_Modify.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel Top_Bar;
    private Panel Bottom_Bar;
    private TableLayoutPanel tblPanel_Main;
    private Panel pnl_Main_Search;
    private Panel pnl_Main_Details;
    private TableLayoutPanel tblPanel_ConfirmSearch;
    private Panel pnl_Search_Titles;
    private Panel pnl_Details_Titles;
    private TableLayoutPanel tblPanel_SearchList;
    private Panel pnl_Delete;
    private Panel pnl_Create;
    private GroupBox grpBox_Details;
    private TableLayoutPanel tblPanel_Modify;
    private Label lbl_Gestion_Titres;
    private Label lbl_Details_Titres;
    private Panel pnl_ConfirmSearch;
    private Panel pnl_SearchList;
    private Panel pnl_Modify;
    private TextBox txt_Search;
    private ListBox listBox_Suppliers;
    private Button btn_Details;
    private Button btn_Add;
    private Button btn_Delete;
    private Button btn_Update;
    private Button btn_Quit;
}