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
        this.lbl_Name = new Label();
        this.lbl_Description = new Label();
        this.lbl_Id = new Label();
        this.lbl_codeSupplier = new Label();
        this.lbl_codeUPC = new Label();
        this.txt_Id = new Label();
        this.txt_Name = new Label();
        this.txt_Description = new Label();
        this.txt_codeUPC = new Label();
        this.txt_codeSupplier = new Label();
        this.checkBox_IMG = new CheckBox();
        this.txt_Supplier = new Label();
        this.txt_Client = new Label();
        this.lbl_Qty_InStock = new Label();
        this.lbl_Client = new Label();
        this.lbl_Supplier = new Label();
        this.lbl_Qty_Desired = new Label();
        this.txtl_Qty_Desired = new Label();
        this.txt_Qty_InStock = new Label();
        this.lbl_Weight = new Label();
        this.txt_Weight = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.lbl_dateDeleted = new Label();
        this.lbl_dateModified = new Label();
        this.lbl_dateCreated = new Label();
        this.picBox_Product = new PictureBox();
        this.lbl_Expeditions = new Label();
        this.lbl_Restocks = new Label();
        this.listBox_Restocks = new ListBox();
        this.listBox_Expeditions = new ListBox();
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
        this.grpBox_Details.SuspendLayout();
        this.pnl_Details_Titles.SuspendLayout();
        this.pnl_ConfirmSearch.SuspendLayout();
        this.pnl_SearchList.SuspendLayout();
        this.pnl_Modify.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.picBox_Product).BeginInit();
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
        this.pnl_Delete.Location = new Point(298, 901);
        this.pnl_Delete.Name = "pnl_Delete";
        this.pnl_Delete.Size = new Size(318, 86);
        this.pnl_Delete.TabIndex = 5;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.pnl_Create);
        this.panel1.Dock = DockStyle.Left;
        this.panel1.Location = new Point(0, 901);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(292, 86);
        this.panel1.TabIndex = 3;
        // 
        // pnl_Create
        // 
        this.pnl_Create.Controls.Add(this.btn_Create);
        this.pnl_Create.Dock = DockStyle.Left;
        this.pnl_Create.Location = new Point(0, 0);
        this.pnl_Create.Name = "pnl_Create";
        this.pnl_Create.Size = new Size(297, 86);
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
        this.tblPanel_SearchList.Size = new Size(616, 676);
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
        this.tblPanel_Modify.Location = new Point(0, 901);
        this.tblPanel_Modify.Name = "tblPanel_Modify";
        this.tblPanel_Modify.RowCount = 1;
        this.tblPanel_Modify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Modify.Size = new Size(616, 86);
        this.tblPanel_Modify.TabIndex = 4;
        // 
        // grpBox_Details
        // 
        this.grpBox_Details.Controls.Add(this.listBox_Expeditions);
        this.grpBox_Details.Controls.Add(this.listBox_Restocks);
        this.grpBox_Details.Controls.Add(this.lbl_Restocks);
        this.grpBox_Details.Controls.Add(this.lbl_Expeditions);
        this.grpBox_Details.Controls.Add(this.picBox_Product);
        this.grpBox_Details.Controls.Add(this.dateDeletedValue);
        this.grpBox_Details.Controls.Add(this.dateModifiedValue);
        this.grpBox_Details.Controls.Add(this.dateCreatedValue);
        this.grpBox_Details.Controls.Add(this.lbl_dateDeleted);
        this.grpBox_Details.Controls.Add(this.lbl_dateModified);
        this.grpBox_Details.Controls.Add(this.lbl_dateCreated);
        this.grpBox_Details.Controls.Add(this.lbl_Weight);
        this.grpBox_Details.Controls.Add(this.txt_Weight);
        this.grpBox_Details.Controls.Add(this.lbl_Supplier);
        this.grpBox_Details.Controls.Add(this.lbl_Qty_Desired);
        this.grpBox_Details.Controls.Add(this.txtl_Qty_Desired);
        this.grpBox_Details.Controls.Add(this.txt_Qty_InStock);
        this.grpBox_Details.Controls.Add(this.lbl_Qty_InStock);
        this.grpBox_Details.Controls.Add(this.lbl_Client);
        this.grpBox_Details.Controls.Add(this.txt_Supplier);
        this.grpBox_Details.Controls.Add(this.txt_Client);
        this.grpBox_Details.Controls.Add(this.checkBox_IMG);
        this.grpBox_Details.Controls.Add(this.txt_codeSupplier);
        this.grpBox_Details.Controls.Add(this.txt_codeUPC);
        this.grpBox_Details.Controls.Add(this.txt_Description);
        this.grpBox_Details.Controls.Add(this.txt_Name);
        this.grpBox_Details.Controls.Add(this.txt_Id);
        this.grpBox_Details.Controls.Add(this.lbl_codeSupplier);
        this.grpBox_Details.Controls.Add(this.lbl_codeUPC);
        this.grpBox_Details.Controls.Add(this.lbl_Name);
        this.grpBox_Details.Controls.Add(this.lbl_Description);
        this.grpBox_Details.Controls.Add(this.lbl_Id);
        this.grpBox_Details.Location = new Point(15, 125);
        this.grpBox_Details.Name = "grpBox_Details";
        this.grpBox_Details.Size = new Size(585, 770);
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
        this.pnl_SearchList.Size = new Size(454, 670);
        this.pnl_SearchList.TabIndex = 0;
        // 
        // pnl_Modify
        // 
        this.pnl_Modify.Controls.Add(this.btn_Update);
        this.pnl_Modify.Location = new Point(186, 3);
        this.pnl_Modify.Name = "pnl_Modify";
        this.pnl_Modify.Size = new Size(244, 80);
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
        this.btn_Create.Location = new Point(19, 5);
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
        this.btn_Delete.Location = new Point(33, 16);
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
        this.btn_Update.Location = new Point(3, 13);
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
        // lbl_Name
        // 
        this.lbl_Name.Location = new Point(278, 22);
        this.lbl_Name.Margin = new Padding(6);
        this.lbl_Name.Name = "lbl_Name";
        this.lbl_Name.Size = new Size(73, 30);
        this.lbl_Name.TabIndex = 26;
        this.lbl_Name.Text = "Nom  :";
        this.lbl_Name.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Description
        // 
        this.lbl_Description.Location = new Point(29, 59);
        this.lbl_Description.Margin = new Padding(6);
        this.lbl_Description.Name = "lbl_Description";
        this.lbl_Description.Size = new Size(103, 30);
        this.lbl_Description.TabIndex = 22;
        this.lbl_Description.Text = "Description :";
        this.lbl_Description.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Id
        // 
        this.lbl_Id.Location = new Point(72, 22);
        this.lbl_Id.Margin = new Padding(6);
        this.lbl_Id.Name = "lbl_Id";
        this.lbl_Id.Size = new Size(61, 30);
        this.lbl_Id.TabIndex = 21;
        this.lbl_Id.Text = "Id :";
        this.lbl_Id.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_codeSupplier
        // 
        this.lbl_codeSupplier.Location = new Point(260, 164);
        this.lbl_codeSupplier.Margin = new Padding(6);
        this.lbl_codeSupplier.Name = "lbl_codeSupplier";
        this.lbl_codeSupplier.Size = new Size(141, 30);
        this.lbl_codeSupplier.TabIndex = 28;
        this.lbl_codeSupplier.Text = "code Fournisseur  :";
        this.lbl_codeSupplier.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_codeUPC
        // 
        this.lbl_codeUPC.Location = new Point(9, 164);
        this.lbl_codeUPC.Margin = new Padding(6);
        this.lbl_codeUPC.Name = "lbl_codeUPC";
        this.lbl_codeUPC.Size = new Size(123, 30);
        this.lbl_codeUPC.TabIndex = 27;
        this.lbl_codeUPC.Text = "code UPC :";
        this.lbl_codeUPC.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txt_Id
        // 
        this.txt_Id.BackColor = SystemColors.Window;
        this.txt_Id.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Id.Location = new Point(141, 22);
        this.txt_Id.Margin = new Padding(6);
        this.txt_Id.Name = "txt_Id";
        this.txt_Id.Size = new Size(130, 30);
        this.txt_Id.TabIndex = 29;
        this.txt_Id.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Name
        // 
        this.txt_Name.BackColor = SystemColors.Window;
        this.txt_Name.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Name.Location = new Point(353, 22);
        this.txt_Name.Margin = new Padding(6);
        this.txt_Name.Name = "txt_Name";
        this.txt_Name.Size = new Size(212, 30);
        this.txt_Name.TabIndex = 30;
        this.txt_Name.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Description
        // 
        this.txt_Description.BackColor = SystemColors.Window;
        this.txt_Description.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Description.Location = new Point(141, 65);
        this.txt_Description.Margin = new Padding(6);
        this.txt_Description.Name = "txt_Description";
        this.txt_Description.Size = new Size(424, 84);
        this.txt_Description.TabIndex = 31;
        this.txt_Description.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_codeUPC
        // 
        this.txt_codeUPC.BackColor = SystemColors.Window;
        this.txt_codeUPC.BorderStyle = BorderStyle.FixedSingle;
        this.txt_codeUPC.Location = new Point(141, 164);
        this.txt_codeUPC.Margin = new Padding(6);
        this.txt_codeUPC.Name = "txt_codeUPC";
        this.txt_codeUPC.Size = new Size(120, 30);
        this.txt_codeUPC.TabIndex = 32;
        this.txt_codeUPC.Text = "C-";
        this.txt_codeUPC.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_codeSupplier
        // 
        this.txt_codeSupplier.BackColor = SystemColors.Window;
        this.txt_codeSupplier.BorderStyle = BorderStyle.FixedSingle;
        this.txt_codeSupplier.Location = new Point(407, 164);
        this.txt_codeSupplier.Margin = new Padding(6);
        this.txt_codeSupplier.Name = "txt_codeSupplier";
        this.txt_codeSupplier.Size = new Size(158, 30);
        this.txt_codeSupplier.TabIndex = 33;
        this.txt_codeSupplier.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // checkBox_IMG
        // 
        this.checkBox_IMG.AutoSize = true;
        this.checkBox_IMG.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
        this.checkBox_IMG.Location = new Point(471, 203);
        this.checkBox_IMG.Name = "checkBox_IMG";
        this.checkBox_IMG.RightToLeft = RightToLeft.No;
        this.checkBox_IMG.Size = new Size(114, 29);
        this.checkBox_IMG.TabIndex = 34;
        this.checkBox_IMG.Text = "show IMG";
        this.checkBox_IMG.UseVisualStyleBackColor = true;
        // 
        // txt_Supplier
        // 
        this.txt_Supplier.BackColor = SystemColors.Window;
        this.txt_Supplier.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Supplier.Location = new Point(145, 282);
        this.txt_Supplier.Margin = new Padding(6);
        this.txt_Supplier.Name = "txt_Supplier";
        this.txt_Supplier.Size = new Size(217, 30);
        this.txt_Supplier.TabIndex = 38;
        this.txt_Supplier.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Client
        // 
        this.txt_Client.BackColor = SystemColors.Window;
        this.txt_Client.BorderStyle = BorderStyle.FixedSingle;
        this.txt_Client.Location = new Point(144, 240);
        this.txt_Client.Margin = new Padding(6);
        this.txt_Client.Name = "txt_Client";
        this.txt_Client.Size = new Size(217, 30);
        this.txt_Client.TabIndex = 37;
        this.txt_Client.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_Qty_InStock
        // 
        this.lbl_Qty_InStock.Location = new Point(3, 319);
        this.lbl_Qty_InStock.Margin = new Padding(6);
        this.lbl_Qty_InStock.Name = "lbl_Qty_InStock";
        this.lbl_Qty_InStock.Size = new Size(141, 41);
        this.lbl_Qty_InStock.TabIndex = 40;
        this.lbl_Qty_InStock.Text = "Quantité en Stock  :";
        this.lbl_Qty_InStock.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Client
        // 
        this.lbl_Client.Location = new Point(9, 238);
        this.lbl_Client.Margin = new Padding(6);
        this.lbl_Client.Name = "lbl_Client";
        this.lbl_Client.Size = new Size(124, 30);
        this.lbl_Client.TabIndex = 39;
        this.lbl_Client.Text = "Client Name : ";
        this.lbl_Client.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Supplier
        // 
        this.lbl_Supplier.Location = new Point(4, 280);
        this.lbl_Supplier.Margin = new Padding(6);
        this.lbl_Supplier.Name = "lbl_Supplier";
        this.lbl_Supplier.Size = new Size(123, 30);
        this.lbl_Supplier.TabIndex = 44;
        this.lbl_Supplier.Text = "Supplier Name  :";
        this.lbl_Supplier.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Qty_Desired
        // 
        this.lbl_Qty_Desired.Location = new Point(20, 366);
        this.lbl_Qty_Desired.Margin = new Padding(6);
        this.lbl_Qty_Desired.Name = "lbl_Qty_Desired";
        this.lbl_Qty_Desired.Size = new Size(124, 30);
        this.lbl_Qty_Desired.TabIndex = 43;
        this.lbl_Qty_Desired.Text = "Quantité Désiré : ";
        this.lbl_Qty_Desired.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtl_Qty_Desired
        // 
        this.txtl_Qty_Desired.BackColor = SystemColors.Menu;
        this.txtl_Qty_Desired.Location = new Point(155, 366);
        this.txtl_Qty_Desired.Margin = new Padding(6);
        this.txtl_Qty_Desired.Name = "txtl_Qty_Desired";
        this.txtl_Qty_Desired.Size = new Size(207, 30);
        this.txtl_Qty_Desired.TabIndex = 42;
        this.txtl_Qty_Desired.Text = "0";
        this.txtl_Qty_Desired.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Qty_InStock
        // 
        this.txt_Qty_InStock.BackColor = SystemColors.Menu;
        this.txt_Qty_InStock.Location = new Point(155, 324);
        this.txt_Qty_InStock.Margin = new Padding(6);
        this.txt_Qty_InStock.Name = "txt_Qty_InStock";
        this.txt_Qty_InStock.Size = new Size(206, 30);
        this.txt_Qty_InStock.TabIndex = 41;
        this.txt_Qty_InStock.Text = "0";
        this.txt_Qty_InStock.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_Weight
        // 
        this.lbl_Weight.Location = new Point(20, 408);
        this.lbl_Weight.Margin = new Padding(6);
        this.lbl_Weight.Name = "lbl_Weight";
        this.lbl_Weight.Size = new Size(124, 30);
        this.lbl_Weight.TabIndex = 47;
        this.lbl_Weight.Text = "Poids (kg) : ";
        this.lbl_Weight.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txt_Weight
        // 
        this.txt_Weight.BackColor = SystemColors.Menu;
        this.txt_Weight.Location = new Point(155, 408);
        this.txt_Weight.Margin = new Padding(6);
        this.txt_Weight.Name = "txt_Weight";
        this.txt_Weight.Size = new Size(207, 30);
        this.txt_Weight.TabIndex = 45;
        this.txt_Weight.Text = "0";
        this.txt_Weight.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(244, 531);
        this.dateDeletedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(267, 27);
        this.dateDeletedValue.TabIndex = 53;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(244, 490);
        this.dateModifiedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(267, 27);
        this.dateModifiedValue.TabIndex = 52;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(244, 450);
        this.dateCreatedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(267, 27);
        this.dateCreatedValue.TabIndex = 51;
        // 
        // lbl_dateDeleted
        // 
        this.lbl_dateDeleted.Location = new Point(71, 531);
        this.lbl_dateDeleted.Margin = new Padding(6);
        this.lbl_dateDeleted.Name = "lbl_dateDeleted";
        this.lbl_dateDeleted.Size = new Size(165, 30);
        this.lbl_dateDeleted.TabIndex = 50;
        this.lbl_dateDeleted.Text = "Date de suppression :";
        this.lbl_dateDeleted.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_dateModified
        // 
        this.lbl_dateModified.Location = new Point(71, 490);
        this.lbl_dateModified.Margin = new Padding(6);
        this.lbl_dateModified.Name = "lbl_dateModified";
        this.lbl_dateModified.Size = new Size(165, 30);
        this.lbl_dateModified.TabIndex = 49;
        this.lbl_dateModified.Text = "Date de modification :";
        this.lbl_dateModified.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_dateCreated
        // 
        this.lbl_dateCreated.Location = new Point(71, 450);
        this.lbl_dateCreated.Margin = new Padding(6);
        this.lbl_dateCreated.Name = "lbl_dateCreated";
        this.lbl_dateCreated.Size = new Size(165, 30);
        this.lbl_dateCreated.TabIndex = 48;
        this.lbl_dateCreated.Text = "Date de création :";
        this.lbl_dateCreated.TextAlign = ContentAlignment.MiddleRight;
        // 
        // picBox_Product
        // 
        this.picBox_Product.Location = new Point(379, 238);
        this.picBox_Product.Name = "picBox_Product";
        this.picBox_Product.Size = new Size(200, 200);
        this.picBox_Product.TabIndex = 54;
        this.picBox_Product.TabStop = false;
        // 
        // lbl_Expeditions
        // 
        this.lbl_Expeditions.Location = new Point(319, 582);
        this.lbl_Expeditions.Margin = new Padding(6);
        this.lbl_Expeditions.Name = "lbl_Expeditions";
        this.lbl_Expeditions.Size = new Size(160, 30);
        this.lbl_Expeditions.TabIndex = 55;
        this.lbl_Expeditions.Text = "Ordres d’expédition :";
        this.lbl_Expeditions.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_Restocks
        // 
        this.lbl_Restocks.Location = new Point(32, 582);
        this.lbl_Restocks.Margin = new Padding(6);
        this.lbl_Restocks.Name = "lbl_Restocks";
        this.lbl_Restocks.Size = new Size(153, 30);
        this.lbl_Restocks.TabIndex = 56;
        this.lbl_Restocks.Text = "Ordre de restockage :";
        this.lbl_Restocks.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // listBox_Restocks
        // 
        this.listBox_Restocks.FormattingEnabled = true;
        this.listBox_Restocks.ItemHeight = 20;
        this.listBox_Restocks.Location = new Point(32, 615);
        this.listBox_Restocks.Name = "listBox_Restocks";
        this.listBox_Restocks.Size = new Size(253, 144);
        this.listBox_Restocks.TabIndex = 57;
        // 
        // listBox_Expeditions
        // 
        this.listBox_Expeditions.FormattingEnabled = true;
        this.listBox_Expeditions.ItemHeight = 20;
        this.listBox_Expeditions.Location = new Point(319, 615);
        this.listBox_Expeditions.Name = "listBox_Expeditions";
        this.listBox_Expeditions.Size = new Size(253, 144);
        this.listBox_Expeditions.TabIndex = 58;
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
        this.grpBox_Details.ResumeLayout(false);
        this.grpBox_Details.PerformLayout();
        this.pnl_Details_Titles.ResumeLayout(false);
        this.pnl_ConfirmSearch.ResumeLayout(false);
        this.pnl_SearchList.ResumeLayout(false);
        this.pnl_SearchList.PerformLayout();
        this.pnl_Modify.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.picBox_Product).EndInit();
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
    private Label lbl_Name;
    private Label lbl_Description;
    private Label lbl_Id;
    private Label lbl_codeSupplier;
    private Label lbl_codeUPC;
    private Label txt_codeSupplier;
    private Label txt_codeUPC;
    private Label txt_Description;
    private Label txt_Name;
    private Label txt_Id;
    private CheckBox checkBox_IMG;
    private Label lbl_Qty_InStock;
    private Label lbl_Client;
    private Label txt_Supplier;
    private Label txt_Client;
    private Label lbl_Weight;
    private Label txt_Weight;
    private Label lbl_Supplier;
    private Label lbl_Qty_Desired;
    private Label txtl_Qty_Desired;
    private Label txt_Qty_InStock;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label lbl_dateDeleted;
    private Label lbl_dateModified;
    private Label lbl_dateCreated;
    private PictureBox picBox_Product;
    private Label lbl_Restocks;
    private Label lbl_Expeditions;
    private ListBox listBox_Expeditions;
    private ListBox listBox_Restocks;
}