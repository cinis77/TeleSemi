using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            List<int> M = generuoja_kamuoliukus(1,16);
            List<int> J = generuoja_kamuoliukus(16, 31); 
            List<int> R = generuoja_kamuoliukus(31, 46) ;
            List<int> G = generuoja_kamuoliukus(46, 61) ;
            List<int> Z = generuoja_kamuoliukus(61, 76);

            int[] masyvo = M.ToArray();
            M1.Text = masyvo[0].ToString();
            M2.Text = masyvo[1].ToString();
            M3.Text = masyvo[2].ToString();
            M4.Text = masyvo[3].ToString();
            M5.Text = masyvo[4].ToString();

            masyvo = J.ToArray();
            J1.Text = masyvo[0].ToString();
            J2.Text = masyvo[1].ToString();
            J3.Text = masyvo[2].ToString();
            J4.Text = masyvo[3].ToString();
            J5.Text = masyvo[4].ToString();

            masyvo = R.ToArray();
            R1.Text = masyvo[0].ToString();
            R2.Text = masyvo[1].ToString();
            R3.Text = masyvo[2].ToString();
            R4.Text = masyvo[3].ToString();
            R5.Text = masyvo[4].ToString();

            masyvo = G.ToArray();
            G1.Text = masyvo[0].ToString();
            G2.Text = masyvo[1].ToString();
            G3.Text = masyvo[2].ToString();
            G4.Text = masyvo[3].ToString();
            G5.Text = masyvo[4].ToString();

            masyvo = Z.ToArray();
            Z1.Text = masyvo[0].ToString();
            Z2.Text = masyvo[1].ToString();
            Z3.Text = masyvo[2].ToString();
            Z4.Text = masyvo[3].ToString();
            Z5.Text = masyvo[4].ToString();

        }

        private List<int> generuoja_kamuoliukus(int a, int b)
        {
            List<int> darbui = new List<int>();
            Random rng = new Random();
            int ieskau = 5;
            while (ieskau != 0)
            {
                int temp = rng.Next(a, b);
                int flag = 0;
                foreach (int kam in darbui)
                {
                    if (kam == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    darbui.Add(temp);
                    ieskau--;
                }
                
            }
            return darbui;
        }
    }
}
