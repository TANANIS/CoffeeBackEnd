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
            CBFilterColumn.Items.AddRange(new string[] { "Category", "Country", "Price", "Flavor" });
            CBFilterValue.SelectedIndexChanged += CBFilterValue_SelectedIndexChanged;

            // 向國家下拉選單中添加選項
            CBCountry.Items.AddRange(new object[] { "衣索比亞", "巴西", "哥倫比亞", "瓜地馬拉", "肯亞" });
            // 向類別下拉選單中添加選項
            CBcategory.Items.AddRange(new object[] { "咖啡豆", "濾掛咖啡" });
            // 向圖片選擇下拉選單中添加選項
            CBImageSelect.Items.AddRange(new object[] { "ImgA", "ImgB", "ImgC", "ImgD" });
            // 設定圖片選擇下拉選單的變更事件處理函式
            CBImageSelect.SelectedIndexChanged += CBImageSelect_SelectedIndexChanged;

            // 向滴包下拉選單中添加選項
            CBdripbag.DisplayMember = "Text";
            CBdripbag.ValueMember = "Value";
            CBdripbag.DataSource = new List<object> {
        new { Text = "耳掛", Value = true },
        new { Text = "非耳掛", Value = false }
    };
        }

        // 載入產品資料的私有方法都放這裡
        private void LoadProductData()
        {
            try
            {
                // 清空現有的資料來源
                ProdDataGridView.DataSource = null; // 清空資料網格的資料來源

                // 從資料庫中獲取所有產品資料並轉換為列表
                var products = context.PRODUCTs.ToList();

                // 將產品資料綁定到資料網格中
                ProdDataGridView.DataSource = products;
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
            CBcategory.SelectedItem = selectedRow.Cells["Category"].Value;
            CBCountry.SelectedItem = selectedRow.Cells["Country"].Value?.ToString() ?? string.Empty;
            TBFlavor.Text = selectedRow.Cells["Flavor"].Value?.ToString() ?? string.Empty;

            TBdescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty; // 假設 "Description" 是對應的欄位名
            CBdripbag.SelectedValue = selectedRow.Cells["Dripbag"].Value; // 假設 "Dripbag" 是對應的欄位名，並且是 bool 值


            if (DateTime.TryParse(selectedRow.Cells["Timelimit"].Value?.ToString(), out DateTime timelimit))
            {
                DTPTimelimit.Value = timelimit;
            }
            else
            {
                ShowErrorMessage("無法轉換時間限制的值。");
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

            if (CBdripbag.SelectedItem != null)
            {
                product.Dripbag = ((dynamic)CBdripbag.SelectedItem).Value;
            }
            else
            {
                ShowErrorMessage("請選擇耳掛或非耳掛選項。");
            }

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

            if (CBdripbag.SelectedItem != null)
            {
                var selectedDripbag = (dynamic)CBdripbag.SelectedItem;
                dripbagValue = selectedDripbag.Value;
            }
            else
            {
                ShowErrorMessage("請選擇耳掛或非耳掛選項。");
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
                Category = CBcategory.SelectedItem.ToString(),
                Country = CBCountry.SelectedItem.ToString(),
                Flavor = TBFlavor.Text.ToString(),
                Dripbag = dripbagValue,
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
            TBproductID.Clear();

            TBname.Clear();
            TBprice.Clear();
            TBdescription.Clear();
            TBUOM.Clear();
            TBFlavor.Clear();
            CBcategory.SelectedIndex = -1;
            CBCountry.SelectedIndex = -1;
            CBdripbag.SelectedIndex = -1;
            CBImageSelect.SelectedIndex = -1; // 清除 CBImageSelect 的選取項目
            pictureBox.Image = null;

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
                    case "Category":
                        CBFilterValue.DataSource = context.PRODUCTs
                            .Select(p => p.Category).Distinct().ToList();
                        break;
                    case "Country":
                        CBFilterValue.DataSource = context.PRODUCTs
                            .Select(p => p.Country).Distinct().ToList();
                        break;
                    case "Price":
                        CBFilterValue.DataSource = null; // 讓使用者自行輸入數字
                        CBFilterValue.DropDownStyle = ComboBoxStyle.DropDown; // 讓價格欄位可以手動輸入
                        break;
                    case "Flavor":
                        CBFilterValue.DataSource = context.PRODUCTs
                            .Select(p => p.Flavor).Distinct().ToList();
                        CBFilterValue.DropDownStyle = ComboBoxStyle.DropDownList; // 僅限選擇
                        break;
                    default:
                        CBFilterValue.DataSource = null;
                        break;
                }
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
                    case "Category":
                        query = query.Where(p => p.Category == selectedValue);
                        break;
                    case "Country":
                        query = query.Where(p => p.Country == selectedValue);
                        break;
                    case "Price":
                        if (decimal.TryParse(selectedValue, out var price))
                        {
                            query = query.Where(p => p.Price == price);
                        }
                        else
                        {
                            ShowErrorMessage("請選擇或輸入有效的價格數字。");
                            return;
                        }
                        break;
                    case "Flavor":
                        query = query.Where(p => p.Flavor == selectedValue);
                        break;
                    default:
                        break;
                }

                // 將篩選結果更新至 DataGridView
                ProdDataGridView.DataSource = query.ToList();
            }
        }
    }
}
