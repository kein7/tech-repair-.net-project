using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Common.Cache;
using TechRepair.Models;
using TechRepair.Views;

namespace TechRepair.Presenters
{
    public class ProfilePresenter
    {
        private IProfileForm view;

        private IAdmUsuariosRepository repositoryAdminUsuarios;
        
        public ProfilePresenter(IProfileForm view,IAdmUsuariosRepository repositoryAdminUsuarios) 
        {
            this.view = view;
            this.repositoryAdminUsuarios = repositoryAdminUsuarios;
            this.view.EditEvent += CargarUsuario;
            this.view.SaveEvent += GuardarDatosUsuario;

            this.view.Show();
        }

        private void CargarUsuario(object sender, EventArgs e)
        {
            view.Usuario = UserLoginCache.Usuario;
            view.Nombre = UserLoginCache.Nombre;
            view.ApellidoPaterno = UserLoginCache.ApellidoPaterno;
            view.ApellidoMaterno = UserLoginCache.ApellidoMaterno;
            view.Email = UserLoginCache.Email;
        }

        private void GuardarDatosUsuario(object sender, EventArgs e)
        {
            try
            {
                var modelUsuarios = new AdmUsuariosModel();

                modelUsuarios.UserId = Convert.ToInt32(UserLoginCache.UserId);
                modelUsuarios.UserName = view.Usuario;
                modelUsuarios.Nombre = view.Nombre;
                modelUsuarios.ApellidoPaterno = view.ApellidoPaterno;
                modelUsuarios.ApellidoMaterno = view.ApellidoMaterno;
                modelUsuarios.Email = view.Email;
                modelUsuarios.Password = view.PassActual;

                bool validandoContra = repositoryAdminUsuarios.ValidatePassword(modelUsuarios.UserId, modelUsuarios.Password);

                if (validandoContra == true && ConfirmandoContraseñas(view.Password,view.ConfirmarPass) == true && view.ActualizaContra.Equals(true))
                {
                    new Common.ModelDataValidation().Validate(modelUsuarios);

                    modelUsuarios.Password = view.Password;
                    repositoryAdminUsuarios.EditUser(modelUsuarios);
                    view.Message = "La edición de los datos ha sido realizada correctamente";
                    view.IsSucessfull = true;
                    CleanViewFields();

                    UserLoginCache.Usuario = modelUsuarios.UserName;
                    UserLoginCache.Nombre = modelUsuarios.Nombre;
                    UserLoginCache.ApellidoPaterno = modelUsuarios.ApellidoPaterno;
                    UserLoginCache.ApellidoMaterno = modelUsuarios.ApellidoMaterno;
                    UserLoginCache.Email = modelUsuarios.Email;

                    view.UsuarioLb = UserLoginCache.Usuario;
                    view.NombreLb = UserLoginCache.Nombre;
                    view.ApellidoLb = UserLoginCache.ApellidoPaterno + " " + UserLoginCache.ApellidoMaterno;
                }
                else if(validandoContra == true && view.ActualizaContra.Equals(false))
                {
                    new Common.ModelDataValidation().Validate(modelUsuarios);

                    repositoryAdminUsuarios.EditUser(modelUsuarios);
                    view.Message = "La edición de los datos ha sido realizada correctamente";
                    view.IsSucessfull = true;
                    CleanViewFields();

                    UserLoginCache.Usuario = modelUsuarios.UserName;
                    UserLoginCache.Nombre = modelUsuarios.Nombre;
                    UserLoginCache.ApellidoPaterno = modelUsuarios.ApellidoPaterno;
                    UserLoginCache.ApellidoMaterno = modelUsuarios.ApellidoMaterno;
                    UserLoginCache.Email = modelUsuarios.Email;

                    view.UsuarioLb = UserLoginCache.Usuario;
                    view.NombreLb = UserLoginCache.Nombre;
                    view.ApellidoLb = UserLoginCache.ApellidoPaterno + " " + UserLoginCache.ApellidoMaterno;
                }
                else
                {
                    if (repositoryAdminUsuarios.ValidatePassword(modelUsuarios.UserId, modelUsuarios.Password) == false)
                        view.Message = "La contraseña no es correcta, intente de nuevo";
                    else
                        view.Message = "Las contraseñas no coinciden, intente de nuevo";
                }
            }
            catch(Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = ex.Message;
            }
            

        }
        private bool ConfirmandoContraseñas(string contraseña, string confContraseña)
        {
            try
            {
                if (contraseña.Equals(confContraseña))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        private void CleanViewFields()
        {
            view.Usuario = "";
            view.Nombre = "";
            view.ApellidoPaterno = "";
            view.ApellidoMaterno = "";
            view.Email = "";
            view.Password = "";
            view.ConfirmarPass = "";
            view.PassActual = "";
        }
    }
}
