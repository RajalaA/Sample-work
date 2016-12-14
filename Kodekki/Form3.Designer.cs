namespace Kodekki
{
    partial class Form3
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
            this.btnPaluu = new System.Windows.Forms.Button();
            this.lstTulos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHL Tulospalvelu";
            // 
            // btnPaluu
            // 
            this.btnPaluu.Location = new System.Drawing.Point(178, 48);
            this.btnPaluu.Name = "btnPaluu";
            this.btnPaluu.Size = new System.Drawing.Size(94, 35);
            this.btnPaluu.TabIndex = 3;
            this.btnPaluu.Text = "Paluu valikkoon";
            this.btnPaluu.UseVisualStyleBackColor = true;
            // 
            // lstTulos
            // 
            this.lstTulos.FormattingEnabled = true;
            this.lstTulos.Location = new System.Drawing.Point(13, 48);
            this.lstTulos.Name = "lstTulos";
            this.lstTulos.Size = new System.Drawing.Size(159, 199);
            this.lstTulos.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstTulos);
            this.Controls.Add(this.btnPaluu);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaluu;
        private System.Windows.Forms.ListBox lstTulos;
    }
}