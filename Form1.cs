using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kodekki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSyötä_Click(object sender, EventArgs e)
        {

            Form2 Form2 = new Form2();
            Form2.Show();
        }

      

        private void btnKatso_Click(object sender, EventArgs e)
        {

            

            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSalasana.Text == "salasana")
            {
                btnSyötä.Visible = true;
            }
            else
            {
                btnSyötä.Visible = false;
                MessageBox.Show("Virheellinen salasana", "Virheilmoitus");
            }
        }

        private void btnLopeta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSalasana_TextChanged(object sender, EventArgs e)
        {
            txtSalasana.PasswordChar = '*';
        }

        private void txtSalasana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnTunnistus.PerformClick();
            }
        }

        private void btnKatso_MouseEnter(object sender, EventArgs e)
        {
            btnKatso.BackColor = Color.SlateGray;
        }

        private void btnKatso_MouseLeave(object sender, EventArgs e)
        {
            btnKatso.BackColor = Color.Black;
        }

        private void btnSyötä_MouseEnter(object sender, EventArgs e)
        {
            btnSyötä.BackColor = Color.SlateGray;
        }

        private void btnSyötä_MouseLeave(object sender, EventArgs e)
        {
            btnSyötä.BackColor = Color.Black;
        }

        private void btnTunnistus_MouseEnter(object sender, EventArgs e)
        {
            btnTunnistus.BackColor = Color.SlateGray;
        }

        private void btnTunnistus_MouseLeave(object sender, EventArgs e)
        {
            btnTunnistus.BackColor = Color.Black;
        }

        private void btnLopeta_MouseEnter(object sender, EventArgs e)
        {
            btnLopeta.BackColor = Color.Firebrick;
        }

        private void btnLopeta_MouseLeave(object sender, EventArgs e)
        {
            btnLopeta.BackColor = Color.Black;
        }



    }
    }

