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
        this.lbl_Id = new Label();
        this.lbl_Company = new Label();
        this.txt_Id = new Label();
        this.txt_Company = new Label();
        this.txt_Email = new Label();
        this.txt_Nom = new Label();
        this.lbl_Email = new Label();
        this.lbl_Nom = new Label();
        this.txt_Phone = new Label();
        this.lbl_Phone = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.lbl_dateDeleted = new Label();
        this.lbl_dateModified = new Label();
        this.lbl_dateCreated = new Label();
        this.lbl_Products = new Label();
        this.listBox_Products = new ListBox();
        this.lbl_Prenom = new Label();
        this.txt_Prenom = new Label();
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
        this.grpBox_Details.SuspendLayout();
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
        this.Bottom_Bar.Location = new Point(0, 923);
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
        this.tblPanel_Main.Size = new Size(1182, 843);
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
        this.pnl_Main_Search.Size = new Size(490, 837);
        this.pnl_Main_Search.TabIndex = 0;
        // 
        // pnl_Delete
        // 
        this.pnl_Delete.Controls.Add(this.btn_Delete);
        this.pnl_Delete.Dock = DockStyle.Right;
        this.pnl_Delete.Location = new Point(253, 749);
        this.pnl_Delete.Name = "pnl_Delete";
        this.pnl_Delete.Size = new Size(237, 88);
        this.pnl_Delete.TabIndex = 7;
        // 
        // pnl_Create
        // 
        this.pnl_Create.Controls.Add(this.btn_Add);
        this.pnl_Create.Dock = DockStyle.Left;
        this.pnl_Create.Location = new Point(0, 749);
        this.pnl_Create.Name = "pnl_Create";
        this.pnl_Create.Size = new Size(254, 88);
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
        this.tblPanel_SearchList.Size = new Size(490, 541);
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
        this.pnl_Main_Details.Size = new Size(490, 837);
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
        this.tblPanel_Modify.Location = new Point(0, 748);
        this.tblPanel_Modify.Name = "tblPanel_Modify";
        this.tblPanel_Modify.RowCount = 1;
        this.tblPanel_Modify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tblPanel_Modify.Size = new Size(490, 89);
        this.tblPanel_Modify.TabIndex = 3;
        // 
        // grpBox_Details
        // 
        this.grpBox_Details.Controls.Add(this.txt_Prenom);
        this.grpBox_Details.Controls.Add(this.lbl_Prenom);
        this.grpBox_Details.Controls.Add(this.listBox_Products);
        this.grpBox_Details.Controls.Add(this.lbl_Products);
        this.grpBox_Details.Controls.Add(this.dateDeletedValue);
        this.grpBox_Details.Controls.Add(this.dateModifiedValue);
        this.grpBox_Details.Controls.Add(this.dateCreatedValue);
        this.grpBox_Details.Controls.Add(this.lbl_dateDeleted);
        this.grpBox_Details.Controls.Add(this.lbl_dateModified);
        this.grpBox_Details.Controls.Add(this.lbl_dateCreated);
        this.grpBox_Details.Controls.Add(this.txt_Phone);
        this.grpBox_Details.Controls.Add(this.lbl_Phone);
        this.grpBox_Details.Controls.Add(this.txt_Email);
        this.grpBox_Details.Controls.Add(this.txt_Nom);
        this.grpBox_Details.Controls.Add(this.lbl_Email);
        this.grpBox_Details.Controls.Add(this.lbl_Nom);
        this.grpBox_Details.Controls.Add(this.txt_Company);
        this.grpBox_Details.Controls.Add(this.txt_Id);
        this.grpBox_Details.Controls.Add(this.lbl_Company);
        this.grpBox_Details.Controls.Add(this.lbl_Id);
        this.grpBox_Details.Location = new Point(15, 127);
        this.grpBox_Details.Name = "grpBox_Details";
        this.grpBox_Details.Size = new Size(456, 615);
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
        this.pnl_SearchList.Size = new Size(344, 535);
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
        this.listBox_Suppliers.Size = new Size(327, 444);
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
        // lbl_Id
        // 
        this.lbl_Id.Location = new Point(9, 29);
        this.lbl_Id.Margin = new Padding(6);
        this.lbl_Id.Name = "lbl_Id";
        this.lbl_Id.Size = new Size(57, 30);
        this.lbl_Id.TabIndex = 22;
        this.lbl_Id.Text = "Id :";
        this.lbl_Id.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Company
        // 
        this.lbl_Company.Location = new Point(168, 31);
        this.lbl_Company.Margin = new Padding(6);
        this.lbl_Company.Name = "lbl_Company";
        this.lbl_Company.Size = new Size(105, 30);
        this.lbl_Company.TabIndex = 24;
        this.lbl_Company.Text = "Compagnie :";
        this.lbl_Company.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txt_Id
        // 
        this.txt_Id.BackColor = SystemColors.Window;
        this.txt_Id.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Id.Location = new Point(78, 32);
        this.txt_Id.Margin = new Padding(6);
        this.txt_Id.Name = "txt_Id";
        this.txt_Id.Size = new Size(87, 30);
        this.txt_Id.TabIndex = 30;
        this.txt_Id.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Company
        // 
        this.txt_Company.BackColor = SystemColors.Window;
        this.txt_Company.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Company.Location = new Point(276, 32);
        this.txt_Company.Margin = new Padding(6);
        this.txt_Company.Name = "txt_Company";
        this.txt_Company.Size = new Size(155, 30);
        this.txt_Company.TabIndex = 31;
        this.txt_Company.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Email
        // 
        this.txt_Email.BackColor = SystemColors.Window;
        this.txt_Email.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Email.Location = new Point(177, 191);
        this.txt_Email.Margin = new Padding(6);
        this.txt_Email.Name = "txt_Email";
        this.txt_Email.Size = new Size(254, 30);
        this.txt_Email.TabIndex = 35;
        this.txt_Email.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txt_Nom
        // 
        this.txt_Nom.BackColor = SystemColors.Window;
        this.txt_Nom.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Nom.Location = new Point(177, 139);
        this.txt_Nom.Margin = new Padding(6);
        this.txt_Nom.Name = "txt_Nom";
        this.txt_Nom.Size = new Size(254, 30);
        this.txt_Nom.TabIndex = 34;
        this.txt_Nom.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_Email
        // 
        this.lbl_Email.Location = new Point(57, 191);
        this.lbl_Email.Margin = new Padding(6);
        this.lbl_Email.Name = "lbl_Email";
        this.lbl_Email.Size = new Size(108, 30);
        this.lbl_Email.TabIndex = 33;
        this.lbl_Email.Text = "Courriel Elect :";
        this.lbl_Email.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Nom
        // 
        this.lbl_Nom.Location = new Point(41, 139);
        this.lbl_Nom.Margin = new Padding(6);
        this.lbl_Nom.Name = "lbl_Nom";
        this.lbl_Nom.Size = new Size(124, 30);
        this.lbl_Nom.TabIndex = 32;
        this.lbl_Nom.Text = "Nom :";
        this.lbl_Nom.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txt_Phone
        // 
        this.txt_Phone.BackColor = SystemColors.Window;
        this.txt_Phone.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Phone.Location = new Point(177, 242);
        this.txt_Phone.Margin = new Padding(6);
        this.txt_Phone.Name = "txt_Phone";
        this.txt_Phone.Size = new Size(254, 30);
        this.txt_Phone.TabIndex = 37;
        this.txt_Phone.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_Phone
        // 
        this.lbl_Phone.Location = new Point(25, 242);
        this.lbl_Phone.Margin = new Padding(6);
        this.lbl_Phone.Name = "lbl_Phone";
        this.lbl_Phone.Size = new Size(140, 30);
        this.lbl_Phone.TabIndex = 36;
        this.lbl_Phone.Text = "Phone :";
        this.lbl_Phone.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(174, 379);
        this.dateDeletedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(267, 27);
        this.dateDeletedValue.TabIndex = 59;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(177, 338);
        this.dateModifiedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(264, 27);
        this.dateModifiedValue.TabIndex = 58;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(177, 298);
        this.dateCreatedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(264, 27);
        this.dateCreatedValue.TabIndex = 57;
        // 
        // lbl_dateDeleted
        // 
        this.lbl_dateDeleted.Location = new Point(9, 379);
        this.lbl_dateDeleted.Margin = new Padding(6);
        this.lbl_dateDeleted.Name = "lbl_dateDeleted";
        this.lbl_dateDeleted.Size = new Size(156, 30);
        this.lbl_dateDeleted.TabIndex = 56;
        this.lbl_dateDeleted.Text = "Date de suppression :";
        this.lbl_dateDeleted.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_dateModified
        // 
        this.lbl_dateModified.Location = new Point(0, 337);
        this.lbl_dateModified.Margin = new Padding(6);
        this.lbl_dateModified.Name = "lbl_dateModified";
        this.lbl_dateModified.Size = new Size(165, 30);
        this.lbl_dateModified.TabIndex = 55;
        this.lbl_dateModified.Text = "Date de modification :";
        this.lbl_dateModified.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_dateCreated
        // 
        this.lbl_dateCreated.Location = new Point(25, 298);
        this.lbl_dateCreated.Margin = new Padding(6);
        this.lbl_dateCreated.Name = "lbl_dateCreated";
        this.lbl_dateCreated.Size = new Size(140, 30);
        this.lbl_dateCreated.TabIndex = 54;
        this.lbl_dateCreated.Text = "Date de création :";
        this.lbl_dateCreated.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_Products
        // 
        this.lbl_Products.Location = new Point(25, 431);
        this.lbl_Products.Margin = new Padding(6);
        this.lbl_Products.Name = "lbl_Products";
        this.lbl_Products.Size = new Size(140, 30);
        this.lbl_Products.TabIndex = 60;
        this.lbl_Products.Text = "Liste de Produits :";
        this.lbl_Products.TextAlign = ContentAlignment.MiddleRight;
        // 
        // listBox_Products
        // 
        this.listBox_Products.FormattingEnabled = true;
        this.listBox_Products.ItemHeight = 20;
        this.listBox_Products.Location = new Point(174, 431);
        this.listBox_Products.Name = "listBox_Products";
        this.listBox_Products.Size = new Size(267, 164);
        this.listBox_Products.TabIndex = 61;
        // 
        // lbl_Prenom
        // 
        this.lbl_Prenom.Location = new Point(25, 84);
        this.lbl_Prenom.Margin = new Padding(6);
        this.lbl_Prenom.Name = "lbl_Prenom";
        this.lbl_Prenom.Size = new Size(140, 30);
        this.lbl_Prenom.TabIndex = 62;
        this.lbl_Prenom.Text = "Prénom :";
        this.lbl_Prenom.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txt_Prenom
        // 
        this.txt_Prenom.BackColor = SystemColors.Window;
        this.txt_Prenom.BorderStyle = BorderStyle.Fixed3D;
        this.txt_Prenom.Location = new Point(177, 84);
        this.txt_Prenom.Margin = new Padding(6);
        this.txt_Prenom.Name = "txt_Prenom";
        this.txt_Prenom.Size = new Size(254, 30);
        this.txt_Prenom.TabIndex = 63;
        this.txt_Prenom.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1182, 1003);
        this.Controls.Add(this.tblPanel_Main);
        this.Controls.Add(this.Bottom_Bar);
        this.Controls.Add(this.Top_Bar);
        this.MinimumSize = new Size(1200, 1018);
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
        this.grpBox_Details.ResumeLayout(false);
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
    private Label lbl_Company;
    private Label lbl_Id;
    private Label txt_Id;
    private Label txt_Phone;
    private Label lbl_Phone;
    private Label txt_Email;
    private Label txt_Nom;
    private Label lbl_Email;
    private Label lbl_Nom;
    private Label txt_Company;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label lbl_dateDeleted;
    private Label lbl_dateModified;
    private Label lbl_dateCreated;
    private Label lbl_Products;
    private ListBox listBox_Products;
    private Label txt_Prenom;
    private Label lbl_Prenom;
}