using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using CoffeeBackEnd20221026.UserControls;

namespace CoffeeBackEnd20221026
{
    public partial class FrmMain : Form
    {
        private AccountManagement accountManagement;
        private ProductManagement productManagement;
        private MemberManagement memberManagement;
        private OrderManagement orderManagement;
        //要找要去UserControls資料夾找，Main不負責

        public FrmMain(string username = "")
        {
            InitializeComponent();

            // 初始化每個管理頁面
            accountManagement = new AccountManagement();
            accountManagement.Username = username; 

            productManagement = new ProductManagement();
            productManagement.Username = username; // 傳入使用者名稱

            memberManagement = new MemberManagement();
            orderManagement = new OrderManagement();

            // 將控制項添加到相應的 TabPage
            tabPageAccountManagement.Controls.Add(accountManagement);
            tabPageProductManagement.Controls.Add(productManagement);
            tabPageMemberManagement.Controls.Add(memberManagement);
            tabPageOrderManagement.Controls.Add(orderManagement);

            // 這裡用來顯示登入的帳號名稱
            if (!string.IsNullOrEmpty(username))
                ACtextBox.Text = $" {username}";

            InitializeTimeDisplay();
        }
        public void DisplayMessage(string message)
        {
            ACtextBox.Text = message;
        }//獲取使用者名稱出現錯誤時，會把錯誤方案放ACbox裡面

        ////////////////////////////這裡用來處理MAIN時間////////////////////////////////
        private Timer timeDisplayTimer;

        private void InitializeTimeDisplay()
        {
            timeDisplayTimer = new Timer();
            timeDisplayTimer.Interval = 1000; // 每秒更新一次
            timeDisplayTimer.Tick += UpdateTime;
            timeDisplayTimer.Start();
        }
        private void UpdateTime(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        ////////////////////////////上面用來處理MAIN時間////////////////////////////////


        private void UpdateCurrentPageLabel(string pageName)
        {
            lblCurrentPage.Text = $"{pageName}";
        }//顯示當前頁面


        //////////////////////////////下面是按鈕區域////////////////////////////////////
        private void FrmMainBTN_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabPageMain;
            UpdateCurrentPageLabel("主頁");
        }

        private void FrmAccountManagementBTN_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabPageAccountManagement;
            UpdateCurrentPageLabel("帳戶管理");
        }

        private void FrmProductManagementBTN_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabPageProductManagement;
            UpdateCurrentPageLabel("產品管理");
        }

        private void FrmMemberManagementBTN_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabPageMemberManagement;
            UpdateCurrentPageLabel("會員管理");
        }

        private void FrmOrderManagementBTN_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabPageOrderManagement;
            UpdateCurrentPageLabel("訂單管理");
        }
        ////////////////////////////////上面是按鈕區域///////////////////////////////////////////


        ////////////////////////////這裡處理登出與結束////////////////////////////////
        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            // 顯示一個確認訊息框，詢問用戶是否確定要登出
            var result = MessageBox.Show("您確定要登出嗎？", "登出確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 建立新的登入表單
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show(); // 顯示登入介面

                this.Hide(); // 隱藏當前主介面
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 顯示確認提示
            DialogResult result = MessageBox.Show("確定要離開嗎？", "離開確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // 若使用者選擇 "No"，取消關閉動作
                e.Cancel = true;
            }
            else
            {
                // 若使用者選擇 "Yes"，執行完全關閉
                base.OnFormClosing(e);
                Application.Exit();
            }
        }
        ////////////////////////////上面處理登出與結束////////////////////////////////
    }
}
