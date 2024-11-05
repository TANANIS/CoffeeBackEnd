using System.Windows.Forms;
using System.Drawing;

namespace CoffeeBackEnd20221026
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Timelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.FrmOrderManagementBTN = new System.Windows.Forms.Button();
            this.FrmMemberManagementBTN = new System.Windows.Forms.Button();
            this.FrmProductManagementBTN = new System.Windows.Forms.Button();
            this.FrmAccountManagementBTN = new System.Windows.Forms.Button();
            this.FrmMainBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ACtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageAccountManagement = new System.Windows.Forms.TabPage();
            this.tabPageProductManagement = new System.Windows.Forms.TabPage();
            this.tabPageMemberManagement = new System.Windows.Forms.TabPage();
            this.tabPageOrderManagement = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95652F));
            this.tableLayoutPanel1.Controls.Add(this.Timelabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.LogoutBTN, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.FrmOrderManagementBTN, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.FrmMemberManagementBTN, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FrmProductManagementBTN, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FrmAccountManagementBTN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FrmMainBTN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ACtextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 733);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Timelabel
            // 
            this.Timelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Timelabel.Location = new System.Drawing.Point(87, 677);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(131, 27);
            this.Timelabel.TabIndex = 16;
            this.Timelabel.Text = "TIME";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 54);
            this.label3.TabIndex = 15;
            this.label3.Text = "現在時間";
            // 
            // LogoutBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LogoutBTN, 2);
            this.LogoutBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogoutBTN.Location = new System.Drawing.Point(3, 570);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(215, 75);
            this.LogoutBTN.TabIndex = 9;
            this.LogoutBTN.Text = "登出/結束";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // FrmOrderManagementBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FrmOrderManagementBTN, 2);
            this.FrmOrderManagementBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmOrderManagementBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmOrderManagementBTN.Location = new System.Drawing.Point(3, 489);
            this.FrmOrderManagementBTN.Name = "FrmOrderManagementBTN";
            this.FrmOrderManagementBTN.Size = new System.Drawing.Size(215, 75);
            this.FrmOrderManagementBTN.TabIndex = 8;
            this.FrmOrderManagementBTN.Text = "訂單管理";
            this.FrmOrderManagementBTN.UseVisualStyleBackColor = true;
            this.FrmOrderManagementBTN.Click += new System.EventHandler(this.FrmOrderManagementBTN_Click);
            // 
            // FrmMemberManagementBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FrmMemberManagementBTN, 2);
            this.FrmMemberManagementBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmMemberManagementBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmMemberManagementBTN.Location = new System.Drawing.Point(3, 408);
            this.FrmMemberManagementBTN.Name = "FrmMemberManagementBTN";
            this.FrmMemberManagementBTN.Size = new System.Drawing.Size(215, 75);
            this.FrmMemberManagementBTN.TabIndex = 7;
            this.FrmMemberManagementBTN.Text = "會員管理";
            this.FrmMemberManagementBTN.UseVisualStyleBackColor = true;
            this.FrmMemberManagementBTN.Click += new System.EventHandler(this.FrmMemberManagementBTN_Click);
            // 
            // FrmProductManagementBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FrmProductManagementBTN, 2);
            this.FrmProductManagementBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmProductManagementBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmProductManagementBTN.Location = new System.Drawing.Point(3, 327);
            this.FrmProductManagementBTN.Name = "FrmProductManagementBTN";
            this.FrmProductManagementBTN.Size = new System.Drawing.Size(215, 75);
            this.FrmProductManagementBTN.TabIndex = 6;
            this.FrmProductManagementBTN.Text = "商品管理";
            this.FrmProductManagementBTN.UseVisualStyleBackColor = true;
            this.FrmProductManagementBTN.Click += new System.EventHandler(this.FrmProductManagementBTN_Click);
            // 
            // FrmAccountManagementBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FrmAccountManagementBTN, 2);
            this.FrmAccountManagementBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmAccountManagementBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmAccountManagementBTN.Location = new System.Drawing.Point(3, 246);
            this.FrmAccountManagementBTN.Name = "FrmAccountManagementBTN";
            this.FrmAccountManagementBTN.Size = new System.Drawing.Size(215, 75);
            this.FrmAccountManagementBTN.TabIndex = 5;
            this.FrmAccountManagementBTN.Text = "帳戶管理";
            this.FrmAccountManagementBTN.UseVisualStyleBackColor = true;
            this.FrmAccountManagementBTN.Click += new System.EventHandler(this.FrmAccountManagementBTN_Click);
            // 
            // FrmMainBTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FrmMainBTN, 2);
            this.FrmMainBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmMainBTN.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmMainBTN.Location = new System.Drawing.Point(3, 165);
            this.FrmMainBTN.Name = "FrmMainBTN";
            this.FrmMainBTN.Size = new System.Drawing.Size(215, 75);
            this.FrmMainBTN.TabIndex = 2;
            this.FrmMainBTN.Text = "首頁";
            this.FrmMainBTN.UseVisualStyleBackColor = true;
            this.FrmMainBTN.Click += new System.EventHandler(this.FrmMainBTN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "當前註冊人數";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "當前帳號";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(87, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 13;
            // 
            // ACtextBox
            // 
            this.ACtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ACtextBox.Location = new System.Drawing.Point(87, 110);
            this.ACtextBox.Name = "ACtextBox";
            this.ACtextBox.ReadOnly = true;
            this.ACtextBox.Size = new System.Drawing.Size(131, 22);
            this.ACtextBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 733);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 733);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 671);
            this.panel3.TabIndex = 2;
            // 
            // tabPage
            // 
            this.tabPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPage.Controls.Add(this.tabPageMain);
            this.tabPage.Controls.Add(this.tabPageAccountManagement);
            this.tabPage.Controls.Add(this.tabPageProductManagement);
            this.tabPage.Controls.Add(this.tabPageMemberManagement);
            this.tabPage.Controls.Add(this.tabPageOrderManagement);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage.ItemSize = new System.Drawing.Size(100, 30);
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Multiline = true;
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1129, 671);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPage.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Location = new System.Drawing.Point(4, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1121, 633);
            this.tabPageMain.TabIndex = 5;
            this.tabPageMain.Text = "首頁";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageAccountManagement
            // 
            this.tabPageAccountManagement.Location = new System.Drawing.Point(4, 4);
            this.tabPageAccountManagement.Name = "tabPageAccountManagement";
            this.tabPageAccountManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccountManagement.Size = new System.Drawing.Size(1121, 633);
            this.tabPageAccountManagement.TabIndex = 1;
            this.tabPageAccountManagement.Text = "帳戶管理";
            this.tabPageAccountManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageProductManagement
            // 
            this.tabPageProductManagement.Location = new System.Drawing.Point(4, 4);
            this.tabPageProductManagement.Name = "tabPageProductManagement";
            this.tabPageProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductManagement.Size = new System.Drawing.Size(1121, 633);
            this.tabPageProductManagement.TabIndex = 2;
            this.tabPageProductManagement.Text = "商品管理";
            this.tabPageProductManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageMemberManagement
            // 
            this.tabPageMemberManagement.Location = new System.Drawing.Point(4, 4);
            this.tabPageMemberManagement.Name = "tabPageMemberManagement";
            this.tabPageMemberManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemberManagement.Size = new System.Drawing.Size(1121, 633);
            this.tabPageMemberManagement.TabIndex = 3;
            this.tabPageMemberManagement.Text = "會員管理";
            this.tabPageMemberManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageOrderManagement
            // 
            this.tabPageOrderManagement.Location = new System.Drawing.Point(4, 4);
            this.tabPageOrderManagement.Name = "tabPageOrderManagement";
            this.tabPageOrderManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderManagement.Size = new System.Drawing.Size(1121, 633);
            this.tabPageOrderManagement.TabIndex = 4;
            this.tabPageOrderManagement.Text = "訂單管理";
            this.tabPageOrderManagement.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCurrentPage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 62);
            this.panel4.TabIndex = 1;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentPage.Location = new System.Drawing.Point(19, 19);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(66, 27);
            this.lblCurrentPage.TabIndex = 0;
            this.lblCurrentPage.Text = "主頁";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FrmMainBTN;
        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.Button FrmOrderManagementBTN;
        private System.Windows.Forms.Button FrmMemberManagementBTN;
        private System.Windows.Forms.Button FrmProductManagementBTN;
        private System.Windows.Forms.Button FrmAccountManagementBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ACtextBox;
        private Label label3;
        private Label Timelabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TabControl tabPage;
        private TabPage tabPageAccountManagement;
        private TabPage tabPageProductManagement;
        private TabPage tabPageMemberManagement;
        private TabPage tabPageOrderManagement;
        private Panel panel4;
        private Label lblCurrentPage;
        private TabPage tabPageMain;
    }
}