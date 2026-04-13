using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManassero20260401_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DECLARACION DE VARIABLES GLOBALES
        string varCodigo;
        string varNombre;
        int varStock;
        int varPrecio;
        string varCategoria;
        string varDescripcion;

        private void lblPrecio_Click(object sender, EventArgs e)
        {
            //inicar las variables
            varCodigo = "";
            varNombre = "";
            varStock = 0;
            varPrecio = 0;
            varCategoria = "";
            varDescripcion = "";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el código",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Complete el nombre","Advertencia",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else
                {
                    if (txtPrecio.Text == "")
                    {
                        MessageBox.Show("Complete el precio","Advertencia",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtPrecio.Focus();
                    }
                    else
                    {

                    }
                    if (cmbCategoría.Text == "")
                    {
                        MessageBox.Show("Complete la categoría",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbCategoría.Focus();
                    }
                    else
                    {

                    }
                    if (txtDescripción.Text == "")
                    {
                        MessageBox.Show("Complete el descripción",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescripción.Focus();
                    }
                    else
                    {

                        if (txtStock.Text == "")
                        {
                            MessageBox.Show("Complete el Stock",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStock.Focus();
                        }
                        else
                        {
                            lblRegistroIG.Text = txtCodigo.Text + '/' + txtNombre.Text + '/'
                            + txtStock.Text + '/' + txtPrecio.Text + '/' + cmbCategoría.Text + '/' + txtDescripción.Text;

                            MessageBox.Show("Producto registrado con éxito");
                        }
                    }
                }
            }
        }

        private void lblRegistroIG_Click(object sender, EventArgs e)
        {
           
        }

        private void lblRegistroVariables_Click(object sender, EventArgs e)
        {

        }
    }
}
