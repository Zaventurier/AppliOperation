using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonAppliBureau
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtValeur1.Text = "";
            txtValeur2.Text = "";
            txtResultat.Text = "";
            lblOperation.Text = "";
            pxDepart.Text = "";
            txtPour.Text = "";
            PourRes.Text="";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) + float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "+";
            }
            catch { };
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) * float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "x";
            }
            catch { };
        }

        private void txtvaleur1_TextChanged(object sender, EventArgs e)
        {
            txtResultat.Text = "";
            lblOperation.Text = "";
            AnnuleOperation();
        }

        private void txtvaleur2_TextChanged(object sender, EventArgs e)
        {
            txtResultat.Text = "";
            lblOperation.Text = "";
        }
        private void AnnuleOperation()
        {
            lblOperation.Text = "";
            txtResultat.Text = "";
        }

        private void btnSoustraire_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) - float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "-";
            }
            catch { };
        }

        private void btnDiviser_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) / float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "x";
            }
            catch { };
        }

        private void pxDepart_TextChanged(object sender, EventArgs e)
        {
            PourRes.Text = "";
        }

        private void txtPour_TextChanged(object sender, EventArgs e)
        {
            PourRes.Text = "";
        }

        private void btnPour_Click(object sender, EventArgs e)
        {
            float coeff;
            coeff = ((Convert.ToSingle(pxDepart.Text) * Convert.ToSingle(txtPour.Text))/100);
            PourRes.Text = Convert.ToString(coeff);
                // (float.Parse(pxDepart.Text) * float.Parse(txtPour.Text)).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
