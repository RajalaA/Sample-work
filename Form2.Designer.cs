namespace Kodekki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSyötäTulos = new System.Windows.Forms.Button();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.lstTulos = new System.Windows.Forms.ListBox();
            this.btnTyhjennä = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtTulos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Päiväys = new System.Windows.Forms.DateTimePicker();
            this.btnPoistaRivi = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(266, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Syötä tuloksia";
            // 
            // btnSyötäTulos
            // 
            this.btnSyötäTulos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSyötäTulos.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyötäTulos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSyötäTulos.Location = new System.Drawing.Point(588, 96);
            this.btnSyötäTulos.Name = "btnSyötäTulos";
            this.btnSyötäTulos.Size = new System.Drawing.Size(111, 35);
            this.btnSyötäTulos.TabIndex = 1;
            this.btnSyötäTulos.Text = "Syötä tulos";
            this.btnSyötäTulos.UseVisualStyleBackColor = false;
            this.btnSyötäTulos.Click += new System.EventHandler(this.btnSyötäTulos_Click);
            this.btnSyötäTulos.MouseEnter += new System.EventHandler(this.btnSyötäTulos_MouseEnter);
            this.btnSyötäTulos.MouseLeave += new System.EventHandler(this.btnSyötäTulos_MouseLeave);
            // 
            // btnPalaa
            // 
            this.btnPalaa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPalaa.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalaa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPalaa.Location = new System.Drawing.Point(588, 231);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(111, 35);
            this.btnPalaa.TabIndex = 2;
            this.btnPalaa.Text = "Paluu valikkoon";
            this.btnPalaa.UseVisualStyleBackColor = false;
            this.btnPalaa.Click += new System.EventHandler(this.btnPalaa_Click);
            this.btnPalaa.MouseEnter += new System.EventHandler(this.btnPalaa_MouseEnter);
            this.btnPalaa.MouseLeave += new System.EventHandler(this.btnPalaa_MouseLeave);
            // 
            // lstTulos
            // 
            this.lstTulos.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTulos.FormattingEnabled = true;
            this.lstTulos.ItemHeight = 14;
            this.lstTulos.Location = new System.Drawing.Point(217, 136);
            this.lstTulos.Name = "lstTulos";
            this.lstTulos.Size = new System.Drawing.Size(341, 130);
            this.lstTulos.TabIndex = 3;
            this.lstTulos.SelectedIndexChanged += new System.EventHandler(this.lstTulos_SelectedIndexChanged);
            // 
            // btnTyhjennä
            // 
            this.btnTyhjennä.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTyhjennä.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyhjennä.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTyhjennä.Location = new System.Drawing.Point(588, 142);
            this.btnTyhjennä.Name = "btnTyhjennä";
            this.btnTyhjennä.Size = new System.Drawing.Size(111, 49);
            this.btnTyhjennä.TabIndex = 5;
            this.btnTyhjennä.Text = "Tyhjennä kentät";
            this.btnTyhjennä.UseVisualStyleBackColor = false;
            this.btnTyhjennä.Click += new System.EventHandler(this.btnTyhjennä_Click);
            this.btnTyhjennä.MouseEnter += new System.EventHandler(this.btnTyhjennä_MouseEnter);
            this.btnTyhjennä.MouseLeave += new System.EventHandler(this.btnTyhjennä_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Kotijoukkue";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(344, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 22);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Vierasjoukkue";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtTulos
            // 
            this.txtTulos.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTulos.Location = new System.Drawing.Point(482, 101);
            this.txtTulos.Name = "txtTulos";
            this.txtTulos.Size = new System.Drawing.Size(76, 21);
            this.txtTulos.TabIndex = 8;
            this.txtTulos.TextChanged += new System.EventHandler(this.txtTulos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(494, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tulos";
            // 
            // Päiväys
            // 
            this.Päiväys.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Päiväys.Location = new System.Drawing.Point(12, 101);
            this.Päiväys.Name = "Päiväys";
            this.Päiväys.Size = new System.Drawing.Size(190, 21);
            this.Päiväys.TabIndex = 10;
            this.Päiväys.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnPoistaRivi
            // 
            this.btnPoistaRivi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPoistaRivi.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaRivi.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPoistaRivi.Location = new System.Drawing.Point(12, 154);
            this.btnPoistaRivi.Name = "btnPoistaRivi";
            this.btnPoistaRivi.Size = new System.Drawing.Size(190, 47);
            this.btnPoistaRivi.TabIndex = 11;
            this.btnPoistaRivi.Text = "Poista valittu rivi";
            this.btnPoistaRivi.UseVisualStyleBackColor = false;
            this.btnPoistaRivi.Click += new System.EventHandler(this.btnPoistaRivi_Click);
            this.btnPoistaRivi.MouseEnter += new System.EventHandler(this.btnPoistaRivi_MouseEnter);
            this.btnPoistaRivi.MouseLeave += new System.EventHandler(this.btnPoistaRivi_MouseLeave);
            // 
            // btnTallenna
            // 
            this.btnTallenna.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTallenna.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTallenna.Location = new System.Drawing.Point(12, 207);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(190, 50);
            this.btnTallenna.TabIndex = 12;
            this.btnTallenna.Text = "Tallenna syötetyt tulokset";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            this.btnTallenna.MouseEnter += new System.EventHandler(this.btnTallenna_MouseEnter);
            this.btnTallenna.MouseLeave += new System.EventHandler(this.btnTallenna_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(751, 318);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnPoistaRivi);
            this.Controls.Add(this.Päiväys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTulos);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnTyhjennä);
            this.Controls.Add(this.lstTulos);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnSyötäTulos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSyötäTulos;
        private System.Windows.Forms.Button btnPalaa;
        private System.Windows.Forms.ListBox lstTulos;
        private System.Windows.Forms.Button btnTyhjennä;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtTulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Päiväys;
        private System.Windows.Forms.Button btnPoistaRivi;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}