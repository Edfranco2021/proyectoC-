using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golpeaTopo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int result;
            for (int i = 0; i < 10; i++)
            {
                TimeSpan

                Random rnd = new Random();
                result = rnd.Next(1, 8);
                switch (result)
                {
                    case 1:
                        btoTopo1.BackColor = Color.Yellow;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 2:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.Yellow;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 3:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.Yellow;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 4:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.Yellow;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 5:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.Yellow;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 6:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.Yellow;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 7:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.Yellow;
                        btoTopo8.BackColor = Color.White;
                        break;
                    case 8:
                        btoTopo1.BackColor = Color.White;
                        btoTopo2.BackColor = Color.White;
                        btoTopo3.BackColor = Color.White;
                        btoTopo4.BackColor = Color.White;
                        btoTopo5.BackColor = Color.White;
                        btoTopo6.BackColor = Color.White;
                        btoTopo7.BackColor = Color.White;
                        btoTopo8.BackColor = Color.Yellow;
                        break;


                }
            }
            
        }
    }
}
