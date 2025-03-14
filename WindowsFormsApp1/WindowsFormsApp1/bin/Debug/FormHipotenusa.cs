using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperacionesEnConsola;

namespace WindowsFormsApp1
{
    public partial class FormHipotenusa : Form
    {
        public FormHipotenusa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            var a = double.Parse(txtCatetoA.Text);
            var b = double.Parse(txtCatetoB.Text);
            var h = Matematica.Hipotenusa(a ,b);

            txtHipotenusa.Text = h.ToString();
        }
    }
}
