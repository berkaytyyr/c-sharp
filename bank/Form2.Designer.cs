namespace bank
{
    partial class PARAYATIR
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtyatir = new System.Windows.Forms.TextBox();
            this.btnyatir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyenibakiye = new System.Windows.Forms.Label();
            this.menuyatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(94, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yatıracağınız Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "Para Yatır";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // txtyatir
            // 
            this.txtyatir.BackColor = System.Drawing.Color.White;
            this.txtyatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyatir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtyatir.Location = new System.Drawing.Point(459, 257);
            this.txtyatir.Name = "txtyatir";
            this.txtyatir.Size = new System.Drawing.Size(124, 41);
            this.txtyatir.TabIndex = 1;
            this.txtyatir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtyatir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnyatir
            // 
            this.btnyatir.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.btnyatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyatir.ForeColor = System.Drawing.Color.White;
            this.btnyatir.Location = new System.Drawing.Point(400, 325);
            this.btnyatir.Name = "btnyatir";
            this.btnyatir.Size = new System.Drawing.Size(183, 58);
            this.btnyatir.TabIndex = 2;
            this.btnyatir.Text = "DEVAM";
            this.btnyatir.UseVisualStyleBackColor = true;
            this.btnyatir.Click += new System.EventHandler(this.btnyatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Bakiye:";
            // 
            // txtyenibakiye
            // 
            this.txtyenibakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtyenibakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyenibakiye.ForeColor = System.Drawing.Color.White;
            this.txtyenibakiye.Location = new System.Drawing.Point(499, 460);
            this.txtyenibakiye.Name = "txtyenibakiye";
            this.txtyenibakiye.Size = new System.Drawing.Size(151, 42);
            this.txtyenibakiye.TabIndex = 0;
            this.txtyenibakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtyenibakiye.Click += new System.EventHandler(this.txtyenibakiye_Click);
            // 
            // menuyatir
            // 
            this.menuyatir.BackColor = System.Drawing.Color.Maroon;
            this.menuyatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuyatir.ForeColor = System.Drawing.Color.White;
            this.menuyatir.Location = new System.Drawing.Point(-1, 460);
            this.menuyatir.Name = "menuyatir";
            this.menuyatir.Size = new System.Drawing.Size(145, 62);
            this.menuyatir.TabIndex = 3;
            this.menuyatir.Text = "MENU";
            this.menuyatir.UseVisualStyleBackColor = false;
            this.menuyatir.Click += new System.EventHandler(this.menuyatir_Click);
            // 
            // PARAYATIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.menuyatir);
            this.Controls.Add(this.btnyatir);
            this.Controls.Add(this.txtyatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyenibakiye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PARAYATIR";
            this.Text = "PARAYATIR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyatir;
        private System.Windows.Forms.Button btnyatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtyenibakiye;
        private System.Windows.Forms.Button menuyatir;
    }
}