using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación1_Jesús
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Queso, QuesoConLoroco, Frijol, FrijolConQueso, Chicharrón, Revueltas, Camarón, Loca;
        double Refrescos, JugosNaturales, SodaDeLata, SodaDeEnvase;
        int QuesoC, QuesoConLorocoC, FrijolC, FrijolConQuesoC, ChicharrónC, RevueltasC, CamarónC, LocaC;
        int RefrescosC, JugosNaturalesC, SodaDeLataC, SodaDeEnvaseC;
        double Total;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuesoC = Convert.ToInt32(textBox1.Text);
            QuesoConLorocoC = Convert.ToInt32(textBox2.Text);
            FrijolC = Convert.ToInt32(textBox3.Text);
            FrijolConQuesoC = Convert.ToInt32(textBox4.Text);
            ChicharrónC = Convert.ToInt32(textBox5.Text);
            RevueltasC = Convert.ToInt32(textBox6.Text);
            CamarónC = Convert.ToInt32(textBox7.Text);
            LocaC = Convert.ToInt32(textBox8.Text);

            Queso = QuesoC * 0.60;
            QuesoConLoroco = QuesoConLorocoC * 0.75;
            Frijol = FrijolC * 0.50;
            FrijolConQueso = FrijolConQuesoC * 0.50;
            Chicharrón = ChicharrónC * 0.50;
            Revueltas = RevueltasC * 0.50;
            Camarón = CamarónC * 1.25;
            Loca = LocaC * 2;

            RefrescosC = Convert.ToInt32(textBox10.Text);
            JugosNaturalesC = Convert.ToInt32(textBox11.Text);
            SodaDeLataC = Convert.ToInt32(textBox12.Text);
            SodaDeEnvaseC = Convert.ToInt32(textBox13.Text);

            Refrescos = RefrescosC * 0.60;
            JugosNaturales = JugosNaturalesC * 0.85;
            SodaDeLata = SodaDeLataC * 0.90;
            SodaDeEnvase = SodaDeEnvaseC * 0.75;

            Total = Queso + QuesoConLoroco + Frijol + FrijolConQueso + Chicharrón + Revueltas + Camarón + Loca + Refrescos + JugosNaturales + SodaDeLata + SodaDeEnvase;

            textBox9.Text = "$ " + Math.Round(Total);
        }
    }
}
