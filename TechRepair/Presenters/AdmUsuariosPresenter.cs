using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Common.Cache;
using TechRepair.Models;
using TechRepair.Views;

namespace TechRepair.Presenters
{
    public class AdmUsuariosPresenter
    {
        private IAdminUsuariosForm view;
        private IAdmUsuariosRepository repository;
        private ITecnicosRepository repositoryTecnicos;

        private IEnumerable<AdmUsuarios2Model> usuariosList;

        private BindingSource usuariosBindingSource;

        public AdmUsuariosPresenter(IAdminUsuariosForm view, IAdmUsuariosRepository repository, ITecnicosRepository repositoryTecnicos) 
        {
            this.usuariosBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;
            this.repositoryTecnicos = repositoryTecnicos;

            this.view.SearchEvent += BuscarUsuario;
            this.view.AddNewEvent += AñadirNuevoUsuario;
            this.view.EditEvent += CargarUsuarioSeleccionadoEditar;
            this.view.DeleteEvent += BorrarUsuarioSeleccionado;
            this.view.SaveUsuarioEvent += GuardarUsuario;
            this.view.SaveCargoEvent += GuardarUsuarioCargo;
            this.view.SaveTecnicoEvent += GuardarTecnico;

            this.view.SetUsuariosListBindingSource(usuariosBindingSource);

            LoadAllUsuariosList();

            this.view.Show();
        }

        private void LoadAllUsuariosList()
        {
            usuariosList = repository.GetAllUsuarios();
            usuariosBindingSource.DataSource = usuariosList;
        }

        private void BuscarUsuario(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                usuariosList = repository.GetByValueUsuario(this.view.SearchValue);
            }
            else usuariosList = repository.GetAllUsuarios();
            usuariosBindingSource.DataSource = usuariosList;
        }
        private void AñadirNuevoUsuario(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CargarUsuarioSeleccionadoEditar(object sender, EventArgs e)
        {
            var usuario = (AdmUsuarios2Model)usuariosBindingSource.Current;
            view.CargoActual = usuario.Cargo;
            view.UsuarioCargo = usuario.UserName;
        }
        private void GuardarUsuarioCargo(object sender, EventArgs e)
        {
            try
            {
                var usuario = (AdmUsuarios2Model)usuariosBindingSource.Current;
                usuario.Cargo = getIdFromCargoEnum(view.ModificarCargo).ToString();

                new Common.ModelDataValidation().Validate(usuario);
                repository.EditUserCargo(usuario);
                UserLoginCache.CargoId = Convert.ToInt32(usuario.Cargo);
                usuario.Cargo = ((Cargos)UserLoginCache.CargoId).ToString();
                view.Message = "Usuario editado correctamente";
                view.IsSucessfull = true;
                CleanViewModCargoFields();
            }
            catch(Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = ex.Message;
            }
        }

        private void GuardarUsuario(object sender, EventArgs e)
        {
            var modelAdmUsuario = new AdmUsuariosModel();
            try
            {
                modelAdmUsuario.UserName = view.Usuario;
                modelAdmUsuario.Password = view.PasswordUsuario;
                modelAdmUsuario.Nombre = view.NombreUsuario;
                modelAdmUsuario.ApellidoPaterno = view.ApellidoPaternoUsuario;
                modelAdmUsuario.ApellidoMaterno = view.ApellidoMaternoUsuario;
                modelAdmUsuario.Cargo = getIdFromCargoEnum(view.Cargo).ToString();
                modelAdmUsuario.Email = view.EmailUsuario;

                new Common.ModelDataValidation().Validate(modelAdmUsuario);
                repository.AddUser(modelAdmUsuario);
                view.Message = "Usuario agregado correctamente";
                view.IsSucessfull = true;
                LoadAllUsuariosList();
                CleanViewAgregarUsuarioFields();
            }
            catch(Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = ex.Message;
            }
        }
        private void GuardarTecnico(object sender, EventArgs e)
        {
            var modelAdmUsuario = new AdmUsuariosModel();
            var modelTecnico = new TecnicosModel();

            try
            {
                modelTecnico.Nombres = view.NombreTecnico;
                modelTecnico.Apellido_paterno = view.ApellidoPaternoTecnico;
                modelTecnico.Apellido_materno = view.ApellidoMaternoTecnico;
                modelTecnico.Rut_tecnico = Convert.ToInt32(view.RutTecnico);
                modelTecnico.Email = view.EmailTecnico;
                modelTecnico.Telefono = Convert.ToInt32(view.TelefonoTecnico);

                new Common.ModelDataValidation().Validate(modelTecnico);
                repositoryTecnicos.Add(modelTecnico);

                modelAdmUsuario.UserName = view.UsuarioTecnico;
                modelAdmUsuario.Password = view.PasswordTecnico;
                modelAdmUsuario.Nombre = view.NombreTecnico;
                modelAdmUsuario.ApellidoPaterno = view.ApellidoPaternoTecnico;
                modelAdmUsuario.ApellidoMaterno = view.ApellidoMaternoTecnico;
                modelAdmUsuario.Cargo = getIdFromCargoEnum(view.Cargo).ToString();
                modelAdmUsuario.Email = view.EmailTecnico;

                new Common.ModelDataValidation().Validate(modelAdmUsuario);
                repository.AddUser(modelAdmUsuario);
                view.Message = "Usuario agregado correctamente";
                view.IsSucessfull = true;
                LoadAllUsuariosList();
                CleanViewAgregarTecnicoFields();
            }
            catch (Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = ex.Message;
            }
        }

        private void BorrarUsuarioSeleccionado(object sender, EventArgs e)
        {
            try
            {
                var model = (AdmUsuarios2Model)usuariosBindingSource.Current;
                if (getIdFromCargoEnum(model.Cargo) == Convert.ToInt32(Cargos.Tecnico))
                {
                    int tecnicoId = repositoryTecnicos.GetTecnicoId(model.Email);
                    repositoryTecnicos.Delete(tecnicoId);
                }
                repository.DeleteUser(model.UserId);
                view.IsSucessfull = true;
                view.Message = "Usuario eliminado correctamente";
                LoadAllUsuariosList();
            }
            catch(Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = "Un error ha ocurrido, no se pudo eliminar correctamente " + ex;
            }
        }

        private int getIdFromCargoEnum(string value)
        {
            Cargos cargo;
            Enum.TryParse(value, out cargo);
            int id = (int)cargo;
            return id;
        }

        private void CleanViewModCargoFields()
        {
            this.view.CargoActual = "";
            this.view.ModificarCargo = "";
            this.view.UsuarioCargo = "";
        }
        private void CleanViewAgregarUsuarioFields()
        {
            this.view.Usuario = "";
            this.view.PasswordUsuario = "";
            this.view.NombreUsuario = "";
            this.view.ApellidoPaternoUsuario = "";
            this.view.ApellidoMaternoUsuario = "";
            this.view.EmailUsuario = "";
        }
        private void CleanViewAgregarTecnicoFields()
        {
            this.view.UsuarioTecnico = "";
            this.view.NombreTecnico = "";
            this.view.ApellidoPaternoTecnico = "";
            this.view.ApellidoMaternoTecnico = "";
            this.view.PasswordTecnico = "";
            this.view.RutTecnico = "";
            this.view.TelefonoTecnico = "";
            this.view.EmailTecnico = "";
        }


    }
}
