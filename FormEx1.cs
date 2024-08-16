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
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }


        //exibir numeros até 20 usando while, do while e for
        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            txtLista.Items.Clear();


            while(i <= 20)
            {
                txtLista.Items.Add(i);
                i++;
            }

            MessageBox.Show("Fim da execução do while!");


            
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            txtLista.Items.Clear();

            do
            {
                txtLista.Items.Add(i);
                i++;
            }

            while (i <= 20);

            MessageBox.Show("Fim da execução do While!");
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int i;

            txtLista.Items.Clear();
            
            for(i = 0; i <= 20; i++)
            {
                txtLista.Items.Add(i);
            }

            MessageBox.Show("Fim da execução do For!");
        }
    }
}
    