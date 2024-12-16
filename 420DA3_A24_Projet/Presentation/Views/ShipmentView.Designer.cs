namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShipmentView {
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
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.bottomBarPanel = new Panel();
        this.button2 = new Button();
        this.button1 = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.statusValue = new ComboBox();
        this.statusLabel = new Label();
        this.shippingServiceValue = new ComboBox();
        this.shippingServiceLabel = new Label();
        this.shippingOrderIdValue = new NumericUpDown();
        this.shippingOrderIdLabel = new Label();
        this.trackingNumberValue = new TextBox();
        this.trackingNumberLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerBarTabLayPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.shippingOrderIdValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 50);
        this.topBarPanel.TabIndex = 1;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(53, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(72, 15);
        this.openendModeValue.TabIndex = 1;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(3, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(44, 15);
        this.openedModeLabel.TabIndex = 0;
        this.openedModeLabel.Text = "Mode :";
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(1193, -35);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(114, 23);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1313, -35);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.button2);
        this.bottomBarPanel.Controls.Add(this.button1);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 341);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 50);
        this.bottomBarPanel.TabIndex = 2;
        // 
        // button2
        // 
        this.button2.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button2.Location = new Point(713, 15);
        this.button2.Name = "button2";
        this.button2.Size = new Size(75, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "Annuler";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.button1.Location = new Point(593, 15);
        this.button1.Name = "button1";
        this.button1.Size = new Size(114, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "ACTION";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // centerBarTabLayPanel
        // 
        this.centerBarTabLayPanel.ColumnCount = 3;
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerBarTabLayPanel.Dock = DockStyle.Fill;
        this.centerBarTabLayPanel.Location = new Point(0, 50);
        this.centerBarTabLayPanel.Name = "centerBarTabLayPanel";
        this.centerBarTabLayPanel.RowCount = 1;
        this.centerBarTabLayPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerBarTabLayPanel.Size = new Size(800, 291);
        this.centerBarTabLayPanel.TabIndex = 3;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.trackingNumberValue);
        this.centerPanel.Controls.Add(this.trackingNumberLabel);
        this.centerPanel.Controls.Add(this.shippingOrderIdValue);
        this.centerPanel.Controls.Add(this.shippingOrderIdLabel);
        this.centerPanel.Controls.Add(this.shippingServiceValue);
        this.centerPanel.Controls.Add(this.shippingServiceLabel);
        this.centerPanel.Controls.Add(this.statusValue);
        this.centerPanel.Controls.Add(this.statusLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(203, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(394, 285);
        this.centerPanel.TabIndex = 0;
        this.centerPanel.Paint += this.centerPanel_Paint;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(157, 17);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(234, 23);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(5, 15);
        this.idLabel.Margin = new Padding(5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(144, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusValue
        // 
        this.statusValue.FormattingEnabled = true;
        this.statusValue.Location = new Point(157, 46);
        this.statusValue.Name = "statusValue";
        this.statusValue.Size = new Size(234, 23);
        this.statusValue.TabIndex = 14;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(5, 45);
        this.statusLabel.Margin = new Padding(5);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(144, 23);
        this.statusLabel.TabIndex = 13;
        this.statusLabel.Text = "Status : ";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // shippingServiceValue
        // 
        this.shippingServiceValue.FormattingEnabled = true;
        this.shippingServiceValue.Location = new Point(157, 75);
        this.shippingServiceValue.Name = "shippingServiceValue";
        this.shippingServiceValue.Size = new Size(234, 23);
        this.shippingServiceValue.TabIndex = 16;
        // 
        // shippingServiceLabel
        // 
        this.shippingServiceLabel.Location = new Point(5, 74);
        this.shippingServiceLabel.Margin = new Padding(5);
        this.shippingServiceLabel.Name = "shippingServiceLabel";
        this.shippingServiceLabel.Size = new Size(144, 23);
        this.shippingServiceLabel.TabIndex = 15;
        this.shippingServiceLabel.Text = "Service d'expédition :";
        this.shippingServiceLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // shippingOrderIdValue
        // 
        this.shippingOrderIdValue.Enabled = false;
        this.shippingOrderIdValue.Location = new Point(157, 110);
        this.shippingOrderIdValue.Name = "shippingOrderIdValue";
        this.shippingOrderIdValue.Size = new Size(234, 23);
        this.shippingOrderIdValue.TabIndex = 18;
        // 
        // shippingOrderIdLabel
        // 
        this.shippingOrderIdLabel.Location = new Point(5, 107);
        this.shippingOrderIdLabel.Margin = new Padding(5);
        this.shippingOrderIdLabel.Name = "shippingOrderIdLabel";
        this.shippingOrderIdLabel.Size = new Size(144, 35);
        this.shippingOrderIdLabel.TabIndex = 17;
        this.shippingOrderIdLabel.Text = "Id de la commande d'expédition : ";
        this.shippingOrderIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // trackingNumberValue
        // 
        this.trackingNumberValue.Location = new Point(157, 149);
        this.trackingNumberValue.Name = "trackingNumberValue";
        this.trackingNumberValue.PlaceholderText = "Numéro de suivi";
        this.trackingNumberValue.Size = new Size(234, 23);
        this.trackingNumberValue.TabIndex = 20;
        this.trackingNumberValue.UseSystemPasswordChar = true;
        // 
        // trackingNumberLabel
        // 
        this.trackingNumberLabel.Location = new Point(5, 148);
        this.trackingNumberLabel.Margin = new Padding(5);
        this.trackingNumberLabel.Name = "trackingNumberLabel";
        this.trackingNumberLabel.Size = new Size(144, 23);
        this.trackingNumberLabel.TabIndex = 19;
        this.trackingNumberLabel.Text = "Numéro de suivi :";
        this.trackingNumberLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(157, 244);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(234, 23);
        this.dateDeletedValue.TabIndex = 26;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(157, 211);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(234, 23);
        this.dateModifiedValue.TabIndex = 25;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(157, 178);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(234, 23);
        this.dateCreatedValue.TabIndex = 24;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 244);
        this.dateDeletedLabel.Margin = new Padding(5);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(144, 23);
        this.dateDeletedLabel.TabIndex = 23;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 211);
        this.dateModifiedLabel.Margin = new Padding(5);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(144, 23);
        this.dateModifiedLabel.TabIndex = 22;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 178);
        this.dateCreatedLabel.Margin = new Padding(5);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(144, 23);
        this.dateCreatedLabel.TabIndex = 21;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ShipmentView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 391);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Margin = new Padding(2, 1, 2, 1);
        this.MinimumSize = new Size(500, 400);
        this.Name = "ShipmentView";
        this.Text = "Gestion des expéditions";
        this.Load += this.ShipmentView_Load;
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.shippingOrderIdValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button btnAction;
    private Button btnCancel;
    private Panel bottomBarPanel;
    private Button button1;
    private Button button2;
    private TableLayoutPanel centerBarTabLayPanel;
    private Panel centerPanel;
    private NumericUpDown idValue;
    private Label idLabel;
    private ComboBox statusValue;
    private Label statusLabel;
    private NumericUpDown shippingOrderIdValue;
    private Label shippingOrderIdLabel;
    private ComboBox shippingServiceValue;
    private Label shippingServiceLabel;
    private TextBox trackingNumberValue;
    private Label trackingNumberLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
}