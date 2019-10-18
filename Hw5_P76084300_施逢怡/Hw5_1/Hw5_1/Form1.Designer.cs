namespace Hw5_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_price = new System.Windows.Forms.Label();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_price
            // 
            resources.ApplyResources(this.label_price, "label_price");
            this.label_price.Name = "label_price";
            // 
            // label_rate
            // 
            resources.ApplyResources(this.label_rate, "label_rate");
            this.label_rate.Name = "label_rate";
            // 
            // label_year
            // 
            resources.ApplyResources(this.label_year, "label_year");
            this.label_year.Name = "label_year";
            // 
            // textBox_price
            // 
            resources.ApplyResources(this.textBox_price, "textBox_price");
            this.textBox_price.Name = "textBox_price";
            // 
            // textBox_year
            // 
            resources.ApplyResources(this.textBox_year, "textBox_year");
            this.textBox_year.Name = "textBox_year";
            // 
            // textBox_rate
            // 
            resources.ApplyResources(this.textBox_rate, "textBox_rate");
            this.textBox_rate.Name = "textBox_rate";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.label_price);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Button button1;
    }
}

