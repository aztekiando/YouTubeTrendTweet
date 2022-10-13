namespace YouTubeTrendTweets
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtYTKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTWConKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTWConSec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTWAccToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTWAccSec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegionCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYTKey
            // 
            this.txtYTKey.Location = new System.Drawing.Point(12, 55);
            this.txtYTKey.Name = "txtYTKey";
            this.txtYTKey.Size = new System.Drawing.Size(132, 22);
            this.txtYTKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "YouTube Api Key*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Twitter Consumer Key*";
            // 
            // txtTWConKey
            // 
            this.txtTWConKey.Location = new System.Drawing.Point(12, 121);
            this.txtTWConKey.Name = "txtTWConKey";
            this.txtTWConKey.Size = new System.Drawing.Size(166, 22);
            this.txtTWConKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Twitter Consumer Secret*";
            // 
            // txtTWConSec
            // 
            this.txtTWConSec.Location = new System.Drawing.Point(14, 187);
            this.txtTWConSec.Name = "txtTWConSec";
            this.txtTWConSec.Size = new System.Drawing.Size(166, 22);
            this.txtTWConSec.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Twitter Access Token*";
            // 
            // txtTWAccToken
            // 
            this.txtTWAccToken.Location = new System.Drawing.Point(14, 253);
            this.txtTWAccToken.Name = "txtTWAccToken";
            this.txtTWAccToken.Size = new System.Drawing.Size(166, 22);
            this.txtTWAccToken.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Twitter Access Secret*";
            // 
            // txtTWAccSec
            // 
            this.txtTWAccSec.Location = new System.Drawing.Point(12, 319);
            this.txtTWAccSec.Name = "txtTWAccSec";
            this.txtTWAccSec.Size = new System.Drawing.Size(166, 22);
            this.txtTWAccSec.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(295, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Region Code";
            // 
            // txtRegionCode
            // 
            this.txtRegionCode.Location = new System.Drawing.Point(281, 55);
            this.txtRegionCode.Name = "txtRegionCode";
            this.txtRegionCode.Size = new System.Drawing.Size(132, 22);
            this.txtRegionCode.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRegionCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTWAccSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTWAccToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTWConSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTWConKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYTKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Trend Tweets // aztekiaNdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYTKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTWConKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTWConSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTWAccToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTWAccSec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegionCode;
    }
}

