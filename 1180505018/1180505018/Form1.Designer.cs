
namespace _1180505018
{
    partial class Form1
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
            this.btnEksen = new System.Windows.Forms.Button();
            this.btnDondur = new System.Windows.Forms.Button();
            this.txtDondur = new System.Windows.Forms.TextBox();
            this.btnYansıt = new System.Windows.Forms.Button();
            this.btnCiz = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEksen
            // 
            this.btnEksen.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEksen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEksen.ForeColor = System.Drawing.Color.Maroon;
            this.btnEksen.Location = new System.Drawing.Point(12, 35);
            this.btnEksen.Name = "btnEksen";
            this.btnEksen.Size = new System.Drawing.Size(153, 61);
            this.btnEksen.TabIndex = 0;
            this.btnEksen.Text = "Eksenleri Çiz";
            this.btnEksen.UseVisualStyleBackColor = false;
            this.btnEksen.Click += new System.EventHandler(this.btnEksen_Click);
            // 
            // btnDondur
            // 
            this.btnDondur.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDondur.ForeColor = System.Drawing.Color.Maroon;
            this.btnDondur.Location = new System.Drawing.Point(12, 185);
            this.btnDondur.Name = "btnDondur";
            this.btnDondur.Size = new System.Drawing.Size(101, 44);
            this.btnDondur.TabIndex = 1;
            this.btnDondur.Text = "Döndür";
            this.btnDondur.UseVisualStyleBackColor = false;
            this.btnDondur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDondur
            // 
            this.txtDondur.Location = new System.Drawing.Point(119, 199);
            this.txtDondur.Name = "txtDondur";
            this.txtDondur.Size = new System.Drawing.Size(48, 20);
            this.txtDondur.TabIndex = 2;
            // 
            // btnYansıt
            // 
            this.btnYansıt.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnYansıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYansıt.ForeColor = System.Drawing.Color.Maroon;
            this.btnYansıt.Location = new System.Drawing.Point(12, 246);
            this.btnYansıt.Name = "btnYansıt";
            this.btnYansıt.Size = new System.Drawing.Size(101, 44);
            this.btnYansıt.TabIndex = 3;
            this.btnYansıt.Text = "Yansıt";
            this.btnYansıt.UseVisualStyleBackColor = false;
            this.btnYansıt.Click += new System.EventHandler(this.btnYansıt_Click);
            // 
            // btnCiz
            // 
            this.btnCiz.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiz.ForeColor = System.Drawing.Color.Maroon;
            this.btnCiz.Location = new System.Drawing.Point(12, 121);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(101, 44);
            this.btnCiz.TabIndex = 4;
            this.btnCiz.Text = "Çiz";
            this.btnCiz.UseVisualStyleBackColor = false;
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(12, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCiz);
            this.Controls.Add(this.btnYansıt);
            this.Controls.Add(this.txtDondur);
            this.Controls.Add(this.btnDondur);
            this.Controls.Add(this.btnEksen);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEksen;
        private System.Windows.Forms.Button btnDondur;
        private System.Windows.Forms.TextBox txtDondur;
        private System.Windows.Forms.Button btnYansıt;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.Button btnClear;
    }
}

