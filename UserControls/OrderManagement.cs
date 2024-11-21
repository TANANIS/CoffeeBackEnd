using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeBackEnd20221026.UserControls
{
    public partial class OrderManagement : UserControl
    {

        //宣告資料庫
        private ProductionEntities context = new ProductionEntities();

        //宣告此處bindingSource
        private BindingSource bindingSource = new BindingSource();

        public string Username { get; set; }

        public OrderManagement()
        {
            InitializeComponent();

            //產品資料加載方法
            LoadOrderData();

            // 設定雙擊單元格事件的處理函式
            OrdDataGridView.CellDoubleClick += OrdDataGridView_CellDoubleClick;

        }

        private void LoadOrderData()
        {
            try
            {
                using (var context = new ProductionEntities())
                {
                    // 清空現有的資料來源
                    OrdDataGridView.DataSource = null; // 清空資料網格的資料來源

                    // 從資料庫中獲取所有產品資料並轉換為列表
                    var Orderata = context.ORDERHEADERs.ToList();

                    // 將資料綁定到資料網格中
                   OrdDataGridView.DataSource = Orderata;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"無法載入資料：{ex.Message}"); // 顯示錯誤訊息
            }
        }

        // 顯示錯誤訊息的私有方法
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNOrdDetail_Click(object sender, EventArgs e)
        { }

        private void OrdDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdDataGridView.SelectedRows.Count > 0) {
                MessageBox.Show("請按兩下訂單欄目以查看詳細資訊。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedRow = OrdDataGridView.SelectedRows[0];
            var orderId = (int)selectedRow.Cells["OrderId"].Value; // 確認欄位名稱為 OrderId

            // 切換到第二頁並載入訂單詳細資料
            LoadOrderDetails(orderId);
            tabControl.SelectedTab = tabControl.TabPages["OrderDetailTab"]; // 切換到第二頁的 Tab


        }

        // 載入訂單詳細資料的方法
        private void LoadOrderDetails(int orderId)
        {
            try
            {
                using (var context = new ProductionEntities())
                {
                    // 將 orderId 轉為字串進行比對
                    string orderIdString = orderId.ToString();

                    // 查詢符合 OrderId 的訂單詳細資料
                    var orderDetails = context.ORDERDETAILs
                        .Where(detail => detail.OrderId == orderIdString)
                        .ToList();

                    // 綁定資料到第二頁的 DataGridView
                    OrderDetailDataGridView.DataSource = orderDetails;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"無法載入訂單詳細資料：{ex.Message}");
            }
        }

    }
}
