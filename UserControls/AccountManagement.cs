using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace CoffeeBackEnd20221026.UserControls
{
    public partial class AccountManagement : UserControl
    {
        // 用來接收當前登入的使用者帳號

        private string currentUsername; // 儲存當前使用者的帳號
        public string Username
        {
            get { return ACtextBox2.Text; }
            set { ACtextBox2.Text = $"{value}"; }
        }

        public AccountManagement()
        {
            InitializeComponent();

            
        }

        private void ChangeACbutton_Click(object sender, EventArgs e)
        {
            ACCtabControl.SelectedTab = ChangeACtabPage;


        }

        private void CreateACbutton_Click(object sender, EventArgs e)
        {
           
            ACCtabControl.SelectedTab = CreateACtabPage;

        }

        private void BTNConfirmChange_Click(object sender, EventArgs e)
        {  // 獲取輸入的新的帳號名稱和密碼
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            // 檢查輸入是不是空值
            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("請輸入有效的帳號和密碼。",
                    "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 獲取舊的帳號和密碼
            string oldUsername = ACOldTextBox.Text;
            string oldPassword = PwdOldtextBox.Text;

            // 使用 Entity Framework 更新帳戶資訊
            using (var context = new ProductionEntities())
            {
                // 根據當前使用者的帳號查詢使用者資料
                var user = context.Users.FirstOrDefault(u => u.Username == currentUsername);

                if (user != null)
                {
                    // 檢查舊的帳號和密碼是否正確
                    if (user.Username == oldUsername && user.Password == oldPassword)
                    {
                        // 如果新的帳號名稱或密碼與舊的相同，則不允許更改
                        if (newUsername == oldUsername && newPassword == oldPassword)
                        {
                            MessageBox.Show("新的帳號或密碼不能與舊的相同！",
                                "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // 更新使用者資料
                        user.Username = newUsername;
                        user.Password = newPassword; // 這裡建議密碼進行加密處理

                        // 儲存變更到資料庫
                        context.SaveChanges();

                        // 若更新成功，顯示成功訊息
                        MessageBox.Show("帳戶資訊更新成功！",
                            "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("舊帳號或密碼不正確！",
                            "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("找不到該帳戶！",
                        "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateACtabPage_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
        }

