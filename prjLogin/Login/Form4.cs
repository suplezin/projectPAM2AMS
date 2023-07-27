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
    public partial class frmCadPedido : Form
    {
        public frmCadPedido()
        {
            InitializeComponent();
        }

        private void frmCadPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumPed.Text = "";
            txtQuant.Text = "";
            lblSubTot.Text = "            ";
            txtValItem.Text = "";
            mskDataPed.Text = "";
            cbSelecPed.Text = "";
        }

        private void btnAddPed_Click(object sender, EventArgs e)
        {
            Variaveis.quant = Convert.ToInt32(txtQuant.Text);
            Variaveis.valUnit = Convert.ToDouble(txtValItem.Text);
            Variaveis.valSub = Variaveis.quant * Variaveis.valUnit;
            lblSubTot.Text = "R$ " + Convert.ToString(Variaveis.valSub);
            Variaveis.valTot = Variaveis.valTot + Variaveis.valSub;
            lblTotal.Text = "R$ " + Convert.ToString(Variaveis.valTot);
        }
    }
}
