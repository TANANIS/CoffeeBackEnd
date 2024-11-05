namespace CoffeeBackEnd20221026.UserControls
{
    partial class AccountManagement
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ACCtabControl = new System.Windows.Forms.TabControl();
            this.ChangeACtabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.BTNConfirmChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.PwdOldtextBox = new System.Windows.Forms.TextBox();
            this.ACOldTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateACtabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateACbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ACtextBox2 = new System.Windows.Forms.TextBox();
            this.ChangeACbutton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.ACCtabControl.SuspendLayout();
            this.ChangeACtabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CreateACtabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ACCtabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 629);
            this.panel3.TabIndex = 2;
            // 
            // ACCtabControl
            // 
            this.ACCtabControl.Controls.Add(this.ChangeACtabPage);
            this.ACCtabControl.Controls.Add(this.CreateACtabPage);
            this.ACCtabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACCtabControl.Location = new System.Drawing.Point(0, 0);
            this.ACCtabControl.Name = "ACCtabControl";
            this.ACCtabControl.SelectedIndex = 0;
            this.ACCtabControl.Size = new System.Drawing.Size(806, 629);
            this.ACCtabControl.TabIndex = 2;
            // 
            // ChangeACtabPage
            // 
            this.ChangeACtabPage.Controls.Add(this.tableLayoutPanel2);
            this.ChangeACtabPage.Location = new System.Drawing.Point(4, 22);
            this.ChangeACtabPage.Name = "ChangeACtabPage";
            this.ChangeACtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeACtabPage.Size = new System.Drawing.Size(798, 603);
            this.ChangeACtabPage.TabIndex = 0;
            this.ChangeACtabPage.Text = "當前帳戶";
            this.ChangeACtabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.txtNewPassword, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BTNConfirmChange, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNewUsername, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.PwdOldtextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ACOldTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 597);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPassword.Location = new System.Drawing.Point(267, 396);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(258, 40);
            this.txtNewPassword.TabIndex = 14;
            // 
            // BTNConfirmChange
            // 
            this.BTNConfirmChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNConfirmChange.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNConfirmChange.Location = new System.Drawing.Point(531, 479);
            this.BTNConfirmChange.Name = "BTNConfirmChange";
            this.BTNConfirmChange.Size = new System.Drawing.Size(258, 115);
            this.BTNConfirmChange.TabIndex = 17;
            this.BTNConfirmChange.Text = "確認更改";
            this.BTNConfirmChange.UseVisualStyleBackColor = true;
            this.BTNConfirmChange.Click += new System.EventHandler(this.BTNConfirmChange_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "當前使用者帳號：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "當前使用者密碼：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "請輸入新帳號：";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewUsername.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewUsername.Location = new System.Drawing.Point(267, 277);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(258, 40);
            this.txtNewUsername.TabIndex = 13;
            // 
            // PwdOldtextBox
            // 
            this.PwdOldtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdOldtextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PwdOldtextBox.Location = new System.Drawing.Point(267, 158);
            this.PwdOldtextBox.Name = "PwdOldtextBox";
            this.PwdOldtextBox.Size = new System.Drawing.Size(258, 40);
            this.PwdOldtextBox.TabIndex = 10;
            // 
            // ACOldTextBox
            // 
            this.ACOldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ACOldTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ACOldTextBox.Location = new System.Drawing.Point(267, 39);
            this.ACOldTextBox.Name = "ACOldTextBox";
            this.ACOldTextBox.Size = new System.Drawing.Size(258, 40);
            this.ACOldTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "請輸入新密碼：";
            // 
            // CreateACtabPage
            // 
            this.CreateACtabPage.Controls.Add(this.tableLayoutPanel3);
            this.CreateACtabPage.Location = new System.Drawing.Point(4, 22);
            this.CreateACtabPage.Name = "CreateACtabPage";
            this.CreateACtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateACtabPage.Size = new System.Drawing.Size(798, 603);
            this.CreateACtabPage.TabIndex = 1;
            this.CreateACtabPage.Text = "創建帳戶";
            this.CreateACtabPage.UseVisualStyleBackColor = true;
            this.CreateACtabPage.Click += new System.EventHandler(this.CreateACtabPage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 597);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(399, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(390, 40);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 198);
            this.label7.TabIndex = 12;
            this.label7.Text = "新使用者密碼：";
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(399, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(390, 40);
            this.textBox5.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(399, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 195);
            this.button2.TabIndex = 14;
            this.button2.Text = "確認創建";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 198);
            this.label6.TabIndex = 10;
            this.label6.Text = "新使用者帳號：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 629);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 629);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.5F));
            this.tableLayoutPanel1.Controls.Add(this.CreateACbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ACtextBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChangeACbutton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 629);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CreateACbutton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CreateACbutton, 2);
            this.CreateACbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateACbutton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreateACbutton.Location = new System.Drawing.Point(3, 262);
            this.CreateACbutton.Name = "CreateACbutton";
            this.CreateACbutton.Size = new System.Drawing.Size(309, 179);
            this.CreateACbutton.TabIndex = 4;
            this.CreateACbutton.Text = "創建新帳戶";
            this.CreateACbutton.UseVisualStyleBackColor = true;
            this.CreateACbutton.Click += new System.EventHandler(this.CreateACbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "當前登入：";
            // 
            // ACtextBox2
            // 
            this.ACtextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ACtextBox2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ACtextBox2.Location = new System.Drawing.Point(114, 17);
            this.ACtextBox2.Name = "ACtextBox2";
            this.ACtextBox2.ReadOnly = true;
            this.ACtextBox2.Size = new System.Drawing.Size(198, 40);
            this.ACtextBox2.TabIndex = 1;
            // 
            // ChangeACbutton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ChangeACbutton, 2);
            this.ChangeACbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeACbutton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChangeACbutton.Location = new System.Drawing.Point(3, 77);
            this.ChangeACbutton.Name = "ChangeACbutton";
            this.ChangeACbutton.Size = new System.Drawing.Size(309, 179);
            this.ChangeACbutton.TabIndex = 2;
            this.ChangeACbutton.Text = "更改當前帳戶";
            this.ChangeACbutton.UseVisualStyleBackColor = true;
            this.ChangeACbutton.Click += new System.EventHandler(this.ChangeACbutton_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccountManagement";
            this.Size = new System.Drawing.Size(1121, 629);
            this.panel3.ResumeLayout(false);
            this.ACCtabControl.ResumeLayout(false);
            this.ChangeACtabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CreateACtabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl ACCtabControl;
        private System.Windows.Forms.TabPage ChangeACtabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateACbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ACtextBox2;
        private System.Windows.Forms.Button ChangeACbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button BTNConfirmChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox PwdOldtextBox;
        private System.Windows.Forms.TextBox ACOldTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage CreateACtabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}
