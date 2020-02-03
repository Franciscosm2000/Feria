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
    public partial class FrmEmployees : Form
    {
        private bool btnSaveMouseEntered;

        public FrmEmployees()
        {
            InitializeComponent();
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
        // Ends btnClose Handlers

        // Start MainContainer_Panel1 Handlers
        private void MainContainer_Panel1_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblPanel1Header);
        }

        private void MainContainer_Panel1_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblPanel1Header);
        }
        // End  MainContainer_Panel1 Handlers

        // Start MainContainer_Panel2 Handlers
        private void MainContainer_Panel2_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblPanel2Header);
        }

        private void MainContainer_Panel2_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblPanel2Header);
        }
        // End MainContainer_Panel2 Handlers

        // Start btnSave Handlers
        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            SetBtnSaveActiveEffect();
            btnSaveMouseEntered = true;
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            SetBtnSaveNormalEffect();
            btnSaveMouseEntered = false;
        }

        private void BtnSave_MouseDown(object sender, MouseEventArgs e)
        {
            SetBtnSaveActiveEffect();
            btnSave.FlatAppearance.BorderSize = 0;
        }

        private void BtnSave_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnSaveMouseEntered)
            {
                SetBtnSaveActiveEffect();
            }
            else
            {
                SetBtnSaveNormalEffect();
            }
            btnSave.FlatAppearance.BorderSize = 1;
        }

        private void BtnSave_KeyDown(object sender, KeyEventArgs e)
        {
            SetBtnSaveActiveEffect();
            btnSave.FlatAppearance.BorderSize = 0;
        }

        private void BtnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if(btnSaveMouseEntered)
                {
                    SetBtnSaveActiveEffect();
                } else
                {
                    SetBtnSaveNormalEffect();
                }
                btnSave.FlatAppearance.BorderSize = 1;
            }
        }
        // End btnSave Handlers

        // Start btnAccount Handlers
        private void BtnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount account = new FrmAccount();
            account.ShowDialog();
        }
        // End btnAccount Handlers

        // Start FrmEmployees Handlers
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
            dgvEmpleados.DataSource = ControlEmpleado.MostrarDatos();
        }
        // End FrmEmployees Handlers

        // Start Miscellaneous Methods
        private void SetFocusEnterEffect(Label label)
        {
            label.BackColor = Color.FromArgb(255, 197, 8);
            label.ForeColor = Color.FromArgb(34, 30, 31);
        }

        private void SetFocusLeaveEffect(Label label)
        {
            label.BackColor = Color.FromArgb(34, 30, 31);
            label.ForeColor = Color.WhiteSmoke;
        }

        private void SetBtnSaveActiveEffect()
        {
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Image = SistemaEmpeños.Properties.Resources.icon_save_alt;
        }

        private void SetBtnSaveNormalEffect()
        {
            btnSave.ForeColor = Color.FromArgb(34, 30, 31);
            btnSave.Image = SistemaEmpeños.Properties.Resources.icon_save;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Equals("") || txtCedula.Text == null || txtDireccion.Text.Equals("") || txtDireccion.Text == null
                ||txtTel.Text.Equals("") || txtTel.Text == null
                )
            {
                MessageBox.Show("LLENAR TODOS LOS CAMPOS");
            }
            else
            {

                if (txtNombre.Text == null || txtNombre.Text.Equals("") || txtApellido.Text == null || txtApellido.Text.Equals(""))
                {
                    MessageBox.Show("Error");
                }
                else
                {

                    FrmAccount f = new FrmAccount(txtCorreo.Text);
                    f.Show();

                    ControlEmpleado con = new ControlEmpleado();

                    string[] nombre = (txtNombre.Text).Split(' ');
                    string[] apellido = (txtApellido.Text).Split(' ');

                    if (apellido.Length == 1) 
                        con.AddEmpleado(nombre[0], nombre[1], apellido[0], " ", txtTel.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);
                    else
                        con.AddEmpleado(nombre[0], nombre[1], apellido[0], apellido[1], txtTel.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);

                }
            }

        }
        //Editar
        private void button1_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;

            string[] nombre = (txtNombre.Text).Split(' ');
            string[] apellido = (txtApellido.Text).Split(' ');

            ControlEmpleado cont = new ControlEmpleado();
            cont.ActualizarDatos(nombre[0], nombre[1], apellido[0], apellido[1], txtTel.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = ControlEmpleado.MostrarDatos();

        }
        //PARA MANDAR LOS DATOS A SUS CAMPOS PARA LA EDICION
        private void MandarDatosCampos(object sender, DataGridViewCellEventArgs e)
        {
            int poc = 0; //
            txtCedula.Enabled = false;
            poc = dgvEmpleados.CurrentRow.Index; //octenemos la posicion\
            txtCedula.Text = dgvEmpleados[3, poc].Value.ToString();
            txtNombre.Text = dgvEmpleados[1, poc].Value.ToString();
            txtApellido.Text = dgvEmpleados[2, poc].Value.ToString();
            txtDireccion.Text = dgvEmpleados[4, poc].Value.ToString();
            txtTel.Text = dgvEmpleados[5, poc].Value.ToString();
            txtCorreo.Text = dgvEmpleados[6, poc].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmAccount f = new FrmAccount();
            f.Show();
        }
        //Cambiar Estado
        private void button2_Click(object sender, EventArgs e)
        {
            ControlEmpleado c = new ControlEmpleado();
            c.CambiarEstado(txtCedula.Text);
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = ControlEmpleado.MostrarDatos();
        }

        private void BuscarEmpleado(object sender, KeyPressEventArgs e)
        {
            ControlEmpleado c = new ControlEmpleado();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = c.buscarDatos(txtFilter.Text);
        }






        // End Miscellaneous Methods
    }
}
