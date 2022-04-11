using Contracts;
using Entities;
using Repository;
using System;
using System.Windows.Forms;

namespace ApplicationInterface
{
    public partial class FrmLogin : Form
    {
        private readonly IApplicationUser _repository;
        public FrmLogin()
        {
            _repository = new RepositoryApplicationUser();
            InitializeComponent();
        }

        private void BtnInitSession_Click(object sender, EventArgs e)
        {
            LblMenssage.Text = "";
            LblMenssage.Visible = false;

            bool isOk = IsNullOrWhiteSpace(TxtUser.Text, TxtPassword.Text);

            if (!isOk)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ingrese todos los campos.";
                return;
            }

            try
            {
                ApplicationUser applicationUser = new()
                {
                    UserName = TxtUser.Text,
                    Password = TxtPassword.Text
                };

                bool isValid = _repository.CheckUserAndPassword(applicationUser);

                if (!isValid)
                {
                    LblMenssage.Visible = true;
                    LblMenssage.Text = "* Usuario o contraseña inválidos.";
                    return;
                }

                this.Hide();

                FrmMenu frmMenu = new();
                frmMenu.Show();

            }
            catch (Exception)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ocurrió un error, comuniquese con el administrador";
                return;
            }
        }

        #region Validación
        private bool IsNullOrWhiteSpace(string user, string password)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                TxtUser.Focus();
                errorUserName.SetError(TxtUser, "Campo requerido.");
                return false;
            }
            else
            {
                errorUserName.SetError(TxtUser, "");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                TxtPassword.Focus();
                errorPassword.SetError(TxtPassword, "Campo requerido.");
                return false;
            }
            else
            {
                errorPassword.SetError(TxtPassword, "");
            }

            return true;
        }

        #endregion

    }
}
