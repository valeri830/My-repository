using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentHousing_Project
{
    public partial class LoginForm : Form
    {     
        private Dictionary<string, string> users;
        public LoginForm()
        {
            InitializeComponent();
            SetFormColors();

            this.users = new Dictionary<string, string>
            {
                {"admin", "admin123" },
                {"student", "student123" }
            };
        }

        private void SetFormColors()
        {
            formPanel.BackColor = Color.FromArgb(200, ColorPalette.LightBlue);
            lblLogo.ForeColor = ColorPalette.DarkBlue;
            lblUsername.ForeColor = ColorPalette.SemiDarkBlue;
            lblPassword.ForeColor = ColorPalette.SemiDarkBlue;
            tbxUsername.ForeColor = ColorPalette.SemiDarkBlue;
            tbxPassword.ForeColor = ColorPalette.SemiDarkBlue;
            tbxUsername.BackColor = ColorPalette.White;
            tbxPassword.BackColor = ColorPalette.White;
            btnLogin.ForeColor = ColorPalette.SemiDarkBlue;
            btnLogin.BackColor = ColorPalette.LightBlue;
            btnLogin.FlatAppearance.BorderColor = ColorPalette.DarkBlue;
        }

        public void LoginUser()
        {
            string usernameInput = tbxUsername.Text;
            string passwordInput = tbxPassword.Text;

            if (this.users.ContainsKey(usernameInput))
            {
                if (this.users[usernameInput] == passwordInput)
                {
                    bool isAdmin;
                    if (usernameInput == "admin")
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }

                    MainForm mainForm = new MainForm(isAdmin);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    throw new ArgumentException("Invalid username/password");
                }
            }
            else
            {
                throw new ArgumentException("Invalid username/password");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUser();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
                lblErrorMessage.Visible = true;
            }
        }
    }
}
