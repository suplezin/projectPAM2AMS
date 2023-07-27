using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmCadrastoCliente : Form
    {
        public frmCadrastoCliente()
        {
            InitializeComponent();
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCEP.Text = "";
            mskDataNasc.Text = "";
            mskFone.Text = "";
            txtCodCliente.Focus();
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
