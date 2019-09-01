using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txthorastrabajadas.Text);
            double valorhora = double.Parse(txtvalorhora.Text);
            double total = horastrabajadas * valorhora;
            if (total > 750000) {
                MessageBox.Show("el salario gana mas del minimo");
                lbltotalsalario.Text = total.ToString();
                lbltotalsalario.Visible = true;
            } else {
                total = (total * 0.20)+total;
                lbltotalsalario.Text = "$"+ Convert.ToDecimal(total).ToString("N0");
                lbltotalsalario.Visible = true;
            }


        }
    }
}
