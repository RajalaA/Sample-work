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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSyötä = new System.Windows.Forms.Button();
            this.btnKatso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalasana = new System.Windows.Forms.TextBox();
            this.btnTunnistus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLopeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSyötä
            // 
            this.btnSyötä.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSyötä.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyötä.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSyötä.Location = new System.Drawing.Point(178, 66);
            this.btnSyötä.Name = "btnSyötä";
            this.btnSyötä.Size = new System.Drawing.Size(238, 54);
            this.btnSyötä.TabIndex = 0;
            this.btnSyötä.Text = "Syötä tuloksia";
            this.btnSyötä.UseVisualStyleBackColor = false;
            this.btnSyötä.Visible = false;
            this.btnSyötä.Click += new System.EventHandler(this.btnSyötä_Click);
            this.btnSyötä.MouseEnter += new System.EventHandler(this.btnSyötä_MouseEnter);
            this.btnSyötä.MouseLeave += new System.EventHandler(this.btnSyötä_MouseLeave);
            // 
            // btnKatso
            // 
            this.btnKatso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKatso.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatso.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKatso.Location = new System.Drawing.Point(178, 128);
            this.btnKatso.Name = "btnKatso";
            this.btnKatso.Size = new System.Drawing.Size(238, 54);
            this.btnKatso.TabIndex = 2;
            this.btnKatso.Text = "Katso tuloksia";
            this.btnKatso.UseVisualStyleBackColor = false;
            this.btnKatso.Click += new System.EventHandler(this.btnKatso_Click);
            this.btnKatso.MouseEnter += new System.EventHandler(this.btnKatso_MouseEnter);
            this.btnKatso.MouseLeave += new System.EventHandler(this.btnKatso_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHL Tulospalvelu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(466, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Syötä salasana";
            // 
            // txtSalasana
            // 
            this.txtSalasana.Location = new System.Drawing.Point(450, 100);
            this.txtSalasana.Name = "txtSalasana";
            this.txtSalasana.Size = new System.Drawing.Size(148, 20);
            this.txtSalasana.TabIndex = 5;
            this.txtSalasana.TextChanged += new System.EventHandler(this.txtSalasana_TextChanged);
            this.txtSalasana.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalasana_KeyDown);
            // 
            // btnTunnistus
            // 
            this.btnTunnistus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTunnistus.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTunnistus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTunnistus.Location = new System.Drawing.Point(469, 126);
            this.btnTunnistus.Name = "btnTunnistus";
            this.btnTunnistus.Size = new System.Drawing.Size(109, 54);
            this.btnTunnistus.TabIndex = 6;
            this.btnTunnistus.Text = "Tunnistaudu";
            this.btnTunnistus.UseVisualStyleBackColor = false;
            this.btnTunnistus.Click += new System.EventHandler(this.button1_Click);
            this.btnTunnistus.MouseEnter += new System.EventHandler(this.btnTunnistus_MouseEnter);
            this.btnTunnistus.MouseLeave += new System.EventHandler(this.btnTunnistus_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 173);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLopeta
            // 
            this.btnLopeta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLopeta.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopeta.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLopeta.Location = new System.Drawing.Point(454, 12);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(144, 34);
            this.btnLopeta.TabIndex = 8;
            this.btnLopeta.Text = "Lopeta";
            this.btnLopeta.UseVisualStyleBackColor = false;
            this.btnLopeta.Click += new System.EventHandler(this.btnLopeta_Click);
            this.btnLopeta.MouseEnter += new System.EventHandler(this.btnLopeta_MouseEnter);
            this.btnLopeta.MouseLeave += new System.EventHandler(this.btnLopeta_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(610, 205);
            this.ControlBox = false;
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTunnistus);
            this.Controls.Add(this.txtSalasana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKatso);
            this.Controls.Add(this.btnSyötä);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSyötä;
        private System.Windows.Forms.Button btnKatso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalasana;
        private System.Windows.Forms.Button btnTunnistus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLopeta;
    }
}

