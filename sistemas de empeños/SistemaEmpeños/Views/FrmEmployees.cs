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
            for (int i = 0; i < 10; i++)
            {
                dataSet1.Tables["Empleado"].Rows.Add(i, "000-000000-0000A", "000000-0", "Foo", "Bar", "MALE", "foo bar, foo bar, bar foo", "88888888", 50000);
            }
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
        // End Miscellaneous Methods
    }
}
