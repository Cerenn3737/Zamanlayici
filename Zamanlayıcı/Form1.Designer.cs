namespace Zamanlayıcı
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labgecensure = new System.Windows.Forms.Label();
            this.labsaat = new System.Windows.Forms.Label();
            this.txtdakika = new System.Windows.Forms.TextBox();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.labsure = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btndurdur = new System.Windows.Forms.Button();
            this.btndevamet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndevamet);
            this.groupBox1.Controls.Add(this.btndurdur);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.labsure);
            this.groupBox1.Controls.Add(this.btnbaslat);
            this.groupBox1.Controls.Add(this.txtdakika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(88, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süre Belirtiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dakika:";
            // 
            // labgecensure
            // 
            this.labgecensure.AutoSize = true;
            this.labgecensure.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labgecensure.Location = new System.Drawing.Point(98, 602);
            this.labgecensure.Name = "labgecensure";
            this.labgecensure.Size = new System.Drawing.Size(0, 22);
            this.labgecensure.TabIndex = 2;
            // 
            // labsaat
            // 
            this.labsaat.AutoSize = true;
            this.labsaat.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labsaat.Location = new System.Drawing.Point(496, 602);
            this.labsaat.Name = "labsaat";
            this.labsaat.Size = new System.Drawing.Size(0, 22);
            this.labsaat.TabIndex = 3;
            // 
            // txtdakika
            // 
            this.txtdakika.BackColor = System.Drawing.Color.LimeGreen;
            this.txtdakika.ForeColor = System.Drawing.Color.White;
            this.txtdakika.Location = new System.Drawing.Point(98, 51);
            this.txtdakika.Name = "txtdakika";
            this.txtdakika.Size = new System.Drawing.Size(65, 29);
            this.txtdakika.TabIndex = 2;
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.Color.Green;
            this.btnbaslat.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbaslat.ForeColor = System.Drawing.Color.White;
            this.btnbaslat.Location = new System.Drawing.Point(42, 103);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(394, 41);
            this.btnbaslat.TabIndex = 3;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = false;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // labsure
            // 
            this.labsure.AutoSize = true;
            this.labsure.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labsure.Font = new System.Drawing.Font("Leelawadee", 95.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsure.ForeColor = System.Drawing.Color.White;
            this.labsure.Location = new System.Drawing.Point(46, 167);
            this.labsure.Name = "labsure";
            this.labsure.Size = new System.Drawing.Size(390, 152);
            this.labsure.TabIndex = 4;
            this.labsure.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(42, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(394, 37);
            this.progressBar1.TabIndex = 5;
            // 
            // btndurdur
            // 
            this.btndurdur.BackColor = System.Drawing.Color.YellowGreen;
            this.btndurdur.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndurdur.ForeColor = System.Drawing.Color.White;
            this.btndurdur.Location = new System.Drawing.Point(60, 439);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(363, 41);
            this.btndurdur.TabIndex = 6;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = false;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btndevamet
            // 
            this.btndevamet.BackColor = System.Drawing.Color.ForestGreen;
            this.btndevamet.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndevamet.ForeColor = System.Drawing.Color.White;
            this.btndevamet.Location = new System.Drawing.Point(60, 495);
            this.btndevamet.Name = "btndevamet";
            this.btndevamet.Size = new System.Drawing.Size(363, 41);
            this.btndevamet.TabIndex = 7;
            this.btndevamet.Text = "Devam Et";
            this.btndevamet.UseVisualStyleBackColor = false;
            this.btndevamet.Click += new System.EventHandler(this.btndevamet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 664);
            this.Controls.Add(this.labgecensure);
            this.Controls.Add(this.labsaat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamanlayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdakika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labgecensure;
        private System.Windows.Forms.Label labsaat;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labsure;
        private System.Windows.Forms.Button btndevamet;
        private System.Windows.Forms.Button btndurdur;
    }
}

