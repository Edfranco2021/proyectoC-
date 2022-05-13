using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "";//lo coloco asi para que en el resultado se vea vacio y no la leyenda
            textBox1.Text = "0"; //pongo un valor inicial para que aparezca en el texbox
            textBox2.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            label2.Text = "numero B";


            double a = Convert.ToDouble(textBox1.Text); //convierto en numero lo ingresado en texboxA
            double b = Convert.ToDouble(textBox2.Text);

            double r = a + b;// hago la operacion
            lbResultado.Text = r.ToString();// convierto el valor numerico en string
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.White;

            label2.Text = "numero B";

            double a = Convert.ToDouble(textBox1.Text); //convierto en numero lo ingresado en texboxA
            double b = Convert.ToDouble(textBox2.Text);

            double r = a - b;// hago la operacion
            lbResultado.Text = r.ToString();// convierto el valor numerico en string
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            label2.Text = "numero B";

            double a = Convert.ToDouble(textBox1.Text); //convierto en numero lo ingresado en texboxA
            double b = Convert.ToDouble(textBox2.Text);
            double r = a * b;// hago la operacion
            lbResultado.Text = r.ToString();// convierto el valor numerico en string
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.Yellow;

            label2.Text = "numero B";

            double a = Convert.ToDouble(textBox1.Text); //convierto en numero lo ingresado en texboxA
            double b = Convert.ToDouble(textBox2.Text);
            double r = a / b;// hago la operacion
            lbResultado.Text = r.ToString();// convierto el valor numerico en string
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            label2.Text = "numero B";

            double a = 0;
            textBox1.Text = a.ToString();
            double b = 0;
            textBox2.Text = b.ToString();
            double r = 0;
            lbResultado.Text = r.ToString();// convierto el valor numerico en string
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            double r = Convert.ToDouble(lbResultado.Text);
            double a = r;
            textBox1.Text = a.ToString();
            double b = 0;
            textBox2.Text = b.ToString();
            label2.Text = "Ingrese valor";
            lbResultado.Text ="0";
        }
    }
}
