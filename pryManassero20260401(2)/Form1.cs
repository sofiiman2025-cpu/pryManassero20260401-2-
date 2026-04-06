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
        string varCodigo = "";
        string varNombre = "";
        int varStock = 0;
        int varPrecio = 0;
        string varCategoria = "";
        string varDescripcion = "";

        private void lblPrecio_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblRegistroIG.Text = txtCodigo.Text + '/' + txtNombre.Text + '/'
                + txtStock.Text + '/' + txtPrecio.Text + '/' + cmbCategoría.Text + '/' + txtDescripción.Text;


            //pasar los datos a variable y luego mostrarlos
            varCategoria = 

        }

        private void lblRegistroIG_Click(object sender, EventArgs e)
        {
           
        }
    }
}
