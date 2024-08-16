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
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }



        //intervalo de numeros com while, do while e for
        private void btnWhile_Click(object sender, EventArgs e)
        {
            int inicio, fim;

            inicio = int.Parse(txtInicio.Text);
            fim = int.Parse(txtFim.Text);

            txtLista.Items.Clear();
            
            while (inicio <= fim)
            {
                txtLista.Items.Add(inicio);
                inicio++;
            }


        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int inicio, fim;

            inicio = int.Parse(txtInicio.Text);
            fim = int.Parse(txtFim.Text);

            txtLista.Items.Clear();

            do {
                txtLista.Items.Add(inicio);
                inicio++;
            }
            while (inicio <= fim) ;
        }


        private void btnFor_Click(object sender, EventArgs e)
        {
            int inicio, fim;

            inicio = int.Parse(txtInicio.Text);
            fim = int.Parse(txtFim.Text);

            txtLista.Items.Clear();

            for (int i = inicio; i < fim; i++)
            {
                txtLista.Items.Add(i);
            }
        }
    }
}
