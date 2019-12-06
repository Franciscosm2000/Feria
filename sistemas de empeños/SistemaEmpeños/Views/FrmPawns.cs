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
        public FrmPawns()
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
        // End Miscellaneous Methods
    }
}
