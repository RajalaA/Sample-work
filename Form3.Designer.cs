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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaluu = new System.Windows.Forms.Button();
            this.lstTulos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tulokset";
            // 
            // btnPaluu
            // 
            this.btnPaluu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaluu.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaluu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPaluu.Location = new System.Drawing.Point(402, 48);
            this.btnPaluu.Name = "btnPaluu";
            this.btnPaluu.Size = new System.Drawing.Size(123, 51);
            this.btnPaluu.TabIndex = 3;
            this.btnPaluu.Text = "Paluu valikkoon";
            this.btnPaluu.UseVisualStyleBackColor = false;
            this.btnPaluu.Click += new System.EventHandler(this.btnPaluu_Click);
            this.btnPaluu.MouseEnter += new System.EventHandler(this.btnPaluu_MouseEnter);
            this.btnPaluu.MouseLeave += new System.EventHandler(this.btnPaluu_MouseLeave);
            // 
            // lstTulos
            // 
            this.lstTulos.BackColor = System.Drawing.SystemColors.MenuText;
            this.lstTulos.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTulos.ForeColor = System.Drawing.SystemColors.Window;
            this.lstTulos.FormattingEnabled = true;
            this.lstTulos.ItemHeight = 17;
            this.lstTulos.Location = new System.Drawing.Point(13, 48);
            this.lstTulos.Name = "lstTulos";
            this.lstTulos.Size = new System.Drawing.Size(383, 412);
            this.lstTulos.TabIndex = 4;
            this.lstTulos.SelectedIndexChanged += new System.EventHandler(this.lstTulos_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lstTulos);
            this.Controls.Add(this.btnPaluu);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaluu;
        private System.Windows.Forms.ListBox lstTulos;
    }
}