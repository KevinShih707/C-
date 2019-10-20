namespace Hw5_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_query = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(119, 76);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(98, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "使用者姓名";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(119, 139);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 18);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "使用者密碼";
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(278, 217);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(89, 65);
            this.button_query.TabIndex = 2;
            this.button_query.Text = "查詢";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(267, 73);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(112, 29);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(267, 136);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(112, 29);
            this.textBox_password.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 353);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "使用者登入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

