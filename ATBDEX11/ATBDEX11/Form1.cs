using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBDEX11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double PesoVeiculo, AlturaVeiculo;

            PesoVeiculo = Convert.ToDouble(txtPesoVeiculo.Text);
            AlturaVeiculo = Convert.ToDouble(txtAlturaVeiculo.Text);

            if (PesoVeiculo <= 1200 && AlturaVeiculo <= 45)
            {
                MessageBox.Show("você pode prosseguir pela ponte casa verde");
            }
            else if (PesoVeiculo <= 1500 && AlturaVeiculo <= 110)
            {
                MessageBox.Show("você pode prosseguir pela ponte das bandeiras");
            }
            else if
                (PesoVeiculo <= 2000 && AlturaVeiculo <= 30)
            {
                MessageBox.Show("você pode prosseguir pela ponte do limão");
            }
            else 
            {
                MessageBox.Show("você não pode prosseguir por nenhuma ponte");
            }

        }
    }
}
