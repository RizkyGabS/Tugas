
namespace Tugas
{
    partial class hslHitung
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
            this.lstHasil = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHasil
            // 
            this.lstHasil.HideSelection = false;
            this.lstHasil.Location = new System.Drawing.Point(12, 29);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(344, 289);
            this.lstHasil.TabIndex = 0;
            this.lstHasil.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "[ Hasil ]";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 335);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(344, 28);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            // 
            // hslHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 372);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHasil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "hslHitung";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHitung;
    }
}

