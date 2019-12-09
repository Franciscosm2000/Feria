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
    public partial class FrmAccount : Form
    {
        private int locationX;
        private int locationY;
        private bool mausePressed;
        private bool btnSaveMouseEntered;

        public FrmAccount()
        {
            InitializeComponent();
        }

        // Start TitleBar Handlers
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            locationX = e.X;
            locationY = e.Y;
            mausePressed = true;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mausePressed = false;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mausePressed)
            {
                this.Top = this.Top + (e.Y - locationY);
                this.Left = this.Left + (e.X - locationX);
            }
        }
        // End TitleBar Handlers

        // Start btnClose Handlers
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        // End btnClose Handlers

        // Start btnSave Handlers
        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.FromArgb(34, 30, 31);
            btnSaveMouseEntered = true;
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.FromArgb(255, 197, 8);
            btnSaveMouseEntered = false;
        }

        private void BtnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnSave.ForeColor = Color.FromArgb(34, 30, 31);
            }
        }

        private void BtnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnSaveMouseEntered)
            {
                btnSave.ForeColor = Color.FromArgb(34, 30, 31);
            }
            else
            {
                btnSave.ForeColor = Color.FromArgb(255, 197, 8);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO
        }
        // End btnSave Handlers

        // Start txtUsername Handlers
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            HidePlaceHolder(txtUsername, "USUARIO", false);
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            ShowPlaceHolder(txtUsername, "USUARIO", false);
        }
        // End txtUsername Handlers

        // Start txtEmail Handlers
        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            HidePlaceHolder(txtEmail, "CORREO ELECTRÓNICO", false);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            ShowPlaceHolder(txtEmail, "CORREO ELECTRÓNICO", false);
        }
        // End txtEmail Handlers

        // Start txtPassword Handlers
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            HidePlaceHolder(txtPassword, "CONTRASEÑA", true);
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            ShowPlaceHolder(txtPassword, "CONTRASEÑA", true);
        }
        // End txtPassword Handlers

        // Start txtConfirmPassword Handlers
        private void TxtConfirmPassword_Enter(object sender, EventArgs e)
        {
            HidePlaceHolder(txtConfirmPassword, "CONFIRMAR CONTRASEÑA", true);
        }

        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            ShowPlaceHolder(txtConfirmPassword, "CONFIRMAR CONTRASEÑA", true);
        }
        // End txtConfirmPassword Handlers

        // Start Miscellaneous Methods
        private void ShowPlaceHolder(TextBox textBox, string placeholder, bool passwordField)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.DimGray;
                if (passwordField)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void HidePlaceHolder(TextBox textBox, string placeholder, bool passwordField)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.LightGray;
                if (passwordField)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }


        // End Miscelaneous Methods
    }
}
