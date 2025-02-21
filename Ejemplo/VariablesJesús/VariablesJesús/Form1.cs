using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesJesús
{
    public partial class Form1 : Form
    {
        public Form()
        {
            InitializeComponent();
        }

        double majonchoCost;
        int CantidadMajonchos;
        double totalMajonchocost;

        private void button1_Click(object sender, EventArgs e)
        {
            majonchoCost = Convert.ToDouble(textBox2.Text);
            CantidadMajonchos = Convert.ToInt32(textBox1.Text);
            totalMajonchocost = majonchoCost * CantidadMajonchos;
            textBox3.Text = "$ " + Convert.ToInt32(totalMajonchocost);
        }
    }
}
