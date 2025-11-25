namespace bank
{
    partial class Bakiye
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
            this.mevcutbakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menubakiye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mevcutbakiye
            // 
            this.mevcutbakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mevcutbakiye.Location = new System.Drawing.Point(158, 216);
            this.mevcutbakiye.Name = "mevcutbakiye";
            this.mevcutbakiye.Size = new System.Drawing.Size(340, 75);
            this.mevcutbakiye.TabIndex = 0;
            this.mevcutbakiye.TextChanged += new System.EventHandler(this.mevcutbakiye_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Bakiye";
            // 
            // menubakiye
            // 
            this.menubakiye.BackColor = System.Drawing.Color.Maroon;
            this.menubakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menubakiye.ForeColor = System.Drawing.Color.White;
            this.menubakiye.Location = new System.Drawing.Point(-1, 466);
            this.menubakiye.Name = "menubakiye";
            this.menubakiye.Size = new System.Drawing.Size(145, 62);
            this.menubakiye.TabIndex = 2;
            this.menubakiye.Text = "MENU";
            this.menubakiye.UseVisualStyleBackColor = false;
            this.menubakiye.Click += new System.EventHandler(this.menubakiye_Click);
            // 
            // Bakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.menubakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mevcutbakiye);
            this.Name = "Bakiye";
            this.Text = "Bakiye";
            this.Load += new System.EventHandler(this.Bakiye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mevcutbakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menubakiye;
    }
}