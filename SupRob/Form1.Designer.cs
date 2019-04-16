namespace SupRob
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
            this.components = new System.ComponentModel.Container();
            this.PictureBoxA = new System.Windows.Forms.PictureBox();
            this.PictureBoxB = new System.Windows.Forms.PictureBox();
            this.PictureBoxRob = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRob)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxA
            // 
            this.PictureBoxA.Location = new System.Drawing.Point(60, 102);
            this.PictureBoxA.Name = "PictureBoxA";
            this.PictureBoxA.Size = new System.Drawing.Size(156, 88);
            this.PictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxA.TabIndex = 0;
            this.PictureBoxA.TabStop = false;
            // 
            // PictureBoxB
            // 
            this.PictureBoxB.Location = new System.Drawing.Point(737, 102);
            this.PictureBoxB.Name = "PictureBoxB";
            this.PictureBoxB.Size = new System.Drawing.Size(156, 88);
            this.PictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxB.TabIndex = 1;
            this.PictureBoxB.TabStop = false;
            // 
            // PictureBoxRob
            // 
            this.PictureBoxRob.Location = new System.Drawing.Point(424, 102);
            this.PictureBoxRob.Name = "PictureBoxRob";
            this.PictureBoxRob.Size = new System.Drawing.Size(117, 88);
            this.PictureBoxRob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxRob.TabIndex = 2;
            this.PictureBoxRob.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(443, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 416);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.PictureBoxRob);
            this.Controls.Add(this.PictureBoxB);
            this.Controls.Add(this.PictureBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxA;
        private System.Windows.Forms.PictureBox PictureBoxB;
        private System.Windows.Forms.PictureBox PictureBoxRob;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

