namespace bank
{
    partial class MENU
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
            this.btnyatir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncek = new System.Windows.Forms.Button();
            this.btngor = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyatir
            // 
            this.btnyatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyatir.ForeColor = System.Drawing.Color.White;
            this.btnyatir.Image = global::bank.Properties.Resources.atmyeşil;
            this.btnyatir.Location = new System.Drawing.Point(0, 306);
            this.btnyatir.Name = "btnyatir";
            this.btnyatir.Size = new System.Drawing.Size(257, 68);
            this.btnyatir.TabIndex = 0;
            this.btnyatir.Text = "Para Yatır";
            this.btnyatir.UseVisualStyleBackColor = true;
            this.btnyatir.Click += new System.EventHandler(this.btnyatir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ";
            // 
            // btncek
            // 
            this.btncek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncek.ForeColor = System.Drawing.Color.White;
            this.btncek.Image = global::bank.Properties.Resources.atmyeşil;
            this.btncek.Location = new System.Drawing.Point(0, 432);
            this.btncek.Name = "btncek";
            this.btncek.Size = new System.Drawing.Size(257, 68);
            this.btncek.TabIndex = 0;
            this.btncek.Text = "Para Çek";
            this.btncek.UseVisualStyleBackColor = true;
            this.btncek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btngor
            // 
            this.btngor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngor.ForeColor = System.Drawing.Color.White;
            this.btngor.Image = global::bank.Properties.Resources.atmyeşil;
            this.btngor.Location = new System.Drawing.Point(367, 306);
            this.btngor.Name = "btngor";
            this.btngor.Size = new System.Drawing.Size(260, 68);
            this.btngor.TabIndex = 0;
            this.btngor.Text = "Bakiye Görüntüle";
            this.btngor.UseVisualStyleBackColor = true;
            this.btngor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.White;
            this.btncıkıs.Image = global::bank.Properties.Resources.atmyeşil;
            this.btncıkıs.Location = new System.Drawing.Point(367, 432);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(260, 68);
            this.btncıkıs.TabIndex = 0;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENÜ";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.ClientSize = new System.Drawing.Size(625, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngor);
            this.Controls.Add(this.btncek);
            this.Controls.Add(this.btnyatir);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyatir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncek;
        private System.Windows.Forms.Button btngor;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label2;
    }
}