using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpeños.CONTROLADOR;

namespace SistemaEmpeños
{
    public partial class FrmMain : Form
    {
        private int locationX;
        private int locationY;
        private bool mausePressed;
        private bool sideMenuDisplayed = true;
        private bool btnPawnsMouseEntered;
        private bool btnClientsMouseEntered;
        private bool btnStoreMouseEntered;
        private bool btnEmployeesMouseEntered;
        private bool btnReportsMouseEntered;

        public FrmMain()
        {
            InitializeComponent();

            if (DatosInicioSecion.cargo == Cargos.Admnistrador)
            {

            }
            else if (DatosInicioSecion.cargo == Cargos.Empleado)
            {
                btnStore.Enabled = false;
                btnReports.Enabled = false;
                btnEmployees.Enabled = false;
            }
        }

        // Start TitleBar Handlers
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mausePressed = true;
            locationX = e.X;
            locationY = e.Y;
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point(locationX, locationY);
            btnRes.Visible = false;
            btnMax.Visible = true;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            locationX = this.Location.X;
            locationY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // End TitleBar Buttons Handlers

        // Start btnSideMenu Handlers
        private void BtnSideMenu_Click(object sender, EventArgs e)
        {
            if(sideMenuDisplayed)
            {
                tmHideMenu.Enabled = true;
            } else
            {
                tmShowMenu.Enabled = true;
            }
        }
        // End btnSideMenu Handlers

        // Start Menu Timers Handlers
        private void TmHideMenu_Tick(object sender, EventArgs e)
        {
            if (menuSideBar.Width <= 60)
            {
                tmHideMenu.Enabled = false;
                sideMenuDisplayed = false;
            }
            else
            {
                menuSideBar.Width -= 38;
            }
        }

        private void TmShowMenu_Tick(object sender, EventArgs e)
        {
            if (menuSideBar.Width >= 250)
            {
                tmShowMenu.Enabled = false;
                sideMenuDisplayed = true;
            }
            else
            {
                menuSideBar.Width += 95;
            }
        }
        // End Menu Timers Handlers

        // Start btnPawns Handlers
        private void BtnPawns_MouseEnter(object sender, EventArgs e)
        {
            SetMenuButtonMouseEnterEffect(out btnPawnsMouseEntered, btnPawns,
                SistemaEmpeños.Properties.Resources.icon_pawns_alt);
        }

        private void BtnPawns_MouseLeave(object sender, EventArgs e)
        {
            SetMenuButtonMouseLeaveEffect(out btnPawnsMouseEntered, btnPawns,
                SistemaEmpeños.Properties.Resources.icon_pawns);
        }

        private void BtnPawns_KeyDown(object sender, KeyEventArgs e)
        {
            SetMenuButtonKeyDownEffect(e.KeyCode, btnPawns,
                SistemaEmpeños.Properties.Resources.icon_pawns_alt);
        }

        private void BtnPawns_KeyUp(object sender, KeyEventArgs e)
        {
            SetMenuButtonHoverEffect(btnPawnsMouseEntered, btnPawns,
                SistemaEmpeños.Properties.Resources.icon_pawns,
                SistemaEmpeños.Properties.Resources.icon_pawns_alt);
        }

        private void BtnPawns_Click(object sender, EventArgs e)
        {
            AddWindow<FrmPawns>();
        }
        // End btnPawns Handlers

        // Start btnClients Handlers
        private void BtnClients_MouseEnter(object sender, EventArgs e)
        {
            SetMenuButtonMouseEnterEffect(out btnClientsMouseEntered, btnClients,
                SistemaEmpeños.Properties.Resources.icon_clients_alt);
        }

        private void BtnClients_MouseLeave(object sender, EventArgs e)
        {
            SetMenuButtonMouseLeaveEffect(out btnClientsMouseEntered, btnClients,
                SistemaEmpeños.Properties.Resources.icon_clients);
        }

        private void BtnClients_KeyDown(object sender, KeyEventArgs e)
        {
            SetMenuButtonKeyDownEffect(e.KeyCode, btnClients,
                SistemaEmpeños.Properties.Resources.icon_clients_alt);
        }

        private void BtnClients_KeyUp(object sender, KeyEventArgs e)
        {
            SetMenuButtonHoverEffect(btnClientsMouseEntered, btnClients,
                SistemaEmpeños.Properties.Resources.icon_clients,
                SistemaEmpeños.Properties.Resources.icon_clients_alt);
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            AddWindow<FrmClients>();
        }
        // End btnClients Handlers

        // Start btnStore Handlers
        private void BtnStore_MouseEnter(object sender, EventArgs e)
        {
            SetMenuButtonMouseEnterEffect(out btnStoreMouseEntered, btnStore,
                SistemaEmpeños.Properties.Resources.icon_store_alt);
        }

