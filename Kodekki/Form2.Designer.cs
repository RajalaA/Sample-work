﻿namespace Kodekki
{
    partial class Form2
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
            this.btnSyötäTulos = new System.Windows.Forms.Button();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.lstTulos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHL Tulospalvelu";
            // 
            // btnSyötäTulos
            // 
            this.btnSyötäTulos.Location = new System.Drawing.Point(12, 43);
            this.btnSyötäTulos.Name = "btnSyötäTulos";
            this.btnSyötäTulos.Size = new System.Drawing.Size(94, 35);
            this.btnSyötäTulos.TabIndex = 1;
            this.btnSyötäTulos.Text = "Syötä tulos";
            this.btnSyötäTulos.UseVisualStyleBackColor = true;
            // 
            // btnPalaa
            // 
            this.btnPalaa.Location = new System.Drawing.Point(178, 43);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(94, 35);
            this.btnPalaa.TabIndex = 2;
            this.btnPalaa.Text = "Paluu valikkoon";
            this.btnPalaa.UseVisualStyleBackColor = true;
            // 
            // lstTulos
            // 
            this.lstTulos.FormattingEnabled = true;
            this.lstTulos.Location = new System.Drawing.Point(12, 95);
            this.lstTulos.Name = "lstTulos";
            this.lstTulos.Size = new System.Drawing.Size(260, 160);
            this.lstTulos.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstTulos);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnSyötäTulos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSyötäTulos;
        private System.Windows.Forms.Button btnPalaa;
        private System.Windows.Forms.ListBox lstTulos;
    }
}