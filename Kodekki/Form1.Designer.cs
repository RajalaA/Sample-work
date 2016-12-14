namespace Kodekki
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
            this.btnSyötä = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKatso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalasana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSyötä
            // 
            this.btnSyötä.Location = new System.Drawing.Point(22, 88);
            this.btnSyötä.Name = "btnSyötä";
            this.btnSyötä.Size = new System.Drawing.Size(238, 54);
            this.btnSyötä.TabIndex = 0;
            this.btnSyötä.Text = "Syötä tuloksia";
            this.btnSyötä.UseVisualStyleBackColor = true;
            this.btnSyötä.Click += new System.EventHandler(this.btnSyötä_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKatso
            // 
            this.btnKatso.Location = new System.Drawing.Point(22, 166);
            this.btnKatso.Name = "btnKatso";
            this.btnKatso.Size = new System.Drawing.Size(238, 54);
            this.btnKatso.TabIndex = 2;
            this.btnKatso.Text = "Katso tuloksia";
            this.btnKatso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHL Tulospalvelu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Syötä salasana";
            // 
            // txtSalasana
            // 
            this.txtSalasana.Location = new System.Drawing.Point(310, 88);
            this.txtSalasana.Name = "txtSalasana";
            this.txtSalasana.Size = new System.Drawing.Size(148, 20);
            this.txtSalasana.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.txtSalasana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKatso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSyötä);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSyötä;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKatso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalasana;
    }
}

