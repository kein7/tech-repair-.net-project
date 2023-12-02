using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Common.Cache;
using TechRepair.Models;
using TechRepair.Views;

namespace TechRepair.Presenters
{
    public class LoginPresenter
    {
        private ILoginForm view;
        private ILoginRepository repository;
        private readonly string sqlConnection;
        public LoginPresenter(ILoginForm view, ILoginRepository repository, string sqlConnection) 
        {
            this.view = view;
            this.repository = repository;
            this.sqlConnection = sqlConnection;
            this.view.ValidateLoginEvent += ValidateLogin;
            this.view.RecoverPassEvent += RecoverPassword;

            this.view.Show();
        }

        private void RecoverPassword(object sender, EventArgs e)
        {
            PasswordRecoverForm passwordRecoverForm = new PasswordRecoverForm();
            new PasswordRecoverPresenter(passwordRecoverForm,repository,sqlConnection);
            passwordRecoverForm.ShowDialog();
        }

        private void ValidateLogin(object sender, EventArgs e)
        {
            if ("Usuario" != view.Usuario && "Password" != view.Password)
            {
                var validLogin = repository.ValidateLogin(view.Usuario, view.Password);
                if(validLogin == true) 
                {
                    MainForm mainForm = new MainForm();
                    new MainPresenter(mainForm, sqlConnection);
                    MessageBox.Show("Bienvenido " + UserLoginCache.Nombre + " " + UserLoginCache.ApellidoPaterno + " " + UserLoginCache.ApellidoMaterno);
                    mainForm.Show();
                    mainForm.FormClosed += Logout;
                    this.view.Hide();
                    view.IsSucessfull = true;
                }
                else
                {
                    MsgError("Usuario o Contraseña incorrecto(s). \n        Intente de nuevo. ");
                    view.SetDefaultPasswordTextbox();
                    view.SetFocusToUsername();
                    view.IsSucessfull = false;
                }
            }
            else if (view.Usuario == "Usuario" && view.Password != "Password")
            {
                view.IsSucessfull = false;
                MsgError("Porfavor ingrese el usuario");
            }
            else if (view.Usuario != "Usuario" && view.Password == "Password")
            {
                view.IsSucessfull = false;
                MsgError("Porfavor ingrese la contraseña");
            }
            else if(view.Usuario == "Usuario" && view.Password == "Password")
            {
                view.IsSucessfull = false;
                MsgError("Porfavor ingrese el usuario y contraseña");
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            view.LogOut();
        }
        private void MsgError(string msg)
        {
            view.MessageError = "        " + msg;
        }
    }
}
