namespace Sistem_Pendukung_Keputusan
{
    partial class Pemilihan_Tempat
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCentang = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolam Renang Kota Malang";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Kolam Renang Stadion Gajayana",
            "Permata Jingga Swimming Pool & Café",
            "Taman Wisata Lembah Dieng",
            "Araya Family Club House Swimming Pool",
            "Taman Rekreasi Tlogomas",
            "Kolam Renang Tirta Alam",
            "Kolam Renang Kalimeri",
            "Kolam Renang In Jaya",
            "Kolam Renang Wiroto",
            "Kolam Renang Simpang Sulfat Selatan",
            "Kolam Renang dan Pemancingan Sumber Beling",
            "Kolam Renang Ukhuwah",
            "Kolam Renang Warna",
            "Kolam Renang Tirta Marabunta",
            "Rogonoto Pool",
            "Hawai Waterpark",
            "Sengkaling Water Park",
            "Tirtasari Water Park"});
            this.checkedListBox1.Location = new System.Drawing.Point(43, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(258, 274);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCentang
            // 
            this.btnCentang.Location = new System.Drawing.Point(378, 184);
            this.btnCentang.Name = "btnCentang";
            this.btnCentang.Size = new System.Drawing.Size(75, 42);
            this.btnCentang.TabIndex = 21;
            this.btnCentang.Text = "Centang Semua";
            this.btnCentang.UseVisualStyleBackColor = true;
            this.btnCentang.Click += new System.EventHandler(this.btnCentang_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(378, 232);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Ulang";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCentang);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 304);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Kolam Renang";
            // 
            // Pemilihan_Tempat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pemilihan_Tempat";
            this.Text = "Pemilihan_Tempat";
            this.Load += new System.EventHandler(this.Pemilihan_Tempat_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCentang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}