        private void BtnStore_MouseLeave(object sender, EventArgs e)
        {
            SetMenuButtonMouseLeaveEffect(out btnStoreMouseEntered, btnStore,
                SistemaEmpeños.Properties.Resources.icon_store);
        }

        private void BtnStore_KeyDown(object sender, KeyEventArgs e)
        {
            SetMenuButtonKeyDownEffect(e.KeyCode, btnStore,
                SistemaEmpeños.Properties.Resources.icon_store_alt);
        }

        private void BtnStore_KeyUp(object sender, KeyEventArgs e)
        {
            SetMenuButtonHoverEffect(btnStoreMouseEntered, btnStore,
                SistemaEmpeños.Properties.Resources.icon_store,
                SistemaEmpeños.Properties.Resources.icon_store_alt);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            AddWindow<FrmSales>();
        }
        // End btnStore Handlers

        // Start btnEmployees Handlers
        private void BtnEmployees_MouseEnter(object sender, EventArgs e)
        {
            SetMenuButtonMouseEnterEffect(out btnEmployeesMouseEntered, btnEmployees,
                SistemaEmpeños.Properties.Resources.icon_employees_alt);
        }

        private void BtnEmployees_MouseLeave(object sender, EventArgs e)
        {
            SetMenuButtonMouseLeaveEffect(out btnEmployeesMouseEntered, btnEmployees,
                SistemaEmpeños.Properties.Resources.icon_employees);
        }

        private void BtnEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            SetMenuButtonKeyDownEffect(e.KeyCode, btnEmployees,
                SistemaEmpeños.Properties.Resources.icon_employees_alt);
        }

        private void BtnEmployees_KeyUp(object sender, KeyEventArgs e)
        {
            SetMenuButtonHoverEffect(btnEmployeesMouseEntered, btnEmployees,
                SistemaEmpeños.Properties.Resources.icon_employees,
                SistemaEmpeños.Properties.Resources.icon_employees_alt);
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            AddWindow<FrmEmployees>();
        }
        // End btnEmployees Handlers

        // Start btnReports Handlers
        private void BtnReports_MouseEnter(object sender, EventArgs e)
        {
            SetMenuButtonMouseEnterEffect(out btnReportsMouseEntered, btnReports,
                SistemaEmpeños.Properties.Resources.icon_reports_alt);
        }

        private void BtnReports_MouseLeave(object sender, EventArgs e)
        {
            SetMenuButtonMouseLeaveEffect(out btnReportsMouseEntered, btnReports,
                SistemaEmpeños.Properties.Resources.icon_reports);
        }

        private void BtnReports_KeyDown(object sender, KeyEventArgs e)
        {
            SetMenuButtonKeyDownEffect(e.KeyCode, btnReports,
                SistemaEmpeños.Properties.Resources.icon_reports_alt);
        }

        private void BtnReports_KeyUp(object sender, KeyEventArgs e)
        {
            SetMenuButtonHoverEffect(btnReportsMouseEntered, btnReports,
                SistemaEmpeños.Properties.Resources.icon_reports,
                SistemaEmpeños.Properties.Resources.icon_reports_alt);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            AddWindow<FrmReports>();
        }
        // End btnReports Handlers

        // Start Miscellaneus Methods
        private void AddWindow<CustomForm>() where CustomForm : Form, new()
        {
            // Busca en los controles del panel windowsContainer el primer control que sea de tipo CustomForm
            Form window = windowsContainer.Controls.OfType<CustomForm>().FirstOrDefault();

            if(window == null)
            {
                window = new CustomForm();
                window.TopLevel = false;
                window.Dock = DockStyle.Fill;
                windowsContainer.Controls.Add(window);
                windowsContainer.Tag = window;
                window.Show();
                window.BringToFront();
            } else
            {
                window.BringToFront();
            }
        }

        private void SetMenuButtonMouseEnterEffect(out bool condition, Button button, Image iconAlt)
        {
            button.ForeColor = Color.FromArgb(255, 197, 8);
            button.Image = iconAlt;
            condition = true;
        }

        private void SetMenuButtonMouseLeaveEffect(out bool condition, Button button, Image icon)
        {
            button.ForeColor = Color.FromArgb(34, 30, 31);
            button.Image = icon;
            condition = false;
        }

        private void SetMenuButtonKeyDownEffect(Keys pressedKey, Button button, Image iconAlt)
        {
            if (pressedKey == Keys.Space)
            {
                button.ForeColor = Color.FromArgb(255, 197, 8);
                button.Image = iconAlt;
            }
        }

        private void SetMenuButtonHoverEffect(bool condition, Button button, Image icon, Image iconAlt)
        {
            if(condition)
            {
                button.ForeColor = Color.FromArgb(255, 197, 8);
                button.Image = iconAlt;
            } else
            {
                button.ForeColor = Color.FromArgb(34, 30, 31);
                button.Image = icon;
            }
        }
        // End Miscellaneus Methods
    }
}
