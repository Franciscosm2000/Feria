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
    public partial class FrmPawns : Form
    {
        private bool pawnsTabActive = true;
        private bool newPawnTabActive = false;
        private bool payTabActive = false;
        private bool btnSaveMouseEntered;

        Validaciones v = new Validaciones();
        public FrmPawns()
        {
            InitializeComponent();
            v.SOLONUMEROS(txtNcontrato);
            //Inicializacion de cmbESTADO
            cmbEstado.Items.Add("HABILITADDO");
            cmbEstado.Items.Add("DESHABILITADDO");
            //INICIALIZACION DE CMBFRECUENCIA
            cmbFrecuencia_.Items.Add("Mensual");
            cmbFrecuencia_.Items.Add("Quinsenal");
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

        // Start tabs Handlers
        private void LblPawnsTab_Click(object sender, EventArgs e)
        {
            pawnsTabActive = true;
            newPawnTabActive = false;
            payTabActive = false;
            SetTabActive();
        }

        private void LblnewPawnTab_Click(object sender, EventArgs e)
        {
            pawnsTabActive = false;
            newPawnTabActive = true;
            payTabActive = false;
            SetTabActive();
        }

        private void LblPayTab_Click(object sender, EventArgs e)
        {
            pawnsTabActive = false;
            newPawnTabActive = false;
            payTabActive = true;
            SetTabActive();
        }
        // End tabs Handlers

        // Start FrmPawns Handlers
        private void FrmPawns_Load(object sender, EventArgs e)
        {
            SetTabActive();
        }
        // End FrmPawns Handlers

        // Start Headers Handlers
        private void SplitContainer1_Panel1_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblPawnInfoHeader);
        }

        private void SplitContainer1_Panel1_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblPawnInfoHeader);
        }

        private void SplitContainer2_Panel2_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblProductInfoHeader);
        }

        private void SplitContainer2_Panel2_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblProductInfoHeader);
        }

        private void SplitContainer2_Panel1_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblCustomerInfoHeader);
        }

        private void SplitContainer2_Panel1_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblCustomerInfoHeader);
        }
        // End Headers Handlers

        // Start btnInvoice Handlers
        private void BtnInvoice_MouseEnter(object sender, EventArgs e)
        {
            SetBtnInvoiceActiveEffect();
            btnSaveMouseEntered = true;
        }

        private void BtnInvoice_MouseLeave(object sender, EventArgs e)
        {
            SetBtnInvoiceNormalEffect();
            btnSaveMouseEntered = false;
        }

        private void BtnInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            SetBtnInvoiceActiveEffect();
            btnInvoice.FlatAppearance.BorderSize = 0;
        }

        private void BtnInvoice_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnSaveMouseEntered)
            {
                SetBtnInvoiceActiveEffect();
            }
            else
            {
                SetBtnInvoiceNormalEffect();
            }
            btnInvoice.FlatAppearance.BorderSize = 1;
        }

        private void BtnInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            SetBtnInvoiceActiveEffect();
            btnInvoice.FlatAppearance.BorderSize = 0;
        }

        private void BtnInvoice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (btnSaveMouseEntered)
                {
                    SetBtnInvoiceActiveEffect();
                }
                else
                {
                    SetBtnInvoiceNormalEffect();
                }
                btnInvoice.FlatAppearance.BorderSize = 1;
            }
        }
        // End btnInvoice Handlers

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

        private void SetTabActiveEffect(Label label, Image image)
        {
            label.BackColor = Color.FromArgb(255, 197, 8);
            label.ForeColor = Color.FromArgb(34, 30, 31);
            label.Image = image;
        }

        private void SetTabInactiveEffect(Label label, Image image)
        {
            label.BackColor = Color.FromArgb(34, 30, 31);
            label.ForeColor = Color.WhiteSmoke;
            label.Image = image;
        }

        private void SetTabActive()
        {
            if (pawnsTabActive && !newPawnTabActive && !payTabActive)
            {
                SetTabActiveEffect(lblPawnsTab, null);
                SetTabInactiveEffect(lblnewPawnTab, null);
                SetTabInactiveEffect(lblPayTab, null);
                tabControl.SelectedTab = pawnsTabPage;
            }
            else if (!pawnsTabActive && newPawnTabActive && !payTabActive)
            {
                SetTabInactiveEffect(lblPawnsTab, null);
                SetTabActiveEffect(lblnewPawnTab, null);
                SetTabInactiveEffect(lblPayTab, null);
                tabControl.SelectedTab = newPawnTabPage;
            }
            else if (!pawnsTabActive && !newPawnTabActive && payTabActive)
            {
                SetTabInactiveEffect(lblPawnsTab, null);
                SetTabInactiveEffect(lblnewPawnTab, null);
                SetTabActiveEffect(lblPayTab, null);
                tabControl.SelectedTab = payTabPage;
            }
        }

        private void SetBtnInvoiceActiveEffect()
        {
            btnInvoice.ForeColor = Color.WhiteSmoke;
            btnInvoice.Image = SistemaEmpeños.Properties.Resources.icon_invoice_alt;
        }

        private void SetBtnInvoiceNormalEffect()
        {
            btnInvoice.ForeColor = Color.FromArgb(34, 30, 31);
            btnInvoice.Image = SistemaEmpeños.Properties.Resources.icon_invoice;
        }
        //Evento para buscar por contrato 
        private void txtNcontrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            MostrarTabla(txtNcontrato.Text);
        }
        //Evento cuando se mueve el focco

        // End Miscellaneous Methods

       //PARA MOSTRAR DATOS DE LA TABLA SEGUN EL CAMPO
        public void MostrarTabla(string a)
        {
            dgvPawns.DataSource = null;
            dgvPawns.DataSource = ControlEmpeno.mostrar(a);
        }

        //MANDAR DATOS
        private void MandarDatos(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPawns[0, 0].Value.ToString().Equals("") || dgvPawns[0, 0].Value.ToString() == null) { }
            else
            {
                int poc = 0; //
                txtNcontrato.Enabled = false;
                poc = dgvPawns.CurrentRow.Index; //octenemos la posicion\
                txtNcontrato.Text = dgvPawns[0, poc].Value.ToString();
                dateInicio.Text = dgvPawns[1, poc].Value.ToString();
                txtEmpleado.Text = dgvPawns[2, poc].Value.ToString();
                txtMonto.Text = dgvPawns[6, poc].Value.ToString();
                txtCuota.Text = dgvPawns[7, poc].Value.ToString();
                cmbFrecuencia.Text = dgvPawns[8, poc].Value.ToString();
                dateVencimiento.Text = dgvPawns[5, poc].Value.ToString();
            }
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            MostrarTabla(dateInicio.Text.ToString());
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarTabla(cmbEstado.SelectedText);
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarTabla(cmbEmpleado.SelectedText);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarTabla(cmbCliente.SelectedText);
        }

        //PENDIENTE
        private void dateRango1_ValueChanged(object sender, EventArgs e)
        {
            if (dateRango1.Value.Date > DateTime.Now.Date)
            {
                dateRango1.Value = DateTime.Now.Date;
                MessageBox.Show("La fecha es mayor a la actual");
            }
            else
            {
                //string FECHA = string.Format( ,"yyyy-MM-dd");
                MessageBox.Show(dateRango1.Value.Date.ToString());
            }
           // MostrarTabla(dateRango1.Text);
        }

        private void dateRango2_ValueChanged(object sender, EventArgs e)
        {
            // MostrarTabla(dateRango2.Text);
            if (dateRango2.Value.Date < DateTime.Now.Date)
            {
                dateRango2.Value = DateTime.Now.Date;
                MessageBox.Show("La fecha es menor a la actual");
            }
            MessageBox.Show(dateRango2.Text);
        }

        //Evento para mostrar los datos en el comboBox
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {
            cmbEmpleado.ValueMember = "Id_Empleado";
            cmbEmpleado.DisplayMember = "Nombres";
            cmbEmpleado.DataSource = ControlEmpleado.MostrarDatos();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //datos empleado
            idEmpleado.DataSource = ControlEmpleado.MostrarDatos();
            idEmpleado.ValueMember = "Id_Empleado";
            idEmpleado.DisplayMember = "Nombres";
          
            //datos producto 
            idTipo.DataSource = ControlTipoProducto.Most();
            idTipo.DisplayMember = "Tipo";
            idTipo.ValueMember = "Id_Tipo_Producto";
            
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            
                ControlEmpeno c = new ControlEmpeno();
            c.InsertarDatos(txtNombre.Text, txtNombre2.Text, txtApellido.Text, txtApellido2.Text, txttel.Text, txtCorreo_.Text, 
                txtCedula.Text, txtDireccion.Text,Convert.ToInt32( idTipo), Convert.ToDouble(txtValor.Text), txtDescripcion.Text,
                txtNombreProducto.Text, Convert.ToDouble (txtValor), cmbEstado.Text, Convert.ToInt32(idEmpleado.Text), Convert.ToDouble(txtMonto_.Text)
                , Convert.ToInt32(txtCuota.Text), cmbFrecuencia_.Text, dateVencimiento_.Value.Date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ControlEmpeno.mostrarTablaAmortizacion("2", txtMonto_.Text);

            var cell = dt.Rows[0][4];
            cuota.Text = cell.ToString() ;

           // MessageBox.Show(cuota.Text = Convert.ToString(ControlEmpeno.mostrarTablaAmortizacion("2", txtMonto_.Text).Rows[0]));
            
        }
    }
}
