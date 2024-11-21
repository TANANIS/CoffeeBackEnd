using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CoffeeBackEnd20221026.UserControls
{
    public partial class ProductManagement : UserControl
    {
        //宣告資料庫
        private ProductionEntities context = new ProductionEntities();

        //宣告此處bindingSource
        private BindingSource bindingSource = new BindingSource();

        //儲存使用者名稱
        public string Username { get; set; }

        public ProductManagement()
        {
            //預設的Component初始化
            InitializeComponent();

            // 初始化下拉選單
            InitializeDropdowns();

            InitializePictureBox();

            //產品資料加載方法
            LoadProductData();

            // 設定雙擊單元格事件的處理函式
            ProdDataGridView.CellDoubleClick += ProdDataGridView_CellDoubleClick;


        }

        private void InitializePictureBox()
        {
            // 設定 PictureBox 屬性
            PBProduct.SizeMode = PictureBoxSizeMode.Zoom; // 讓圖片適應大小
            PBProduct.BorderStyle = BorderStyle.FixedSingle;
            PBProduct.BackColor = Color.White; // 可選，設定背景色
        }

        // 初始化下拉選單
        private void InitializeDropdowns()
        {
            // 更新下拉選單項目，包括所有分類
            // 初始化下拉選單項目，顯示中文欄位名稱
            CBFilterColumn.Items.AddRange(new string[] { "類別", "國家", "風味", "製作方法", "甜度", "濃郁度", "香氣", "酸度", "苦度" });

            // 綁定事件
            CBFilterColumn.SelectedIndexChanged += CBFilterColumn_SelectedIndexChanged;
            CBFilterValue.SelectedIndexChanged += CBFilterValue_SelectedIndexChanged;

            BTNClearFilters.Click += BTNClearFilters_Click;
            CBCountry.Items.AddRange(new object[] { "衣索比亞", "巴西", "哥倫比亞", "瓜地馬拉", "肯亞" });
            CBcategory.Items.AddRange(new object[] { "咖啡豆", "濾掛咖啡" });
            CBTimeLimit.Items.AddRange(new string[] { "12個月","18個月","24個月"});


            // 評分範圍 1-5 分的選項，用於 Fragrance、Sour、Bitter、Sweet、STRONG
            var scoreOptions = Enumerable.Range(1, 5).Select(x => x.ToString()).ToArray();
            CBFragrance.Items.AddRange(scoreOptions);
            CBSour.Items.AddRange(scoreOptions);
            CBBitter.Items.AddRange(scoreOptions);
            CBSweet.Items.AddRange(scoreOptions);
            CBSTRONG.Items.AddRange(scoreOptions);

            // Method選項
            CBMethod.Items.AddRange(new string[] { "水洗", "日曬", "蜜處理" });
        }

        // 載入產品資料的私有方法都放這裡
        private void LoadProductData()
        {
            try
            {
                using (var context = new ProductionEntities())
                {
                    // 清空現有的資料來源
                    ProdDataGridView.DataSource = null; // 清空資料網格的資料來源

                    // 從資料庫中獲取所有產品資料並轉換為列表
                    var products = context.PRODUCTs.ToList();

                    // 將產品資料綁定到資料網格中
                    ProdDataGridView.DataSource = products;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"無法載入產品資料：{ex.Message}"); // 顯示錯誤訊息
            }
        }

        // 顯示錯誤訊息的私有方法
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        ////////////////////////////////////////////////////////////////////
        //切換到產品詳細資訊的選項卡
        private void BTNProdDetail_Click(object sender, EventArgs e)
        {
            //預設未選擇的提示
            if (ProdDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("請按兩下產品欄目以查看詳細資訊。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //獲取欄位的資訊
            var selectedRow = ProdDataGridView.SelectedRows[0];

            // 設置產品詳細資訊
            TBproductID.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? string.Empty;
            TBname.Text = selectedRow.Cells["ProductName"].Value?.ToString() ?? string.Empty;
            TBprice.Text = selectedRow.Cells["Price"].Value?.ToString() ?? string.Empty;
            TBUOM.Text = selectedRow.Cells["Uom"].Value?.ToString() ?? string.Empty;
            CBcategory.SelectedItem = selectedRow.Cells["Category"].Value?.ToString() ?? string.Empty;
            CBCountry.SelectedItem = selectedRow.Cells["Country"].Value?.ToString() ?? string.Empty;
            CBTimeLimit.SelectedItem = selectedRow.Cells["Timelimit"].Value.ToString() ?? string.Empty;
            TBFlavor.Text = selectedRow.Cells["Flavor"].Value?.ToString() ?? string.Empty;
            TBdescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty;


            // 設置 Method 和其他屬性分數 ComboBox
            CBMethod.SelectedItem = selectedRow.Cells["Method"].Value?.ToString() ?? string.Empty;
            CBFragrance.SelectedItem = selectedRow.Cells["Fragrance"].Value?.ToString() ?? string.Empty;
            CBSour.SelectedItem = selectedRow.Cells["Sour"].Value?.ToString() ?? string.Empty;
            CBBitter.SelectedItem = selectedRow.Cells["Bitter"].Value?.ToString() ?? string.Empty;
            CBSweet.SelectedItem = selectedRow.Cells["Sweet"].Value?.ToString() ?? string.Empty;
            CBSTRONG.SelectedItem = selectedRow.Cells["STRONG"].Value?.ToString() ?? string.Empty;

            // 顯示產品圖片
            var productImgPath = selectedRow.Cells["Img"].Value?.ToString();
            if (!string.IsNullOrEmpty(productImgPath) && File.Exists(productImgPath))
            {
                PBProduct.Image = Image.FromFile(productImgPath); // 從檔案載入圖片
            }
            else
            {
                PBProduct.Image = null; // 如果圖片不存在，顯示空
                MessageBox.Show("該產品圖片不存在或無效！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 提示圖片無效
            }


            ProdTabControl.SelectedTab = ProdDetailTabPage; //切換頁面
        }

        //按兩下TABLE進入詳情
        private void ProdDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保選取的行有效
            if (e.RowIndex >= 0)
            {
                // 選中行並顯示詳細資訊
                ProdDataGridView.Rows[e.RowIndex].Selected = true;
                BTNProdDetail_Click(sender, e);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ProdDataGridView.SelectedRows.Count > 0)
            {
                UpdateProduct();
            }
            else
            {
                AddProduct();
            }
            LoadProductData();
            ProdTabControl.SelectedTab = ProdGridTabPage;
        }

        // 新增產品的判斷式(處理新增產品的事件)
        private void UpdateProduct()
        {
            if (ProdDataGridView.SelectedRows.Count == 0)
            {
                ShowErrorMessage("請選擇一個產品進行更新。");
                return;
            }

            var selectedRow = ProdDataGridView.SelectedRows[0];
            string productId = selectedRow.Cells["ProductID"].Value.ToString();

            using (ProductionEntities context = new ProductionEntities())
            {
                var productToUpdate = context.PRODUCTs.Find(productId);
                if (productToUpdate != null)
                {
                    UpdateProductFields(productToUpdate);

                    SaveProductChanges(context);
                }
                else
                {
                    ShowErrorMessage("找不到該產品！");
                }
            }
            LoadProductData();
        }

        // 新增產品的EDM物件
        private void UpdateProductFields(PRODUCT product)
        {
            product.ProductName = TBname.Text;
            product.Price = Convert.ToInt16(TBprice.Text);
            product.Img = TBimg.Text;

            product.Uom = TBUOM.Text;
            product.Description = TBdescription.Text;
            product.Category = CBcategory.SelectedItem?.ToString() ?? string.Empty;
            product.Country = CBCountry.SelectedItem?.ToString() ?? string.Empty;
            product.Timelimit = CBTimeLimit.SelectedItem?.ToString() ?? string.Empty;
            product.Flavor = TBFlavor.Text;
            product.Method = CBMethod.SelectedItem?.ToString() ?? string.Empty; // 新增方法
            product.Fragrance = Convert.ToByte(CBFragrance.SelectedItem ?? 0); // 香氣
            product.Sour = Convert.ToByte(CBSour.SelectedItem ?? 0); // 酸味
            product.Bitter = Convert.ToByte(CBBitter.SelectedItem ?? 0); // 苦味
            product.Sweet = Convert.ToByte(CBSweet.SelectedItem ?? 0); // 甜味
            product.STRONG = Convert.ToByte(CBSTRONG.SelectedItem ?? 0); // 厚實
            product.UpdateUser = Username;
            product.UpdateDate = DateTime.Now;
        }

        //儲存產品的變更(判斷式)
        private void SaveProductChanges(ProductionEntities context)
        {
            try
            {
                context.SaveChanges();
                MessageBox.Show("產品資訊更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                LoadProductData();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"錯誤：{validationError.PropertyName} - {validationError.ErrorMessage}", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddProduct()
        {
            // 驗證產品輸入
            if (!ValidateProductInput(out var price, out var dripbagValue))
                return;

            // 創建新產品實例
            var newProduct = CreateProduct(price, dripbagValue);

            // 驗證產品資料
            string validationMessage = ValidateNewProduct(newProduct, price);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ProductionEntities context = new ProductionEntities())
            {
                context.PRODUCTs.Add(newProduct);
                context.SaveChanges();
                MessageBox.Show("新產品新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                LoadProductData();
            }
        }

        private string ValidateNewProduct(PRODUCT product, int price)
        {
            var errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(product.ProductName))
                errorMessages.Add("產品名稱不得為空。");
            if (price <= 0)
                errorMessages.Add("價格必須是有效的數字且大於0。");
            if (string.IsNullOrWhiteSpace(product.Uom))
                errorMessages.Add("單位不得為空。");
            if (string.IsNullOrWhiteSpace(product.Img))
                errorMessages.Add("照片不得為空。");
            if (string.IsNullOrWhiteSpace(product.Category))
                errorMessages.Add("請選擇一個分類。");
            if (string.IsNullOrWhiteSpace(product.Country))
                errorMessages.Add("請選擇一個國家。");
            if (string.IsNullOrWhiteSpace(product.Flavor))
                errorMessages.Add("風味不得為空。");
            if (string.IsNullOrWhiteSpace(product.Method))
                errorMessages.Add("請選擇處理方法。");
            if(string.IsNullOrWhiteSpace(product.Timelimit))
                errorMessages.Add("請選擇保存期限。");
            if (product.Fragrance < 0 || product.Fragrance > 5)
                errorMessages.Add("香氣值必須在 0 到 5 之間。");
            if (product.Sour < 0 || product.Sour > 5)
                errorMessages.Add("酸味值必須在 0 到 5 之間。");
            if (product.Bitter < 0 || product.Bitter > 5)
                errorMessages.Add("苦味值必須在 0 到 5 之間。");
            if (product.Sweet < 0 || product.Sweet > 5)
                errorMessages.Add("甜味值必須在 0 到 5 之間。");
            if (product.STRONG < 0 || product.STRONG > 5)
                errorMessages.Add("厚實值必須在 0 到 5 之間。");
          
        

            return string.Join("\n", errorMessages);
        }

        // 驗證輸入欄位的警告訊息
        private bool ValidateProductInput(out int price, out bool dripbagValue)
        {
            dripbagValue = false;
            if (!int.TryParse(TBprice.Text, out price) || price < short.MinValue || price > short.MaxValue)
            {
                ShowErrorMessage("價格必須是有效的整數，並且在 -32,768 到 32,767 之間！");
                return false;
            }

            return true;
        }

        // 建立產品的EDM物件(新產品)
        private PRODUCT CreateProduct(int price, bool dripbagValue)
        {
            return new PRODUCT
            {
                ProductID = TBproductID.Text,
                ProductName = TBname.Text,
                Price = Convert.ToInt16(price),

                Img = TBimg.Text,
                Uom = TBUOM.Text,
                Description = TBdescription.Text,
                Category = CBcategory.SelectedItem?.ToString() ?? string.Empty,
                Country = CBCountry.SelectedItem?.ToString() ?? string.Empty,
                Timelimit = CBTimeLimit.SelectedItem?.ToString() ?? string.Empty,
                Flavor = TBFlavor.Text,
                Method = CBMethod.SelectedItem?.ToString() ?? string.Empty,
                Fragrance = Convert.ToByte(CBFragrance.SelectedItem ?? 0), // 明確轉型為 byte
                Sour = Convert.ToByte(CBSour.SelectedItem ?? 0), // 明確轉型為 byte
                Bitter = Convert.ToByte(CBBitter.SelectedItem ?? 0), // 明確轉型為 byte
                Sweet = Convert.ToByte(CBSweet.SelectedItem ?? 0), // 明確轉型為 byte
                STRONG = Convert.ToByte(CBSTRONG.SelectedItem ?? 0), // 明確轉型為 byte
                CreateUser = Username,
                CreateDate = DateTime.Now,
                UpdateUser = Username,
                UpdateDate = DateTime.Now
            };
        }

        // 用於處理錯誤
        private void HandleValidationErrors(DbEntityValidationException ex)
        {
            foreach (var validationErrors in ex.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    ShowErrorMessage($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                }
            }
        }

        // 刪除產品的判斷式
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ProdDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ProdDataGridView.SelectedRows[0];
                string productId = selectedRow.Cells["ProductID"].Value.ToString(); // 轉為字串

                using (ProductionEntities context = new ProductionEntities())
                {
                    // 根據字串型別查詢
                    var productToDelete = context.PRODUCTs.SingleOrDefault(p => p.ProductID == productId);
                    if (productToDelete != null)
                    {
                        context.PRODUCTs.Remove(productToDelete);
                        context.SaveChanges();
                        MessageBox.Show("產品已成功刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadProductData(); // 重整資料
                    }
                    else
                    {
                        MessageBox.Show("找不到該產品！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇一個產品以刪除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearTextBoxes();
            ProdTabControl.SelectedTab = ProdDetailTabPage;
        }

        //重製欄位
        public void ClearTextBoxes()
        {
            // 清除文字框和 ComboBox 的值
            TBproductID.Clear();        // 清空產品 ID
            TBname.Clear();             // 清空產品名稱
            TBprice.Clear();            // 清空價格
            TBdescription.Clear();      // 清空描述
            TBUOM.Clear();              // 清空單位
            TBFlavor.Clear();           // 清空風味
            TBimg.Clear();
            CBcategory.SelectedIndex = -1; // 清除分類的選取
            CBCountry.SelectedIndex = -1;  // 清除國家的選取
            CBTimeLimit.SelectedItem = -1;
            PBProduct.Image = null;    // 清除圖片
            // 更新產品資料以確保最新狀態
            LoadProductData();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // 清空文本框
            ClearTextBoxes();
            ProdTabControl.SelectedTab = ProdDetailTabPage;
            ProdDataGridView.ClearSelection();
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ProdTabControl.SelectedTab = ProdGridTabPage;
        }

        private void ProdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNdescription_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "載入描述文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        TBdescription.Text = fileContent; // 將內容載入到 TBdescription
                    }
                    catch (Exception ex)
                    {
                        ShowErrorMessage($"無法載入文件：{ex.Message}"); // 顯示錯誤訊息
                    }
                }
            }
        }

        private void BTNAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";  // 限制文件範圍為常見的圖片格式
                openFileDialog.Title = "載入產品圖片";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName; // 獲取選擇的圖片路徑
                    try
                    {
                        // 將圖片的路徑儲存到 TBimg TextBox
                        TBimg.Text = imagePath;

                        // 預覽圖片於 PictureBox 上
                        PBProduct.Image = Image.FromFile(imagePath); // 讀取並顯示圖片
                        PBProduct.SizeMode = PictureBoxSizeMode.StretchImage; // 可以選擇圖片如何適應顯示區域
                    }
                    catch (Exception ex)
                    {
                        ShowErrorMessage($"無法載入圖片：{ex.Message}"); // 顯示錯誤訊息
                    }
                }
            }
        }



        private void BTNselect_Click(object sender, EventArgs e)
        {
            string keyword = TBselect.Text.Trim(); // 取得關鍵字並去除空白
            if (string.IsNullOrEmpty(keyword))
            {
                LoadProductData(); // 若無關鍵字，顯示所有產品
                return;
            }

            using (ProductionEntities context = new ProductionEntities())
            {
                var filteredProducts = context.PRODUCTs
                    .Where(p => p.ProductName.Contains(keyword)) // 搜尋符合的 ProductName
                    .ToList();

                if (filteredProducts.Any())
                {
                    ProdDataGridView.DataSource = filteredProducts;
                }
                else
                {
                    ShowErrorMessage("找不到符合的產品。");
                    ProdDataGridView.DataSource = null;
                }
            }
        }

        private void CBFilterColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = CBFilterColumn.SelectedItem?.ToString();

            using (ProductionEntities context = new ProductionEntities())
            {
                switch (selectedColumn)
                {
                    case "類別":
                        CBFilterValue.DataSource = context.PRODUCTs.Select(p => p.Category).Distinct().ToList();
                        break;
                    case "國家":
                        CBFilterValue.DataSource = context.PRODUCTs.Select(p => p.Country).Distinct().ToList();
                        break;
                    case "風味":
                        CBFilterValue.DataSource = context.PRODUCTs.Select(p => p.Flavor).Distinct().ToList();
                        break;
                    case "製作方法":
                        CBFilterValue.DataSource = context.PRODUCTs.Select(p => p.Method).Distinct().ToList();
                        break;
                    case "保存期限":
                        CBFilterValue.DataSource = context.PRODUCTs.Select(p => p.Timelimit).Distinct().ToList();
                        break;
                    case "甜度":
                    case "濃郁度":
                    case "香氣":
                    case "酸度":
                    case "苦度":
                        CBFilterValue.DataSource = new List<string> { "0", "1", "2", "3", "4", "5" }; // 假設篩選值為 0 到 5
                        break;
                    default:
                        CBFilterValue.DataSource = null;
                        break;
                }

                // 更新下拉選單樣式
                CBFilterValue.DropDownStyle = ComboBoxStyle.DropDownList; // 僅限選擇
            }
        }

        private void CBFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認主要篩選欄位及其選定的值
            string selectedColumn = CBFilterColumn.SelectedItem?.ToString();
            string selectedValue = CBFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumn) || string.IsNullOrEmpty(selectedValue))
            {
                // 若無選定欄位或篩選值則不進行查詢
                return;
            }

            using (ProductionEntities context = new ProductionEntities())
            {
                var query = context.PRODUCTs.AsQueryable();

                // 根據選擇的欄位篩選資料
                switch (selectedColumn)
                {
                    case "類別":
                        query = query.Where(p => p.Category == selectedValue);
                        break;
                    case "國家":
                        query = query.Where(p => p.Country == selectedValue);
                        break;
                    case "風味":
                        query = query.Where(p => p.Flavor == selectedValue);
                        break;
                    case "製作方法":
                        query = query.Where(p => p.Method == selectedValue);
                        break;
                    case "保存期限":
                        query = query.Where(p => p.Timelimit == selectedValue);
                        break;
                    case "甜度":
                        if (byte.TryParse(selectedValue, out var sweetValue))
                        {
                            query = query.Where(p => p.Sweet == sweetValue);
                        }
                        break;
                    case "濃郁度":
                        if (byte.TryParse(selectedValue, out var strongValue))
                        {
                            query = query.Where(p => p.STRONG == strongValue);
                        }
                        break;
                    case "香氣":
                        if (byte.TryParse(selectedValue, out var fragranceValue))
                        {
                            query = query.Where(p => p.Fragrance == fragranceValue);
                        }
                        break;
                    case "酸度":
                        if (byte.TryParse(selectedValue, out var sourValue))
                        {
                            query = query.Where(p => p.Sour == sourValue);
                        }
                        break;
                    case "苦度":
                        if (byte.TryParse(selectedValue, out var bitterValue))
                        {
                            query = query.Where(p => p.Bitter == bitterValue);
                        }
                        break;
                    default:
                        break;
                }

                // 將篩選結果更新至 DataGridView
                ProdDataGridView.DataSource = query.ToList();

            }
        }

        private void BTNClearFilters_Click(object sender, EventArgs e)
        {
            // 清空篩選下拉選單
            CBFilterColumn.SelectedIndex = -1; // 重置主要篩選欄位
            CBFilterValue.DataSource = null; // 清空篩選值

            // 清除搜尋框的內容
            TBselect.Clear();

            // 重新載入所有產品資料
            LoadProductData();
        }

        private void BTNPicDelete_Click(object sender, EventArgs e)
        {
            // 清空 TBimg 路徑欄位
            TBimg.Clear(); 
            PBProduct.Image = null; // 清除圖片

            PBProduct.SizeMode = PictureBoxSizeMode.CenterImage;
        }

    }
}
