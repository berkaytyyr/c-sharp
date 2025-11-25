namespace bank
{
    partial class PARACEK
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
            this.txttutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndevam = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.btn400 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.menucek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Çek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-8, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Farklı Bir Tutar Gir:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttutar
            // 
            this.txttutar.BackColor = System.Drawing.Color.White;
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(6, 12);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(96, 38);
            this.txttutar.TabIndex = 3;
            this.txttutar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Location = new System.Drawing.Point(312, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btndevam
            // 
            this.btndevam.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.btndevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndevam.ForeColor = System.Drawing.Color.White;
            this.btndevam.Location = new System.Drawing.Point(420, 411);
            this.btndevam.Name = "btndevam";
            this.btndevam.Size = new System.Drawing.Size(235, 58);
            this.btndevam.TabIndex = 1;
            this.btndevam.Text = "DEVAM";
            this.btndevam.UseVisualStyleBackColor = true;
            this.btndevam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn100.Location = new System.Drawing.Point(-1, 109);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(199, 68);
            this.btn100.TabIndex = 5;
            this.btn100.Text = "100TL";
            this.btn100.UseVisualStyleBackColor = true;
            // 
            // btn200
            // 
            this.btn200.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn200.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn200.Location = new System.Drawing.Point(-1, 199);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(199, 68);
            this.btn200.TabIndex = 5;
            this.btn200.Text = "200TL";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn300
            // 
            this.btn300.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn300.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn300.Location = new System.Drawing.Point(-1, 292);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(199, 68);
            this.btn300.TabIndex = 5;
            this.btn300.Text = "300TL";
            this.btn300.UseVisualStyleBackColor = true;
            this.btn300.Click += new System.EventHandler(this.btn300_Click);
            // 
            // btn400
            // 
            this.btn400.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn400.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn400.Location = new System.Drawing.Point(465, 109);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(199, 68);
            this.btn400.TabIndex = 5;
            this.btn400.Text = "400TL";
            this.btn400.UseVisualStyleBackColor = true;
            this.btn400.Click += new System.EventHandler(this.btn400_Click);
            // 
            // btn500
            // 
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn500.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn500.Location = new System.Drawing.Point(465, 199);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(199, 68);
            this.btn500.TabIndex = 5;
            this.btn500.Text = "500TL";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn1000
            // 
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn1000.Location = new System.Drawing.Point(465, 292);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(199, 68);
            this.btn1000.TabIndex = 5;
            this.btn1000.Text = "1000TL";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // menucek
            // 
            this.menucek.BackColor = System.Drawing.Color.Maroon;
            this.menucek.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menucek.ForeColor = System.Drawing.Color.White;
            this.menucek.Location = new System.Drawing.Point(-1, 461);
            this.menucek.Name = "menucek";
            this.menucek.Size = new System.Drawing.Size(145, 62);
            this.menucek.TabIndex = 6;
            this.menucek.Text = "MENU";
            this.menucek.UseVisualStyleBackColor = false;
            this.menucek.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // PARACEK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bank.Properties.Resources.arkaplan4;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.menucek);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn400);
            this.Controls.Add(this.btn300);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndevam);
            this.Controls.Add(this.label1);
            this.Name = "PARACEK";
            this.Text = "PARACEK";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndevam;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn400;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button menucek;
    }
}