using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kodekki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] joukkue = new string[15];

            joukkue[0] = "Chicago";
            joukkue[1] = "Winnipeg";
            joukkue[2] = "Anaheim";
            joukkue[3] = "Colorado";
            joukkue[4] = "Boston";
            joukkue[5] = "Tampa Bay";
            joukkue[6] = "Detroit";
            joukkue[7] = "San Jose";
            joukkue[8] = "Florida";
            joukkue[9] = "Minnesota";
            joukkue[10] = "Pittsburgh";
            joukkue[11] = "Calgary";
            joukkue[12] = "Toronto";
            joukkue[13] = "Montreal";
            joukkue[14] = "Los Angeles";

            comboBox1.Items.AddRange(joukkue);
            comboBox2.Items.AddRange(joukkue);
        }

        private void btnPalaa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSyötäTulos_Click(object sender, EventArgs e)
        {
            lstTulos.Items.Add(Päiväys.Value.ToString("dd/MM/yyyy") + "    " + comboBox1.SelectedItem + " " + txtTulos.Text + " " + comboBox2.SelectedItem);
            
        }

        private void btnTyhjennä_Click(object sender, EventArgs e)
        {
            txtTulos.Clear();
            comboBox1.Text = "Kotijoukkue";
            comboBox2.Text = "Vierasjoukkue";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstTulos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTulos_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //lisätään tiedot notepadiin
            StreamWriter m_objOutput = new StreamWriter(@"e:\tulokset.txt", true);
            foreach (var item in lstTulos.Items)
            {
                string rivi = (string)item;
                m_objOutput.WriteLine(rivi);
            }
            m_objOutput.Close();
            MessageBox.Show("Tulokset tallennettu onnistuneesti");
        }

        private void btnPoistaRivi_Click(object sender, EventArgs e)
        {
            if (this.lstTulos.SelectedIndex >= 0)
                this.lstTulos.Items.RemoveAt(this.lstTulos.SelectedIndex);

            else
                MessageBox.Show ("ei riviä valittuna");
        }

        private void btnSyötäTulos_MouseEnter(object sender, EventArgs e)
        {
            btnSyötäTulos.BackColor = Color.SlateGray;
        }

        private void btnSyötäTulos_MouseLeave(object sender, EventArgs e)
        {
            btnSyötäTulos.BackColor = Color.Black;
        }

        private void btnTyhjennä_MouseEnter(object sender, EventArgs e)
        {
            btnTyhjennä.BackColor = Color.SlateGray;
        }

        private void btnTyhjennä_MouseLeave(object sender, EventArgs e)
        {
            btnTyhjennä.BackColor = Color.Black;
        }

        private void btnPalaa_MouseEnter(object sender, EventArgs e)
        {
            btnPalaa.BackColor = Color.SlateGray;
        }

        private void btnPalaa_MouseLeave(object sender, EventArgs e)
        {
            btnPalaa.BackColor = Color.Black;
        }

        private void btnTallenna_MouseEnter(object sender, EventArgs e)
        {
            btnTallenna.BackColor = Color.SlateGray;
        }

        private void btnTallenna_MouseLeave(object sender, EventArgs e)
        {
            btnTallenna.BackColor = Color.Black;
        }

        private void btnPoistaRivi_MouseEnter(object sender, EventArgs e)
        {
            btnPoistaRivi.BackColor = Color.SlateGray;
        }

        private void btnPoistaRivi_MouseLeave(object sender, EventArgs e)
        {
            btnPoistaRivi.BackColor = Color.Black;
        }

        
    }
}
