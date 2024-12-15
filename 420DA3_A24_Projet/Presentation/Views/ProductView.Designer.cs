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
        this.panel1 = new Panel();
        this.pnl_Create = new Panel();
        this.tblPanel_SearchList = new TableLayoutPanel();
        this.tblPanel_ConfirmSearch = new TableLayoutPanel();
        this.pnl_Search_Titles = new Panel();
        this.pnl_Main_Details = new Panel();
        this.tblPanel_Modify = new TableLayoutPanel();
        this.grpBox_Details = new GroupBox();
        this.pnl_Details_Titles = new Panel();
        this.lbl_Produits_Titres = new Label();
        this.lbl_Details_Titres = new Label();
        this.pnl_ConfirmSearch = new Panel();
        this.pnl_SearchList = new Panel();
        this.pnl_Modify = new Panel();
        this.txt_Search = new TextBox();
        this.listBox_Products = new ListBox();
        this.btn_Details = new Button();
        this.btn_Create = new Button();
        this.btn_Delete = new Button();
        this.btn_Update = new Button();
        this.btn_Quit = new Button();
        this.Bottom_bar.SuspendLayout();
        this.tblPanel_Main.SuspendLayout();
        this.pnl_Main_Search.SuspendLayout();
        this.pnl_Delete.SuspendLayout();
        this.panel1.SuspendLayout();
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
        this.Bottom_bar.Controls.Add(this.btn_Quit);
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
        this.pnl_Main_Search.Controls.Add(this.tblPanel_ConfirmSearch);
        this.pnl_Main_Search.Controls.Add(this.pnl_Search_Titles);
        this.pnl_Main_Search.Dock = DockStyle.Fill;
        this.pnl_Main_Search.Location = new Point(121, 3);
        this.pnl_Main_Search.Name = "pnl_Main_Search";
        this.pnl_Main_Search.Size = new Size(616, 987);
        this.pnl_Main_Search.TabIndex = 0;
        // 
        // pnl_Delete
        // 
        this.pnl_Delete.Controls.Add(this.btn_Delete);
        this.pnl_Delete.Dock = DockStyle.Right;
        this.pnl_Delete.Location = new Point(298, 882);
        this.pnl_Delete.Name = "pnl_Delete";
        this.pnl_Delete.Size = new Size(318, 105);
        this.pnl_Delete.TabIndex = 5;
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
        this.pnl_Create.Controls.Add(this.btn_Create);
        this.pnl_Create.Dock = DockStyle.Left;
        this.pnl_Create.Location = new Point(0, 0);
        this.pnl_Create.Name = "pnl_Create";
        this.pnl_Create.Size = new Size(297, 105);
        this.pnl_Create.TabIndex = 4;
        // 
        // tblPanel_SearchList
        // 
        this.tblPanel_SearchList.ColumnCount = 3;
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
        this.tblPanel_SearchList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_SearchList.Controls.Add(this.pnl_SearchList, 1, 0);
        this.tblPanel_SearchList.Dock = DockStyle.Top;
        this.tblPanel_SearchList.Location = new Point(0, 225);
        this.tblPanel_SearchList.Name = "tblPanel_SearchList";
        this.tblPanel_SearchList.RowCount = 1;
        this.tblPanel_SearchList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_SearchList.Size = new Size(616, 657);
        this.tblPanel_SearchList.TabIndex = 2;
        // 
        // tblPanel_ConfirmSearch
        // 
        this.tblPanel_ConfirmSearch.ColumnCount = 3;
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
        this.tblPanel_ConfirmSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_ConfirmSearch.Controls.Add(this.pnl_ConfirmSearch, 1, 0);
        this.tblPanel_ConfirmSearch.Dock = DockStyle.Top;
        this.tblPanel_ConfirmSearch.Location = new Point(0, 125);
        this.tblPanel_ConfirmSearch.Name = "tblPanel_ConfirmSearch";
        this.tblPanel_ConfirmSearch.RowCount = 1;
        this.tblPanel_ConfirmSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_ConfirmSearch.Size = new Size(616, 100);
        this.tblPanel_ConfirmSearch.TabIndex = 1;
        // 
        // pnl_Search_Titles
        // 
        this.pnl_Search_Titles.Controls.Add(this.lbl_Produits_Titres);
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
        // tblPanel_Modify
        // 
        this.tblPanel_Modify.ColumnCount = 3;
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        this.tblPanel_Modify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tblPanel_Modify.Controls.Add(this.pnl_Modify, 1, 0);
        this.tblPanel_Modify.Dock = DockStyle.Bottom;
        this.tblPanel_Modify.Location = new Point(0, 882);
        this.tblPanel_Modify.Name = "tblPanel_Modify";
        this.tblPanel_Modify.RowCount = 1;
        this.tblPanel_Modify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Modify.Size = new Size(616, 105);
        this.tblPanel_Modify.TabIndex = 4;
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
        this.pnl_Details_Titles.Controls.Add(this.lbl_Details_Titres);
        this.pnl_Details_Titles.Dock = DockStyle.Top;
        this.pnl_Details_Titles.Location = new Point(0, 0);
        this.pnl_Details_Titles.Name = "pnl_Details_Titles";
        this.pnl_Details_Titles.Size = new Size(616, 125);
        this.pnl_Details_Titles.TabIndex = 0;
        // 
        // lbl_Produits_Titres
        // 
        this.lbl_Produits_Titres.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
        this.lbl_Produits_Titres.Location = new Point(3, 3);
        this.lbl_Produits_Titres.Name = "lbl_Produits_Titres";
        this.lbl_Produits_Titres.Size = new Size(610, 110);
        this.lbl_Produits_Titres.TabIndex = 0;
        this.lbl_Produits_Titres.Text = "Gestion des Produits";
        this.lbl_Produits_Titres.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_Details_Titres
        // 
        this.lbl_Details_Titres.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
        this.lbl_Details_Titres.Location = new Point(15, 3);
        this.lbl_Details_Titres.Name = "lbl_Details_Titres";
        this.lbl_Details_Titres.Size = new Size(585, 110);
        this.lbl_Details_Titres.TabIndex = 1;
        this.lbl_Details_Titres.Text = "Detail du Produit";
        this.lbl_Details_Titres.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnl_ConfirmSearch
        // 
        this.pnl_ConfirmSearch.Controls.Add(this.btn_Details);
        this.pnl_ConfirmSearch.Location = new Point(136, 3);
        this.pnl_ConfirmSearch.Name = "pnl_ConfirmSearch";
        this.pnl_ConfirmSearch.Size = new Size(344, 94);
        this.pnl_ConfirmSearch.TabIndex = 0;
        // 
        // pnl_SearchList
        // 
        this.pnl_SearchList.Controls.Add(this.listBox_Products);
        this.pnl_SearchList.Controls.Add(this.txt_Search);
        this.pnl_SearchList.Dock = DockStyle.Fill;
        this.pnl_SearchList.Location = new Point(81, 3);
        this.pnl_SearchList.Name = "pnl_SearchList";
        this.pnl_SearchList.Size = new Size(454, 651);
        this.pnl_SearchList.TabIndex = 0;
        // 
        // pnl_Modify
        // 
        this.pnl_Modify.Controls.Add(this.btn_Update);
        this.pnl_Modify.Location = new Point(186, 3);
        this.pnl_Modify.Name = "pnl_Modify";
        this.pnl_Modify.Size = new Size(244, 99);
        this.pnl_Modify.TabIndex = 0;
        // 
        // txt_Search
        // 
        this.txt_Search.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Search.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.txt_Search.Location = new Point(3, 14);
        this.txt_Search.Name = "txt_Search";
        this.txt_Search.PlaceholderText = " Recherchez un Produit";
        this.txt_Search.Size = new Size(448, 34);
        this.txt_Search.TabIndex = 0;
        // 
        // listBox_Products
        // 
        this.listBox_Products.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
        this.listBox_Products.FormattingEnabled = true;
        this.listBox_Products.ItemHeight = 22;
        this.listBox_Products.Location = new Point(10, 65);
        this.listBox_Products.Name = "listBox_Products";
        this.listBox_Products.Size = new Size(434, 554);
        this.listBox_Products.TabIndex = 1;
        // 
        // btn_Details
        // 
        this.btn_Details.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Details.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Details.Location = new Point(42, 19);
        this.btn_Details.Name = "btn_Details";
        this.btn_Details.Size = new Size(252, 55);
        this.btn_Details.TabIndex = 0;
        this.btn_Details.Text = "Voir Details";
        this.btn_Details.UseVisualStyleBackColor = true;
        // 
        // btn_Create
        // 
        this.btn_Create.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Create.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Create.Location = new Point(19, 14);
        this.btn_Create.Name = "btn_Create";
        this.btn_Create.Size = new Size(252, 77);
        this.btn_Create.TabIndex = 1;
        this.btn_Create.Text = "Créer un nouveau Produit";
        this.btn_Create.UseVisualStyleBackColor = true;
        // 
        // btn_Delete
        // 
        this.btn_Delete.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Delete.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Delete.Location = new Point(33, 25);
        this.btn_Delete.Name = "btn_Delete";
        this.btn_Delete.Size = new Size(252, 55);
        this.btn_Delete.TabIndex = 1;
        this.btn_Delete.Text = "Supprimer un Produit";
        this.btn_Delete.UseVisualStyleBackColor = true;
        // 
        // btn_Update
        // 
        this.btn_Update.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
        this.btn_Update.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Update.Location = new Point(3, 22);
        this.btn_Update.Name = "btn_Update";
        this.btn_Update.Size = new Size(238, 55);
        this.btn_Update.TabIndex = 1;
        this.btn_Update.Text = "Modifier Produit";
        this.btn_Update.UseVisualStyleBackColor = true;
        // 
        // btn_Quit
        // 
        this.btn_Quit.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btn_Quit.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.btn_Quit.Location = new Point(1209, 13);
        this.btn_Quit.Name = "btn_Quit";
        this.btn_Quit.Size = new Size(252, 55);
        this.btn_Quit.TabIndex = 1;
        this.btn_Quit.Text = "Quitter";
        this.btn_Quit.UseVisualStyleBackColor = true;
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
        this.Bottom_bar.ResumeLayout(false);
        this.tblPanel_Main.ResumeLayout(false);
        this.pnl_Main_Search.ResumeLayout(false);
        this.pnl_Delete.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
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

    private Panel Top_bar;
    private Panel Bottom_bar;
    private TableLayoutPanel tblPanel_Main;
    private Panel pnl_Main_Search;
    private Panel pnl_Main_Details;
    private Panel pnl_Search_Titles;
    private Panel pnl_Details_Titles;
    private TableLayoutPanel tblPanel_SearchList;
    private TableLayoutPanel tblPanel_ConfirmSearch;
    private Panel pnl_Delete;
    private GroupBox grpBox_Details;
    private Panel panel1;
    private Panel pnl_Create;
    private TableLayoutPanel tblPanel_Modify;
    private Label lbl_Produits_Titres;
    private Label lbl_Details_Titres;
    private Panel pnl_SearchList;
    private Panel pnl_ConfirmSearch;
    private Panel pnl_Modify;
    private TextBox txt_Search;
    private ListBox listBox_Products;
    private Button btn_Details;
    private Button btn_Quit;
    private Button btn_Delete;
    private Button btn_Create;
    private Button btn_Update;
}