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

            //產品資料加載方法
            LoadProductData();

            // 設定雙擊單元格事件的處理函式
            ProdDataGridView.CellDoubleClick += ProdDataGridView_CellDoubleClick;


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
            CBImageSelect.Items.AddRange(new object[] { "ImgA", "ImgB", "ImgC", "ImgD" });
            CBImageSelect.SelectedIndexChanged += CBImageSelect_SelectedIndexChanged;

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
            TBFlavor.Text = selectedRow.Cells["Flavor"].Value?.ToString() ?? string.Empty;
            TBdescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty;

            // 設置 Timelimit 日期
            if (DateTime.TryParse(selectedRow.Cells["Timelimit"].Value?.ToString(), out DateTime timelimit))
            {
                DTPTimelimit.Value = timelimit;
            }
            else
            {
                ShowErrorMessage("無法轉換時間限制的值。");
            }

            // 設置 Method 和其他屬性分數 ComboBox
            CBMethod.SelectedItem = selectedRow.Cells["Method"].Value?.ToString() ?? string.Empty;
            CBFragrance.SelectedItem = selectedRow.Cells["Fragrance"].Value?.ToString() ?? string.Empty;
            CBSour.SelectedItem = selectedRow.Cells["Sour"].Value?.ToString() ?? string.Empty;
            CBBitter.SelectedItem = selectedRow.Cells["Bitter"].Value?.ToString() ?? string.Empty;
            CBSweet.SelectedItem = selectedRow.Cells["Sweet"].Value?.ToString() ?? string.Empty;
            CBSTRONG.SelectedItem = selectedRow.Cells["STRONG"].Value?.ToString() ?? string.Empty;


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

                // 重置圖片選擇
                CBImageSelect.SelectedIndex = 0;
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

                    // 更新圖片 URL
                    productToUpdate.ImgA = string.IsNullOrEmpty(TBImgAPath.Text) ? null : TBImgAPath.Text;
                    productToUpdate.ImgB = string.IsNullOrEmpty(TBImgBPath.Text) ? null : TBImgBPath.Text;
                    productToUpdate.ImgC = string.IsNullOrEmpty(TBImgCPath.Text) ? null : TBImgCPath.Text;
                    productToUpdate.ImgD = string.IsNullOrEmpty(TBImgDPath.Text) ? null : TBImgDPath.Text;

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
            product.Timelimit = DTPTimelimit.Value;
            product.Uom = TBUOM.Text;
            product.Description = TBdescription.Text;
            product.Category = CBcategory.SelectedItem?.ToString() ?? string.Empty;
            product.Country = CBCountry.SelectedItem?.ToString() ?? string.Empty;
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

            // 獲取圖片路徑
            newProduct.ImgA = string.IsNullOrEmpty(TBImgAPath.Text) ? null : TBImgAPath.Text;
            newProduct.ImgB = string.IsNullOrEmpty(TBImgBPath.Text) ? null : TBImgBPath.Text;
            newProduct.ImgC = string.IsNullOrEmpty(TBImgCPath.Text) ? null : TBImgCPath.Text;
            newProduct.ImgD = string.IsNullOrEmpty(TBImgDPath.Text) ? null : TBImgDPath.Text;

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
            if (string.IsNullOrWhiteSpace(product.Category))
                errorMessages.Add("請選擇一個分類。");
            if (string.IsNullOrWhiteSpace(product.Country))
                errorMessages.Add("請選擇一個國家。");
            if (string.IsNullOrWhiteSpace(product.Flavor))
                errorMessages.Add("風味不得為空。");
            if (string.IsNullOrWhiteSpace(product.Method))
                errorMessages.Add("請選擇處理方法。");
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
            if (product.Timelimit < DateTime.Now)
                errorMessages.Add("時間限制不能早於當前時間。");

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
                Timelimit = DTPTimelimit.Value,
                Uom = TBUOM.Text,
                Description = TBdescription.Text,
                Category = CBcategory.SelectedItem?.ToString() ?? string.Empty,
                Country = CBCountry.SelectedItem?.ToString() ?? string.Empty,
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
            // 先暫時取消 CBImageSelect 的 SelectedIndexChanged 事件
            CBImageSelect.SelectedIndexChanged -= CBImageSelect_SelectedIndexChanged;

            // 清除文字框和 ComboBox 的值
            TBproductID.Clear();        // 清空產品 ID
            TBname.Clear();             // 清空產品名稱
            TBprice.Clear();            // 清空價格
            TBdescription.Clear();      // 清空描述
            TBUOM.Clear();              // 清空單位
            TBFlavor.Clear();           // 清空風味
            CBcategory.SelectedIndex = -1; // 清除分類的選取
            CBCountry.SelectedIndex = -1;  // 清除國家的選取
            CBImageSelect.SelectedIndex = -1; // 清除圖片選取的選項
            pictureBox.Image = null;    // 清除圖片

            // 重新訂閱 CBImageSelect 的 SelectedIndexChanged 事件
            CBImageSelect.SelectedIndexChanged += CBImageSelect_SelectedIndexChanged;

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

        private void CBImageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 若有選擇的產品列，則顯示該列選擇的圖片
            if (ProdDataGridView.SelectedRows.Count > 0)
            {
                // 獲取當前選擇的圖片欄位（ImgA、ImgB、ImgC 或 ImgD）
                string selectedImageColumn = CBImageSelect.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedImageColumn))
                {
                    // 獲取選擇的產品行並提取圖片 URL
                    var selectedRow = ProdDataGridView.SelectedRows[0];
                    string imageUrl = selectedRow.Cells[selectedImageColumn].Value?.ToString() ?? string.Empty;

                    // 更新 PictureBox
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        try
                        {
                            pictureBox.Load(imageUrl);  // 加載圖片到 PictureBox
                        }
                        catch (Exception ex)
                        {
                            ShowErrorMessage("警告：無法載入圖片，請重新上傳\n" + ex.Message);
                        }
                    }
                    else
                    {
                        pictureBox.Image = null;  // 若圖片欄位為空，清空 PictureBox
                    }
                }
            }
            else
            {
                // 無選擇行時不顯示圖片，僅清空 PictureBox
                pictureBox.Image = null;
            }
        }

        private void BTNPicUpdate_Click(object sender, EventArgs e)
        {
            if (CBImageSelect.SelectedItem != null)
            {
                // 選取圖片欄位 (ImgA、ImgB、ImgC 或 ImgD)
                string selectedImageColumn = CBImageSelect.SelectedItem.ToString();

                // 開啟檔案選擇對話框，過濾為圖片檔案
                openFileDialog.Filter = "圖片檔案 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 暫存圖片路徑以供更新
                    string selectedImagePath = openFileDialog.FileName;
                    SetImagePathForSelectedColumn(selectedImageColumn, selectedImagePath);

                    // 預覽圖片至 PictureBox
                    pictureBox.Load(selectedImagePath);
                }
            }
            else
            {
                ShowErrorMessage("請先選擇圖片欄位。");
            }
        }

        private void SetImagePathForSelectedColumn(string selectedColumn, string imagePath)
        {
            switch (selectedColumn)
            {
                case "ImgA": TBImgAPath.Text = imagePath; break;
                case "ImgB": TBImgBPath.Text = imagePath; break;
                case "ImgC": TBImgCPath.Text = imagePath; break;
                case "ImgD": TBImgDPath.Text = imagePath; break;
            }
        }

        private void BTNPicDelete_Click(object sender, EventArgs e)
        {
            if (CBImageSelect.SelectedItem != null)
            {
                // 取得選定的圖片欄位
                string selectedImageColumn = CBImageSelect.SelectedItem.ToString();

                // 清空暫存的圖片路徑
                SetImagePathForSelectedColumn(selectedImageColumn, null);

                // 清空 PictureBox 顯示
                pictureBox.Image = null;
            }
            else
            {
                ShowErrorMessage("請先選擇圖片欄位。");
            }
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
    }
}
