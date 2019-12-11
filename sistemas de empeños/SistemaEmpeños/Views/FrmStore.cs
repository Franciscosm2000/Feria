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
    public partial class FrmSales : Form
    {
        private bool articlesTabActive = true;
        private bool salePointTabActive = false;
        private bool btnSaveMouseEntered;
        public FrmSales()
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

        // Start ArticlesTab Handlers
        private void LblArticlesTab_Click(object sender, EventArgs e)
        {
            articlesTabActive = true;
            salePointTabActive = false;
            SetTabActive();
        }
        // End ArticlesTab Handlers

        // Start salePointTab Handlers
        private void LblSalePointTab_Click(object sender, EventArgs e)
        {
            salePointTabActive = true;
            articlesTabActive = false;
            SetTabActive();
        }

        private void LblArticlesCounter_Click(object sender, EventArgs e)
        {
            salePointTabActive = true;
            articlesTabActive = false;
            SetTabActive();
        }
        // End salePointTab Handlers

        // Start FrmSales Handlers
        private void FrmSales_Load(object sender, EventArgs e)
        {
            SetTabActive();
            dgvProducto.DataSource = ControlProducto.MostarDatos();
        }
        // End FrmSales Handlers

        // Start DetailsContainer_Panel1 Handlers
        private void DetailsContainer_Panel1_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblInvoicingDetailsHeader);
        }

        private void DetailsContainer_Panel1_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblInvoicingDetailsHeader);
        }
        // End DetailsContainer_Panel1 Handlers

        // Start DetailsContainer_Panel2 Handlers
        private void DetailsContainer_Panel2_Enter(object sender, EventArgs e)
        {
            SetFocusEnterEffect(lblSaleDetailsHeader);
        }

        private void DetailsContainer_Panel2_Leave(object sender, EventArgs e)
        {
            SetFocusLeaveEffect(lblSaleDetailsHeader);
        }
        // End DetailsContainer_Panel2 Handlers

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
            if(articlesTabActive && !salePointTabActive)
            {
                SetTabActiveEffect(lblArticlesTab, SistemaEmpeños.Properties.Resources.icon_product_alt);
                SetTabInactiveEffect(lblSalePointTab, SistemaEmpeños.Properties.Resources.icon_sale_point);
                SetTabInactiveEffect(lblArticlesCounter, null);
                tabControl.SelectedTab = articlesTabPage;
            } else
            {
                SetTabActiveEffect(lblArticlesCounter, null);
                SetTabActiveEffect(lblSalePointTab, SistemaEmpeños.Properties.Resources.icon_sale_point_alt);
                SetTabInactiveEffect(lblArticlesTab, SistemaEmpeños.Properties.Resources.icon_product);
                tabControl.SelectedTab = salePointTabPage;
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
        // End Miscellaneous Methods

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            index = dgvProducto.CurrentRow.Index;
            txtNombreProducto.Text = dgvProducto[0, index].Value.ToString();
            txtDescripcion.Text = dgvProducto[1, index].Value.ToString();
            txtValor.Text = dgvProducto[3, index].Value.ToString();
        }
    }
}
