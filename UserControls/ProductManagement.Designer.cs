namespace CoffeeBackEnd20221026.UserControls
{
    partial class ProductManagement
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProdTabControl = new System.Windows.Forms.TabControl();
            this.ProdGridTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTNselect = new System.Windows.Forms.Button();
            this.TBselect = new System.Windows.Forms.TextBox();
            this.BTNProdDetail = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.ProdDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBFilterColumn = new System.Windows.Forms.ComboBox();
            this.CBFilterValue = new System.Windows.Forms.ComboBox();
            this.BTNClearFilters = new System.Windows.Forms.Button();
            this.ProdDetailTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBFlavor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBUOM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBproductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNAddImage = new System.Windows.Forms.Button();
            this.BTNPicDelete = new System.Windows.Forms.Button();
            this.PBProduct = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNdescription = new System.Windows.Forms.Button();
            this.BTNback = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CBSweet = new System.Windows.Forms.ComboBox();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.CBMethod = new System.Windows.Forms.ComboBox();
            this.CBBitter = new System.Windows.Forms.ComboBox();
            this.CBSTRONG = new System.Windows.Forms.ComboBox();
            this.CBFragrance = new System.Windows.Forms.ComboBox();
            this.CBSour = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CBTimeLimit = new System.Windows.Forms.ComboBox();
            this.TBimg = new System.Windows.Forms.TextBox();
            this.ProdTabControl.SuspendLayout();
            this.ProdGridTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataGridView)).BeginInit();
            this.ProdDetailTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdTabControl
            // 
            this.ProdTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdTabControl.Controls.Add(this.ProdGridTabPage);
            this.ProdTabControl.Controls.Add(this.ProdDetailTabPage);
            this.ProdTabControl.Location = new System.Drawing.Point(3, 3);
            this.ProdTabControl.Name = "ProdTabControl";
            this.ProdTabControl.SelectedIndex = 0;
            this.ProdTabControl.Size = new System.Drawing.Size(1121, 629);
            this.ProdTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ProdTabControl.TabIndex = 0;
            // 
            // ProdGridTabPage
            // 
            this.ProdGridTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ProdGridTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProdGridTabPage.Name = "ProdGridTabPage";
            this.ProdGridTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProdGridTabPage.Size = new System.Drawing.Size(1113, 603);
            this.ProdGridTabPage.TabIndex = 0;
            this.ProdGridTabPage.Text = "所有商品";
            this.ProdGridTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BTNselect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBselect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNProdDetail, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddProduct, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.ProdDataGridView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBFilterColumn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CBFilterValue, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNClearFilters, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 597);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BTNselect
            // 
            this.BTNselect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNselect.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNselect.Location = new System.Drawing.Point(3, 57);
            this.BTNselect.Name = "BTNselect";
            this.BTNselect.Size = new System.Drawing.Size(270, 48);
            this.BTNselect.TabIndex = 0;
            this.BTNselect.Text = "查詢商品名稱";
            this.BTNselect.UseVisualStyleBackColor = true;
            this.BTNselect.Click += new System.EventHandler(this.BTNselect_Click);
            // 
            // TBselect
            // 
            this.TBselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBselect.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBselect.Location = new System.Drawing.Point(3, 3);
            this.TBselect.Name = "TBselect";
            this.TBselect.Size = new System.Drawing.Size(270, 40);
            this.TBselect.TabIndex = 1;
            // 
            // BTNProdDetail
            // 
            this.BTNProdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNProdDetail.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNProdDetail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNProdDetail.Location = new System.Drawing.Point(831, 57);
            this.BTNProdDetail.Name = "BTNProdDetail";
            this.BTNProdDetail.Size = new System.Drawing.Size(273, 48);
            this.BTNProdDetail.TabIndex = 6;
            this.BTNProdDetail.Text = "商品詳細頁";
            this.BTNProdDetail.UseVisualStyleBackColor = true;
            this.BTNProdDetail.Click += new System.EventHandler(this.BTNProdDetail_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(555, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "上/下架指定商品";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddProduct.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAddProduct.Location = new System.Drawing.Point(3, 543);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(270, 51);
            this.BtnAddProduct.TabIndex = 4;
            this.BtnAddProduct.Text = "新增商品";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // ProdDataGridView
            // 
            this.ProdDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.ProdDataGridView, 3);
            this.ProdDataGridView.Location = new System.Drawing.Point(279, 111);
            this.ProdDataGridView.Name = "ProdDataGridView";
            this.ProdDataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.ProdDataGridView, 9);
            this.ProdDataGridView.RowTemplate.Height = 24;
            this.ProdDataGridView.Size = new System.Drawing.Size(825, 483);
            this.ProdDataGridView.TabIndex = 8;
            this.ProdDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDataGridView_CellContentClick);
            this.ProdDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "類別篩選：";
            // 
            // CBFilterColumn
            // 
            this.CBFilterColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFilterColumn.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBFilterColumn.FormattingEnabled = true;
            this.CBFilterColumn.Location = new System.Drawing.Point(3, 225);
            this.CBFilterColumn.Name = "CBFilterColumn";
            this.CBFilterColumn.Size = new System.Drawing.Size(270, 35);
            this.CBFilterColumn.TabIndex = 10;
            this.CBFilterColumn.SelectedIndexChanged += new System.EventHandler(this.CBFilterColumn_SelectedIndexChanged);
            // 
            // CBFilterValue
            // 
            this.CBFilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFilterValue.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBFilterValue.FormattingEnabled = true;
            this.CBFilterValue.Location = new System.Drawing.Point(3, 279);
            this.CBFilterValue.Name = "CBFilterValue";
            this.CBFilterValue.Size = new System.Drawing.Size(270, 35);
            this.CBFilterValue.TabIndex = 9;
            this.CBFilterValue.SelectedIndexChanged += new System.EventHandler(this.CBFilterValue_SelectedIndexChanged);
            // 
            // BTNClearFilters
            // 
            this.BTNClearFilters.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNClearFilters.Location = new System.Drawing.Point(3, 327);
            this.BTNClearFilters.Name = "BTNClearFilters";
            this.BTNClearFilters.Size = new System.Drawing.Size(270, 48);
            this.BTNClearFilters.TabIndex = 11;
            this.BTNClearFilters.Text = "清除篩選";
            this.BTNClearFilters.UseVisualStyleBackColor = true;
            this.BTNClearFilters.Click += new System.EventHandler(this.BTNClearFilters_Click);
            // 
            // ProdDetailTabPage
            // 
            this.ProdDetailTabPage.Controls.Add(this.tableLayoutPanel2);
            this.ProdDetailTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProdDetailTabPage.Name = "ProdDetailTabPage";
            this.ProdDetailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProdDetailTabPage.Size = new System.Drawing.Size(1113, 603);
            this.ProdDetailTabPage.TabIndex = 1;
            this.ProdDetailTabPage.Text = "商品詳細";
            this.ProdDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.TBimg, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CBTimeLimit, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label18, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.label19, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.label16, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.label14, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.label13, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBFlavor, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.TBUOM, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TBproductID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTNAddImage, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.BTNPicDelete, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.PBProduct, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBprice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.TBdescription, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.TBname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTNdescription, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.BTNback, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.BtnUpdate, 5, 10);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 4, 10);
            this.tableLayoutPanel2.Controls.Add(this.CBSweet, 5, 8);
            this.tableLayoutPanel2.Controls.Add(this.CBCountry, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.CBcategory, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.CBMethod, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.CBBitter, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.CBSTRONG, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.CBFragrance, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.CBSour, 4, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 597);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(739, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 54);
            this.label18.TabIndex = 103;
            this.label18.Text = "酸味程度";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(923, 378);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 54);
            this.label19.TabIndex = 100;
            this.label19.Text = "甜味程度";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(923, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 54);
            this.label16.TabIndex = 97;
            this.label16.Text = "香氣程度";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(739, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 54);
            this.label14.TabIndex = 96;
            this.label14.Text = "產地";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(923, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 54);
            this.label13.TabIndex = 95;
            this.label13.Text = "厚實度";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(739, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 54);
            this.label12.TabIndex = 94;
            this.label12.Text = "產品種類";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(923, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 54);
            this.label9.TabIndex = 93;
            this.label9.Text = "苦味程度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(739, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 54);
            this.label6.TabIndex = 92;
            this.label6.Text = "處理方法";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBFlavor
            // 
            this.TBFlavor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBFlavor.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBFlavor.Location = new System.Drawing.Point(187, 273);
            this.TBFlavor.Name = "TBFlavor";
            this.TBFlavor.Size = new System.Drawing.Size(178, 40);
            this.TBFlavor.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(3, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 54);
            this.label15.TabIndex = 78;
            this.label15.Text = "風味：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBUOM
            // 
            this.TBUOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUOM.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBUOM.Location = new System.Drawing.Point(187, 165);
            this.TBUOM.Name = "TBUOM";
            this.TBUOM.Size = new System.Drawing.Size(178, 40);
            this.TBUOM.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 54);
            this.label11.TabIndex = 47;
            this.label11.Text = "UOM：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBproductID
            // 
            this.TBproductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBproductID.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBproductID.Location = new System.Drawing.Point(187, 57);
            this.TBproductID.Name = "TBproductID";
            this.TBproductID.Size = new System.Drawing.Size(178, 40);
            this.TBproductID.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(3, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 54);
            this.label10.TabIndex = 43;
            this.label10.Text = "產品編號：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(739, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 54);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品類型";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNAddImage
            // 
            this.BTNAddImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNAddImage.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNAddImage.Location = new System.Drawing.Point(555, 381);
            this.BTNAddImage.Name = "BTNAddImage";
            this.BTNAddImage.Size = new System.Drawing.Size(178, 48);
            this.BTNAddImage.TabIndex = 25;
            this.BTNAddImage.Text = "新增照片";
            this.BTNAddImage.UseVisualStyleBackColor = true;
            this.BTNAddImage.Click += new System.EventHandler(this.BTNAddImage_Click);
            // 
            // BTNPicDelete
            // 
            this.BTNPicDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNPicDelete.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNPicDelete.Location = new System.Drawing.Point(371, 381);
            this.BTNPicDelete.Name = "BTNPicDelete";
            this.BTNPicDelete.Size = new System.Drawing.Size(178, 48);
            this.BTNPicDelete.TabIndex = 24;
            this.BTNPicDelete.Text = "取消暫存";
            this.BTNPicDelete.UseVisualStyleBackColor = true;
            this.BTNPicDelete.Click += new System.EventHandler(this.BTNPicDelete_Click);
            // 
            // PBProduct
            // 
            this.PBProduct.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.SetColumnSpan(this.PBProduct, 2);
            this.PBProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBProduct.Location = new System.Drawing.Point(371, 57);
            this.PBProduct.Name = "PBProduct";
            this.tableLayoutPanel2.SetRowSpan(this.PBProduct, 6);
            this.PBProduct.Size = new System.Drawing.Size(362, 318);
            this.PBProduct.TabIndex = 22;
            this.PBProduct.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(371, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 54);
            this.label2.TabIndex = 26;
            this.label2.Text = "商品照：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 54);
            this.label4.TabIndex = 29;
            this.label4.Text = "價格：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBprice
            // 
            this.TBprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBprice.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBprice.Location = new System.Drawing.Point(187, 111);
            this.TBprice.Name = "TBprice";
            this.TBprice.Size = new System.Drawing.Size(178, 40);
            this.TBprice.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 54);
            this.label5.TabIndex = 31;
            this.label5.Text = "保存期限";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 54);
            this.label8.TabIndex = 33;
            this.label8.Text = "商品概述：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBdescription
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TBdescription, 2);
            this.TBdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBdescription.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBdescription.Location = new System.Drawing.Point(3, 381);
            this.TBdescription.Multiline = true;
            this.TBdescription.Name = "TBdescription";
            this.tableLayoutPanel2.SetRowSpan(this.TBdescription, 3);
            this.TBdescription.Size = new System.Drawing.Size(362, 156);
            this.TBdescription.TabIndex = 39;
            // 
            // TBname
            // 
            this.TBname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBname.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBname.Location = new System.Drawing.Point(187, 3);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(178, 40);
            this.TBname.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 54);
            this.label3.TabIndex = 27;
            this.label3.Text = "商品名稱：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNdescription
            // 
            this.BTNdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNdescription.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNdescription.Location = new System.Drawing.Point(187, 543);
            this.BTNdescription.Name = "BTNdescription";
            this.BTNdescription.Size = new System.Drawing.Size(178, 51);
            this.BTNdescription.TabIndex = 41;
            this.BTNdescription.Text = "使用文字檔";
            this.BTNdescription.UseVisualStyleBackColor = true;
            this.BTNdescription.Click += new System.EventHandler(this.BTNdescription_Click);
            // 
            // BTNback
            // 
            this.BTNback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNback.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNback.Location = new System.Drawing.Point(3, 543);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(178, 51);
            this.BTNback.TabIndex = 42;
            this.BTNback.Text = "回上頁/取消";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnUpdate.Location = new System.Drawing.Point(923, 543);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(181, 51);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "確認修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDelete.Location = new System.Drawing.Point(739, 543);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(178, 51);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "刪除商品";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CBSweet
            // 
            this.CBSweet.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSweet.FormattingEnabled = true;
            this.CBSweet.Location = new System.Drawing.Point(923, 435);
            this.CBSweet.Name = "CBSweet";
            this.CBSweet.Size = new System.Drawing.Size(181, 35);
            this.CBSweet.TabIndex = 90;
            // 
            // CBCountry
            // 
            this.CBCountry.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(739, 327);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(178, 35);
            this.CBCountry.TabIndex = 55;
            // 
            // CBcategory
            // 
            this.CBcategory.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Location = new System.Drawing.Point(739, 219);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(178, 35);
            this.CBcategory.TabIndex = 51;
            // 
            // CBMethod
            // 
            this.CBMethod.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBMethod.FormattingEnabled = true;
            this.CBMethod.Location = new System.Drawing.Point(739, 111);
            this.CBMethod.Name = "CBMethod";
            this.CBMethod.Size = new System.Drawing.Size(178, 35);
            this.CBMethod.TabIndex = 21;
            // 
            // CBBitter
            // 
            this.CBBitter.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBBitter.FormattingEnabled = true;
            this.CBBitter.Location = new System.Drawing.Point(923, 111);
            this.CBBitter.Name = "CBBitter";
            this.CBBitter.Size = new System.Drawing.Size(181, 35);
            this.CBBitter.TabIndex = 88;
            // 
            // CBSTRONG
            // 
            this.CBSTRONG.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSTRONG.FormattingEnabled = true;
            this.CBSTRONG.Location = new System.Drawing.Point(923, 219);
            this.CBSTRONG.Name = "CBSTRONG";
            this.CBSTRONG.Size = new System.Drawing.Size(181, 35);
            this.CBSTRONG.TabIndex = 91;
            // 
            // CBFragrance
            // 
            this.CBFragrance.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBFragrance.FormattingEnabled = true;
            this.CBFragrance.Location = new System.Drawing.Point(923, 327);
            this.CBFragrance.Name = "CBFragrance";
            this.CBFragrance.Size = new System.Drawing.Size(181, 35);
            this.CBFragrance.TabIndex = 86;
            // 
            // CBSour
            // 
            this.CBSour.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSour.FormattingEnabled = true;
            this.CBSour.Location = new System.Drawing.Point(739, 435);
            this.CBSour.Name = "CBSour";
            this.CBSour.Size = new System.Drawing.Size(178, 35);
            this.CBSour.TabIndex = 101;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // CBTimeLimit
            // 
            this.CBTimeLimit.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBTimeLimit.FormattingEnabled = true;
            this.CBTimeLimit.Location = new System.Drawing.Point(187, 219);
            this.CBTimeLimit.Name = "CBTimeLimit";
            this.CBTimeLimit.Size = new System.Drawing.Size(178, 35);
            this.CBTimeLimit.TabIndex = 105;
            // 
            // TBimg
            // 
            this.TBimg.Location = new System.Drawing.Point(555, 3);
            this.TBimg.Name = "TBimg";
            this.TBimg.Size = new System.Drawing.Size(100, 22);
            this.TBimg.TabIndex = 106;
            this.TBimg.Visible = false;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ProdTabControl);
            this.Name = "ProductManagement";
            this.Size = new System.Drawing.Size(1127, 635);
            this.ProdTabControl.ResumeLayout(false);
            this.ProdGridTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataGridView)).EndInit();
            this.ProdDetailTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProdTabControl;
        private System.Windows.Forms.TabPage ProdGridTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTNselect;
        private System.Windows.Forms.TextBox TBselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNProdDetail;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.DataGridView ProdDataGridView;
        private System.Windows.Forms.TabPage ProdDetailTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TBFlavor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.TextBox TBUOM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBproductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBMethod;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BTNAddImage;
        private System.Windows.Forms.Button BTNPicDelete;
        private System.Windows.Forms.PictureBox PBProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNdescription;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox CBFilterValue;
        private System.Windows.Forms.ComboBox CBFilterColumn;
        private System.Windows.Forms.ComboBox CBSweet;
        private System.Windows.Forms.ComboBox CBBitter;
        private System.Windows.Forms.ComboBox CBFragrance;
        private System.Windows.Forms.ComboBox CBSTRONG;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CBSour;
        private System.Windows.Forms.Button BTNClearFilters;
        private System.Windows.Forms.ComboBox CBTimeLimit;
        private System.Windows.Forms.TextBox TBimg;
    }
}
