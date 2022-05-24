
namespace W_Converter
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
            this.files = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sec = new Guna.UI2.WinForms.Guna2Button();
            this.video = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.resim = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.filename = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.size = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.extension = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.files.Location = new System.Drawing.Point(20, 159);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(505, 271);
            this.files.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 4;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(20, 42);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(666, 45);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // sec
            // 
            this.sec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sec.ForeColor = System.Drawing.Color.White;
            this.sec.Location = new System.Drawing.Point(692, 42);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(88, 45);
            this.sec.TabIndex = 2;
            this.sec.Text = "Seç";
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // video
            // 
            this.video.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.video.CheckedState.BorderThickness = 0;
            this.video.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.video.CheckedState.InnerColor = System.Drawing.Color.White;
            this.video.Location = new System.Drawing.Point(23, 109);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(20, 20);
            this.video.TabIndex = 3;
            this.video.Text = "Video";
            this.video.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.video.UncheckedState.BorderThickness = 2;
            this.video.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.video.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // resim
            // 
            this.resim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resim.CheckedState.BorderThickness = 0;
            this.resim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.resim.Location = new System.Drawing.Point(94, 109);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(20, 20);
            this.resim.TabIndex = 4;
            this.resim.Text = "Resim";
            this.resim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.resim.UncheckedState.BorderThickness = 2;
            this.resim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.resim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Video";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(120, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Resim";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(170, 98);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(88, 45);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Dönüştür";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.guna2PictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel2.Controls.Add(this.filename);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel5);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel6);
            this.flowLayoutPanel2.Controls.Add(this.size);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel7);
            this.flowLayoutPanel2.Controls.Add(this.extension);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel9);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(531, 159);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(259, 271);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 7);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(246, 128);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Dosya Adı:";
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(80, 142);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(67, 19);
            this.filename.TabIndex = 2;
            this.filename.Text = "{filename}";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(153, 142);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "            ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 161);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Dosya Boyutu:";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(100, 161);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(38, 19);
            this.size.TabIndex = 5;
            this.size.Text = "{size}";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(144, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "            ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Dosya Uzantısı:";
            // 
            // extension
            // 
            this.extension.AutoSize = true;
            this.extension.Location = new System.Drawing.Point(104, 180);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(71, 19);
            this.extension.TabIndex = 8;
            this.extension.Text = "{extension}";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(181, 180);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(57, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.video);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.files);
            this.Name = "Form1";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton resim;
        private Guna.UI2.WinForms.Guna2CustomRadioButton video;
        private Guna.UI2.WinForms.Guna2Button sec;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.FlowLayoutPanel files;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel filename;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel size;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel extension;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}

