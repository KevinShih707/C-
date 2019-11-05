namespace ImageList
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrFly = new System.Windows.Forms.Timer(this.components);
            this.picBird = new System.Windows.Forms.PictureBox();
            this.imgMotor = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ImageIndex = 0;
            this.btnStart.ImageList = this.imgIcon;
            this.btnStart.Location = new System.Drawing.Point(108, 89);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "start.bmp");
            this.imgIcon.Images.SetKeyName(1, "stop.bmp");
            // 
            // btnStop
            // 
            this.btnStop.ImageIndex = 1;
            this.btnStop.ImageList = this.imgIcon;
            this.btnStop.Location = new System.Drawing.Point(192, 89);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 62);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrFly
            // 
            this.tmrFly.Tick += new System.EventHandler(this.tmrFly_Tick);
            // 
            // picBird
            // 
            this.picBird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBird.Location = new System.Drawing.Point(0, 0);
            this.picBird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(79, 60);
            this.picBird.TabIndex = 2;
            this.picBird.TabStop = false;
            // 
            // imgMotor
            // 
            this.imgMotor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMotor.ImageStream")));
            this.imgMotor.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMotor.Images.SetKeyName(0, "motor_up.png");
            this.imgMotor.Images.SetKeyName(1, "motor_right.png");
            this.imgMotor.Images.SetKeyName(2, "motor_buttom.png");
            this.imgMotor.Images.SetKeyName(3, "motor_left.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 252);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrFly;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.ImageList imgMotor;
        private System.Windows.Forms.ImageList imgIcon;
    }
}

