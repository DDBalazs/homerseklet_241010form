using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homerseklet_241010form
{
    public partial class Form1 : Form
    {
        void szamolas()
        {
            int[] tomb = new int[Convert.ToInt16(txnap.Text)];
            lbhom.Text = "";
            lbatlag.Text = "";
            lbmax.Text = "";
            Random rnd = new Random();
            switch (cbev.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(5,21);
                    }
                    break;
                case 1:
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(-8, 9);
                    }
                    break;
                case 2:
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(12, 26);
                    }
                    break;
                case 3:
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(20, 36);
                    }
                    break;
            }
            double atlag = 0;
            int max = 0;

            for(int i = 0;i < tomb.Length; i++)
            {
                lbhom.Text=lbhom.Text+tomb[i].ToString();
                atlag = atlag+tomb[i];
                if(tomb[i] > tomb[max])
                {
                    max = i;
                }
            }
            atlag=Math.Round(atlag/tomb.Length,2);
            lbatlag.Text = atlag.ToString();
            lbmax.Text = tomb[max].ToString();
            lbhom.Visible = true;
            lbatlag.Visible = true;
            lbmax.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void számolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbev.Enabled = true;
            txnap.Enabled = true;
            btkal.Enabled = true;
        }

        private void btkal_Click(object sender, EventArgs e)
        {
            if(txnap.TextLength == 0)
            {
                MessageBox.Show("Adja meg a napok számát", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnap.Focus();
            }
            else
            {
                szamolas();
            }
        }

        private void cbev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txnap.TextLength > 0)
            {
                szamolas();
            }
        }
    }
}
