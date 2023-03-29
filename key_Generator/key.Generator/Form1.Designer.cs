namespace key.Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.length = new System.Windows.Forms.Label();
            this.check_ABC = new System.Windows.Forms.CheckBox();
            this.check_abcd = new System.Windows.Forms.CheckBox();
            this.check_123 = new System.Windows.Forms.CheckBox();
            this.check_ask = new System.Windows.Forms.CheckBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // length
            // 
            resources.ApplyResources(this.length, "length");
            this.length.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.length.Name = "length";
            // 
            // check_ABC
            // 
            resources.ApplyResources(this.check_ABC, "check_ABC");
            this.check_ABC.Name = "check_ABC";
            this.check_ABC.UseVisualStyleBackColor = true;
            // 
            // check_abcd
            // 
            resources.ApplyResources(this.check_abcd, "check_abcd");
            this.check_abcd.Name = "check_abcd";
            this.check_abcd.UseVisualStyleBackColor = true;
            // 
            // check_123
            // 
            resources.ApplyResources(this.check_123, "check_123");
            this.check_123.Name = "check_123";
            this.check_123.UseVisualStyleBackColor = true;
            // 
            // check_ask
            // 
            resources.ApplyResources(this.check_ask, "check_ask");
            this.check_ask.Name = "check_ask";
            this.check_ask.UseVisualStyleBackColor = true;
            // 
            // btn_generate
            // 
            resources.ApplyResources(this.btn_generate, "btn_generate");
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Name = "label1";
            // 
            // lbl_length
            // 
            resources.ApplyResources(this.lbl_length, "lbl_length");
            this.lbl_length.Name = "lbl_length";
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.check_ask);
            this.Controls.Add(this.check_123);
            this.Controls.Add(this.check_abcd);
            this.Controls.Add(this.check_ABC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.length);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.CheckBox check_ABC;
        private System.Windows.Forms.CheckBox check_abcd;
        private System.Windows.Forms.CheckBox check_123;
        private System.Windows.Forms.CheckBox check_ask;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox txt_password;
    }
}

