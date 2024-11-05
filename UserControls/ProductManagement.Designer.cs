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
            this.ProdDetailTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TBImgBPath = new System.Windows.Forms.TextBox();
            this.TBFlavor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBdripbag = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBUOM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBproductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BTNPicUpdate = new System.Windows.Forms.Button();
            this.BTNPicDelete = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CBImageSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNdescription = new System.Windows.Forms.Button();
            this.BTNback = new System.Windows.Forms.Button();
            this.DTPTimelimit = new System.Windows.Forms.DateTimePicker();
            this.TBImgAPath = new System.Windows.Forms.TextBox();
            this.TBImgCPath = new System.Windows.Forms.TextBox();
            this.TBImgDPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProdTabControl.SuspendLayout();
            this.ProdGridTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataGridView)).BeginInit();
            this.ProdDetailTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.TBImgBPath, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.TBFlavor, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.CBdripbag, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.label18, 4, 8);
            this.tableLayoutPanel2.Controls.Add(this.CBCountry, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.CBcategory, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBUOM, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TBproductID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnUpdate, 4, 10);
            this.tableLayoutPanel2.Controls.Add(this.BTNPicUpdate, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.BTNPicDelete, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.CBImageSelect, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBprice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.TBdescription, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.TBname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTNdescription, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.BTNback, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.DTPTimelimit, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TBImgAPath, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.TBImgCPath, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.TBImgDPath, 3, 8);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 597);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TBImgBPath
            // 
            this.TBImgBPath.Location = new System.Drawing.Point(445, 489);
            this.TBImgBPath.Name = "TBImgBPath";
            this.TBImgBPath.Size = new System.Drawing.Size(100, 22);
            this.TBImgBPath.TabIndex = 82;
            this.TBImgBPath.Visible = false;
            // 
            // TBFlavor
            // 
            this.TBFlavor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBFlavor.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBFlavor.Location = new System.Drawing.Point(224, 273);
            this.TBFlavor.Name = "TBFlavor";
            this.TBFlavor.Size = new System.Drawing.Size(215, 40);
            this.TBFlavor.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(3, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 54);
            this.label15.TabIndex = 78;
            this.label15.Text = "風味：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBdripbag
            // 
            this.CBdripbag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBdripbag.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBdripbag.FormattingEnabled = true;
            this.CBdripbag.Location = new System.Drawing.Point(887, 489);
            this.CBdripbag.Name = "CBdripbag";
            this.CBdripbag.Size = new System.Drawing.Size(217, 35);
            this.CBdripbag.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(887, 432);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 54);
            this.label18.TabIndex = 69;
            this.label18.Text = "是否耳掛";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBCountry
            // 
            this.CBCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBCountry.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(887, 273);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(217, 35);
            this.CBCountry.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(887, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 54);
            this.label9.TabIndex = 52;
            this.label9.Text = "產地";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBcategory
            // 
            this.CBcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBcategory.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Location = new System.Drawing.Point(887, 165);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(217, 35);
            this.CBcategory.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(887, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 54);
            this.label6.TabIndex = 50;
            this.label6.Text = "商品類別";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBUOM
            // 
            this.TBUOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUOM.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBUOM.Location = new System.Drawing.Point(224, 165);
            this.TBUOM.Name = "TBUOM";
            this.TBUOM.Size = new System.Drawing.Size(215, 40);
            this.TBUOM.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 54);
            this.label11.TabIndex = 47;
            this.label11.Text = "UOM：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBproductID
            // 
            this.TBproductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBproductID.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBproductID.Location = new System.Drawing.Point(224, 57);
            this.TBproductID.Name = "TBproductID";
            this.TBproductID.Size = new System.Drawing.Size(215, 40);
            this.TBproductID.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(3, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 54);
            this.label10.TabIndex = 43;
            this.label10.Text = "產品編號：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(887, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 54);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品狀態";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(887, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 35);
            this.comboBox2.TabIndex = 21;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnUpdate.Location = new System.Drawing.Point(887, 543);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(217, 51);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "確認修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BTNPicUpdate
            // 
            this.BTNPicUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNPicUpdate.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNPicUpdate.Location = new System.Drawing.Point(666, 381);
            this.BTNPicUpdate.Name = "BTNPicUpdate";
            this.BTNPicUpdate.Size = new System.Drawing.Size(215, 48);
            this.BTNPicUpdate.TabIndex = 25;
            this.BTNPicUpdate.Text = "新增照片";
            this.BTNPicUpdate.UseVisualStyleBackColor = true;
            this.BTNPicUpdate.Click += new System.EventHandler(this.BTNPicUpdate_Click);
            // 
            // BTNPicDelete
            // 
            this.BTNPicDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNPicDelete.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNPicDelete.Location = new System.Drawing.Point(445, 381);
            this.BTNPicDelete.Name = "BTNPicDelete";
            this.BTNPicDelete.Size = new System.Drawing.Size(215, 48);
            this.BTNPicDelete.TabIndex = 24;
            this.BTNPicDelete.Text = "取消暫存";
            this.BTNPicDelete.UseVisualStyleBackColor = true;
            this.BTNPicDelete.Click += new System.EventHandler(this.BTNPicDelete_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.SetColumnSpan(this.pictureBox, 2);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(445, 57);
            this.pictureBox.Name = "pictureBox";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox, 6);
            this.pictureBox.Size = new System.Drawing.Size(436, 318);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // CBImageSelect
            // 
            this.CBImageSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBImageSelect.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBImageSelect.FormattingEnabled = true;
            this.CBImageSelect.Location = new System.Drawing.Point(666, 3);
            this.CBImageSelect.Name = "CBImageSelect";
            this.CBImageSelect.Size = new System.Drawing.Size(215, 35);
            this.CBImageSelect.TabIndex = 23;
            this.CBImageSelect.Text = "當前照片頁面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(445, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 54);
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
            this.label4.Size = new System.Drawing.Size(215, 54);
            this.label4.TabIndex = 29;
            this.label4.Text = "價格：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBprice
            // 
            this.TBprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBprice.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBprice.Location = new System.Drawing.Point(224, 111);
            this.TBprice.Name = "TBprice";
            this.TBprice.Size = new System.Drawing.Size(215, 40);
            this.TBprice.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 54);
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
            this.label8.Size = new System.Drawing.Size(215, 54);
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
            this.TBdescription.Size = new System.Drawing.Size(436, 156);
            this.TBdescription.TabIndex = 39;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDelete.Location = new System.Drawing.Point(666, 543);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(215, 51);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "刪除商品";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TBname
            // 
            this.TBname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBname.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBname.Location = new System.Drawing.Point(224, 3);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(215, 40);
            this.TBname.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 54);
            this.label3.TabIndex = 27;
            this.label3.Text = "商品名稱：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNdescription
            // 
            this.BTNdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNdescription.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNdescription.Location = new System.Drawing.Point(224, 543);
            this.BTNdescription.Name = "BTNdescription";
            this.BTNdescription.Size = new System.Drawing.Size(215, 51);
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
            this.BTNback.Size = new System.Drawing.Size(215, 51);
            this.BTNback.TabIndex = 42;
            this.BTNback.Text = "回上頁/取消";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // DTPTimelimit
            // 
            this.DTPTimelimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPTimelimit.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTPTimelimit.Location = new System.Drawing.Point(224, 219);
            this.DTPTimelimit.Name = "DTPTimelimit";
            this.DTPTimelimit.Size = new System.Drawing.Size(215, 40);
            this.DTPTimelimit.TabIndex = 80;
            // 
            // TBImgAPath
            // 
            this.TBImgAPath.Location = new System.Drawing.Point(445, 435);
            this.TBImgAPath.Name = "TBImgAPath";
            this.TBImgAPath.Size = new System.Drawing.Size(100, 22);
            this.TBImgAPath.TabIndex = 81;
            this.TBImgAPath.Visible = false;
            // 
            // TBImgCPath
            // 
            this.TBImgCPath.Location = new System.Drawing.Point(445, 543);
            this.TBImgCPath.Name = "TBImgCPath";
            this.TBImgCPath.Size = new System.Drawing.Size(100, 22);
            this.TBImgCPath.TabIndex = 83;
            this.TBImgCPath.Visible = false;
            // 
            // TBImgDPath
            // 
            this.TBImgDPath.Location = new System.Drawing.Point(666, 435);
            this.TBImgDPath.Name = "TBImgDPath";
            this.TBImgDPath.Size = new System.Drawing.Size(100, 22);
            this.TBImgDPath.TabIndex = 84;
            this.TBImgDPath.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox TBImgBPath;
        private System.Windows.Forms.TextBox TBFlavor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBdripbag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBUOM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBproductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BTNPicUpdate;
        private System.Windows.Forms.Button BTNPicDelete;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox CBImageSelect;
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
        private System.Windows.Forms.DateTimePicker DTPTimelimit;
        private System.Windows.Forms.TextBox TBImgAPath;
        private System.Windows.Forms.TextBox TBImgCPath;
        private System.Windows.Forms.TextBox TBImgDPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox CBFilterValue;
        private System.Windows.Forms.ComboBox CBFilterColumn;
    }
}
