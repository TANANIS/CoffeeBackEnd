using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;

namespace CoffeeBackEnd20221026
{
    public partial class FrmLogin : Form
    {

        public ProductionEntities context; // 在這裡定義 context

        public FrmLogin()
        {
            InitializeComponent();
            context = new ProductionEntities(); // 在建構函數中實例化
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            // 固定的測試帳號與密碼
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password))
            {
                // 登入成功，開啟主導航表單
                FrmMain mainForm = new FrmMain(username);
                mainForm.Show();
                this.Hide(); // 隱藏登入表單
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤！", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string username, string password)
        {
            var user = context.Users
                                         .FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null; // 如果找到該使用者，返回 true
        }

        private void ServiceBTN_Click(object sender, EventArgs e)
        {
            string WebUrl = "https://CoffeeService.COM";
            try
            {
                System.Diagnostics.Process.Start(WebUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生開啟錯誤:{ex.Message}，請前往{WebUrl}回報");
            }
        }


        //關閉Form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 這裡可以添加任何額外的關閉處理邏輯（如提示使用者儲存數據等）
            context.Dispose(); // 釋放 context
            base.OnFormClosing(e);
            Application.Exit();// 完全關閉應用程式
        }
    }
}
