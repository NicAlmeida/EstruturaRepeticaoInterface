using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeticaoComInterface
{
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        //tabuada     
        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int numero, resultado, contador=0;

            numero = int.Parse(txtNumero.Text);

            txtLista.Items.Clear();

            for (int i = contador; i <= 10; i++)
            {
                resultado = i * numero;

                txtLista.Items.Add(numero + " X " + i + " = " + resultado);
   
            }
        }
    }
}
