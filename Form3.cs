using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kodekki
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        
}

        private void btnPaluu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstTulos_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }

        private void btnNäytä_Click(object sender, EventArgs e)
        {
            

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            ArrayList tulokset = new ArrayList();

            StreamReader LueTulos = new StreamReader(@"E:\tulokset.txt");
            string luettuRivi = "";

            try
            {
                luettuRivi = LueTulos.ReadLine();
            }
            catch (Exception virhe)
            {
                MessageBox.Show("Tiedoston luku ei onnistu." + virhe.Message);
                LueTulos.Close();
                return;
            }
            tulokset.Add(luettuRivi);
            //lstTulos.Items.Add(luettuRivi);

            while (LueTulos.Peek() > -1)
            {
                luettuRivi = LueTulos.ReadLine();
                // lstTulos.Items.Add(luettuRivi); 
                tulokset.Add(luettuRivi);
            }

            for (int i = tulokset.Count - 1; i >= 0; i--)
            {
                lstTulos.Items.Add(tulokset[i]);
            }



            LueTulos.Close();
        }

        private void btnPaluu_MouseEnter(object sender, EventArgs e)
        {
            btnPaluu.BackColor = Color.SlateGray;
        }

        private void btnPaluu_MouseLeave(object sender, EventArgs e)
        {
            btnPaluu.BackColor = Color.Black;
        }
    }        
  }
    

