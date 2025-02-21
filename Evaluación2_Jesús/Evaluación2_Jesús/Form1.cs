using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluación2_Jesús
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            textBox8.Visible = false;
            label9.Visible = false;
        }
        double T1, T2, T3, L1, L2, L3;
        double Promedio;
        private void button1_Click(object sender, EventArgs e)
        {
            T1 = Convert.ToDouble(textBox1.Text);
            T2 = Convert.ToDouble(textBox2.Text);
            T3 = Convert.ToDouble(textBox3.Text);
            L1 = Convert.ToDouble(textBox4.Text);
            L2 = Convert.ToDouble(textBox5.Text);
            L3 = Convert.ToDouble(textBox6.Text);
            Promedio = (T1 + T2 + T3 + L1 + L2 + L3)/ 6;

            textBox7.Text = "" + Promedio;

            if (T1 < 0 || T1 > 10 || T2 < 0 || T2 > 10 || T3 < 0 || T3 > 10 || L1 < 0 || L1 > 10 || L2 < 0 || L2 > 10 || L3 < 0 || L3 > 10)
            {
                label9.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                textBox8.Visible = false;
            }
            if (Promedio > 10 || Promedio < 0)
            {
                label9.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                textBox8.Visible = false;
            }
            if (Promedio >=7 && Promedio <=10)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label9.Visible = false;
                textBox8.Visible = true;
                textBox8.Text = "PERFECTO!  Esta APROBADO!  Sigue así >:D!";
            }
            if (Promedio < 7 && Promedio >= 6)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label9.Visible = false;
                textBox8.Visible = true;
                textBox8.Text = "Podemos mejorar... Pero has APROBADO!  Ánimo, aún se puede mejorar :)";
            }
            if (Promedio < 6 && Promedio >=3)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                label9.Visible = false;
                textBox8.Visible = true;
                textBox8.Text = "Bueno... Has REPROBADO...  Falta un poco de esfuerzo, puedes mejorar mucho más :3";
            }
            if (Promedio < 3 && Promedio >=0)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label9.Visible = false;
                textBox8.Visible = true;
                textBox8.Text = "Falta de esfuerzo... Has.. Bueno, ya lo deberías saber.  Debes mejorar, no te puedes quedar así...";
            }
        }

        
    }
}
