using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeBackEnd20221026.UserControls
{
    public partial class MemberManagement : UserControl
    {
        public int MemberID = 0;

        public MemberManagement()
        {
            InitializeComponent();
            LoadMemberData(); // 載入會員資料
        }
        private void LoadMemberData()
        {
            using (ProductionEntities context = new ProductionEntities())
            {
                var members = context.CUSTOMERs.ToList(); // 獲取所有會員資料
                MemberDataGridView.DataSource = members; // 設定 GridView 的資料來源
            }
        }

        private void MemberDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 獲取選擇的會員資料
                var selectedMember = MemberDataGridView.Rows[e.RowIndex].DataBoundItem as CUSTOMER;

                if (selectedMember != null)
                {
                    // 切換到會員詳細資訊的 TabPage
                    tabControl.SelectedTab = TPuserDetail;

                    // 這裡可以根據選擇的會員來更新詳細資訊
                    LoadMemberDetail(selectedMember);
                }
            }
        }

        private void LoadMemberDetail(CUSTOMER member)
        {
            // 將選擇的會員資料載入詳細資訊的文本框或其他控制項中
            MemberID = member.ID;
            TBUserID.Text = member.UserId;
            TBName.Text = member.Name;
            TBEmail.Text = member.Email;
            TBPhone.Text = member.Phone;
            TBGender.Text = member.Gender.HasValue && member.Gender.Value ? "男" : "女";
            DTPBirthday.Value = member.Birthday ?? DateTime.Now;
            DTPBirthday.Enabled = false;
            if (!string.IsNullOrEmpty(member.ImgSrc))
            {
                try
                {
                    PBImgSrc.Image = Image.FromFile(member.ImgSrc); // 載入圖片
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("無法載入圖片：" + ex.Message);
                    PBImgSrc.Image = null; // 清空 PictureBox 圖片
                }
            }
            else
            {
                PBImgSrc.Image = null; // 清空 PictureBox 圖片
            }
            TBLanguage.Text = member.Language;
            TBReceiverAddress.Text = member.ReceiverAddress;
        }

        private void BtnSuspend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未實作");
            ClearTextBoxes();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未實作");
            ClearTextBoxes();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            tabControl.SelectedTab = TPuser;
        }

        public void ClearTextBoxes()
        {
            MemberID = 0;
            TBUserID.Clear();
            TBName.Clear();
            TBEmail.Clear();
            TBPhone.Clear();
            TBGender.Clear(); // 假設您有這個文本框
            DTPBirthday.Value = DateTime.Now; // 重設為當前日期
            PBImgSrc.Image = null;
            TBLanguage.Clear(); // 清空語言
            TBReceiverAddress.Clear(); // 清空收件地址
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未實作");
            ClearTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未實作");
            ClearTextBoxes();
        }

        private void BTNDetail_Click(object sender, EventArgs e)
        {
            // 檢查是否有選中的行
            if (MemberDataGridView.SelectedRows.Count > 0)
            {
                // 切換到會員詳細資訊的 TabPage
                tabControl.SelectedTab = TPuserDetail;
            }
            else
            {
                MessageBox.Show("請先選擇會員資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

   

        private void BTNameSearch_Click(object sender, EventArgs e)
        {
            string keyword = TBNameSearch.Text.Trim();

            using (ProductionEntities context = new ProductionEntities())
            {
                // 過濾 Name 欄位包含關鍵字的會員
                var filteredMembers = context.CUSTOMERs
                    .Where(member => member.Name.Contains(keyword))
                    .ToList();

                // 更新 DataGridView 顯示過濾後的結果
                MemberDataGridView.DataSource = filteredMembers;
            }
        }
    }


}