using SistemaEmpeños.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpeños
{
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        //    dgvCliente.DataSource = null;
            dgvCliente.DataSource = ControladorCliente.MostrarDatos();
        }

        // Start btnClose Handlers
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = SistemaEmpeños.Properties.Resources.icon_drop;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = SistemaEmpeños.Properties.Resources.icon_fix;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MainContainer_Panel1_Enter(object sender, EventArgs e)
        {

        }

        private void MainContainer_Panel1_Leave(object sender, EventArgs e)
        {

        }

        private void MainContainer_Panel2_Enter(object sender, EventArgs e)
        {

        }

        private void MainContainer_Panel2_Leave(object sender, EventArgs e)
        {

        }
        // Ends btnClose Handlers

        private void FrmClients_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
            dgvCliente.DataSource = ControladorCliente.MostrarDatos();
        }

        private void PasarDatosCampo(object sender, DataGridViewCellEventArgs e)
        {
            int poc = 0; //
            txtCedula.Enabled = false;
            poc = dgvCliente.CurrentRow.Index; //octenemos la posicion\
            txtCedula.Text = dgvCliente[2, poc].Value.ToString();
            txtNombre.Text = dgvCliente[0, poc].Value.ToString();
            txtApellido.Text = dgvCliente[1, poc].Value.ToString();
            txtDireccion.Text = dgvCliente[3, poc].Value.ToString();
            txtTel.Text = dgvCliente[4, poc].Value.ToString();
            txtCorr.Text = dgvCliente[5, poc].Value.ToString();
        }
        //Actualizar Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;

            string[] nombre = (txtNombre.Text).Split(' ');
            string[] apellido = (txtApellido.Text).Split(' ');

            ControladorCliente cont = new ControladorCliente();
            cont.ActualizarCliente(nombre[0], nombre[1], apellido[0], apellido[1], txtTel.Text, txtCorr.Text, txtCedula.Text, txtDireccion.Text);
        
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = ControlEmpleado.MostrarDatos();
        }
        //Busqueda
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = ControladorCliente.buscardato(txtFilter.Text);
        }
    }
}
