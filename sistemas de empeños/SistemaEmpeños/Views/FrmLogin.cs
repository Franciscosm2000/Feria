using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpeños.CONTROLADOR;

namespace SistemaEmpeños
{
    public partial class FrmLogin : Form
    {
        private int locationX;
        private int locationY;
        private bool mausePressed;
        private bool btnLoginMouseEntered;

        public FrmLogin()
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
            if(mausePressed)
            {
                this.Top = this.Top + (e.Y - locationY);
                this.Left = this.Left + (e.X - locationX);
            }
        }
        // End TitleBar Handlers

        // Start TitleBar Buttons Handlers
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // End TitleBar Buttons Handlers

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

        // Start btnLogin Handlers
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            SetBtnLoginActiveEffect();
            btnLoginMouseEntered = true;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            SetBtnLoginNormalEffect();
            btnLoginMouseEntered = false;
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                SetBtnLoginActiveEffect();
            }
        }

        private void BtnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if(btnLoginMouseEntered)
            {
                SetBtnLoginActiveEffect();
            } else
            {
                SetBtnLoginNormalEffect();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "USUARIO")
            {
                HideErrorMessage(lblUsernameErrorMessage);
                if (txtPassword.Text != "CONTRASEÑA")
                {
                    HideErrorMessage(lblPasswordErrorMessage);
                    //Instanciamos objeto para validar el usuario
                    UserModelo acceder = new UserModelo();
                    //var validarLogin = acceder.LoginUsser(txtUsername.Text,txtPassword.Text);
                    //          if (validarLogin == true)
                    //          {
                    //              FrmMain dashboard = new FrmMain();
                    ////pendiente         //dashboard.FormClosed += CerrarCesion;
                    //              dashboard.Show();
                    //              this.Hide();
                    //          }

                    //          else
                    //          {
                    //              MessageBox.Show("Incorrecto usuario o contraseña no existe.");
                    //              txtPassword.Text = "";
                    //              txtUsername.Text = "";
                    //          }

                    FrmMain dashboard = new FrmMain();
                    //pendiente         //dashboard.FormClosed += CerrarCesion;
                    dashboard.Show();
                    this.Hide();

                }
                else
                {
                    ShowErrorMessage(lblPasswordErrorMessage, "Por favor, ingrese su contraseña");
                }
            }
            else
            {
                ShowErrorMessage(lblUsernameErrorMessage, "Por favor, ingrese su usuario");
            }
        }
        // End btnLogin Handlers

        // Start Miscellaneous Methods Miscellaneous
        private void ShowPlaceHolder(TextBox textBox, string placeholder, bool passwordField)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.DimGray;
                if(passwordField)
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
                if(passwordField)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void ShowErrorMessage(Label label, string message)
        {
            if(!label.Visible)
            {
                label.Text = "      " + message;
                label.Visible = true;
            }
        }

        private void HideErrorMessage(Label label)
        {
            if(label.Visible)
            {
                label.Visible = false;
            }
        }

        private void SetBtnLoginActiveEffect()
        {
            btnLogin.ForeColor = Color.FromArgb(34, 30, 31);
            btnLogin.Image = SistemaEmpeños.Properties.Resources.icon_login_alt;
        }

        private void SetBtnLoginNormalEffect()
        {
            btnLogin.ForeColor = Color.FromArgb(255, 197, 8);
            btnLogin.Image = SistemaEmpeños.Properties.Resources.icon_login;
        }
        // End Miscellaneous Methods

        //Metodo para cierre de cesion
        private void CerrarCesion(Object sender, FormClosedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblPasswordErrorMessage.Visible = false;
            lblUsernameErrorMessage.Visible = false;
            this.Show();
            txtUsername.Focus();
        }

        private void linkLostPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserModelo clave = new UserModelo();
            MessageBox.Show(clave.restraurarPass(txtUsername.Text));
            
        }
    }
}
