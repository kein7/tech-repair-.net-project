using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Models;
using TechRepair.Views;

namespace TechRepair.Presenters
{
    public class OrdenesPresenter
    {
        private IOrdenesForm view;

        private IOrdenesRepository repository;
        private IGamasRepository repositoryGamas;
        private IEquiposCelularesRepository repositoryTelefonos;
        private IPlanesRepRepository repositoryPlanes;
        private IClientesRepository repositoryClientes;
        private IDireccionesRepository repositoryDirecciones;
        private ITercerosRepository repositoryTerceros;
        private ITecnicosRepository repositoryTecnicos;

        private BindingSource ordenesBindingSource;
        private BindingSource regionesBindingSource;
       
        private IEnumerable<OrdenesModel> ordenesList;
        private List<string> regionesList;
      
        public OrdenesPresenter(IOrdenesForm view, IOrdenesRepository repository, IGamasRepository repositoryGamas, IEquiposCelularesRepository repositoryTelefonos, 
            IPlanesRepRepository repositoryPlanes, IClientesRepository repositoryClientes, IDireccionesRepository repositoryDirecciones, ITercerosRepository repositoryTerceros, ITecnicosRepository repositoryTecnicos)
        {
            this.ordenesBindingSource = new BindingSource();
            this.regionesBindingSource = new BindingSource();

            this.view = view;

            this.repository = repository;
            this.repositoryGamas = repositoryGamas;
            this.repositoryTelefonos = repositoryTelefonos;
            this.repositoryPlanes = repositoryPlanes;
            this.repositoryClientes = repositoryClientes;
            this.repositoryDirecciones = repositoryDirecciones;
            this.repositoryTerceros = repositoryTerceros;
            this.repositoryTecnicos = repositoryTecnicos;

            this.view.SearchEvent += BuscarOrden;
            this.view.AddNewEvent += AñadirNuevaOrden;
            this.view.EditEvent += CargarOrdenSeleccionadaEditar;
            this.view.DeleteEvent += BorrarOrdenSeleccionada;
            this.view.SaveEvent += GuardarOrden;

            this.view.SetOrdenesListBindingSource(ordenesBindingSource);

            LoadAllOrdenesList();

            this.view.Show();
        }

        public void LoadRegion(string comuna)
        {
            regionesList = repositoryDirecciones.GetRegionByComuna(comuna);
            regionesBindingSource.DataSource = regionesList;
        }

        private void LoadAllOrdenesList()
        {
            ordenesList = repository.GetAllOrdenes();
            ordenesBindingSource.DataSource = ordenesList;
        }

        private void BuscarOrden(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                ordenesList = repository.GetByValueOrdenes(this.view.SearchValue);
            }
            else ordenesList = repository.GetAllOrdenes();
            ordenesBindingSource.DataSource = ordenesList;
        }

        private void AñadirNuevaOrden(object sender, EventArgs e)
        {
            this.view.RefreshRegionCbx += ActualizarRegionCbx;
            LoadRegion("1");
            view.SetRegionesListBindingSource(regionesBindingSource);
            view.IsEdit = false;
        }
        private void CargarOrdenSeleccionadaEditar(object sender, EventArgs e)
        {
            var orden = (OrdenesModel)ordenesBindingSource.Current;
            var idOrden = repository.GetByValueIdOrdenes(orden.Orden_id.ToString()).ElementAt(0);
            view.OrdenId = orden.Orden_id.ToString();

            var telefono = repositoryTelefonos.GetByValueTelefonos(idOrden.Telefono.ToString()).ElementAt(0);
            var marca = repositoryTelefonos.GetMarcaTelefono(telefono.Marca).ElementAt(0);
            var gamaId = repositoryGamas.GetByValueGamas(telefono.Gama).ElementAt(0);

            view.Marca = marca.Marca;
            view.Gama = gamaId.Tipo_Gama;
            view.NumSerie = telefono.Numero_serie;
            view.Modelo = telefono.Modelo;
            view.Color = telefono.Color;

            var clientes = repositoryClientes.GetByValueClientes(idOrden.Cliente.ToString()).ElementAt(0);
            view.RutCliente = clientes.Rut.ToString();
            view.NombresCliente = clientes.Nombres;
            view.ApellidoPatCliente = clientes.Apellido_paterno;
            view.ApellidoMatCliente = clientes.Apellido_materno;
            view.NumTelefonoCliente = clientes.Telefono_contacto.ToString();
            view.EmailCliente = clientes.Email;

            var direcciones = repositoryDirecciones.GetByValueDirecciones(clientes.Direccion_id.ToString()).ElementAt(0);
            var region = repositoryDirecciones.GetRegionByComuna(direcciones.Comuna.ToString()).ElementAt(0);
            view.DireccionId = direcciones.Direccion_id.ToString();
            view.DireccionCliente = direcciones.Calle;
            view.ComunaCliente = direcciones.Comuna;
            //view.RegionCliente = region;
            view.NumCalleCliente = direcciones.Num_calle;
            view.NumDptoCliente = direcciones.Num_dpto;

            var terceros = repositoryTerceros.GetByValueTerceros(idOrden.Tercero.ToString()).ElementAt(0);
            view.RutTercero = terceros.Rut_tercero.ToString();
            view.NombresTercero = terceros.Nombres_tercero;
            view.ApellidoPatTercero = terceros.Apellido_paterno;
            view.ApellidoMatTercero = terceros.Apellido_materno;
            view.CodigoTercero = terceros.Codigo_tercero.ToString();

            var planes = repositoryPlanes.GetByValuePlanes(idOrden.Plan.ToString()).ElementAt(0);
            view.PlanReparacion = planes.Plan_reparacion;

            this.view.RefreshRegionCbx += ActualizarRegionCbx;

            view.SetRegionesListBindingSource(regionesBindingSource);
            LoadRegion(direcciones.Comuna);
            
            view.IsEdit = true;
        }

        private void ActualizarRegionCbx(object sender, EventArgs e)
        {
            try
            { 
                var direcciones = repositoryDirecciones.GetRegionByComuna(view.ComunaCliente).ElementAt(0);
                view.RegionCliente = direcciones;

                LoadRegion(view.ComunaCliente);

                view.IsSucessfull = true;
            }
            catch(Exception ex)
            {
                //view.IsSucessfull = false;
                //view.Message = ex.Message;
            }
        }

        private void GuardarOrden(object sender, EventArgs e)
        {
            var modelOrdenes = new OrdenesModel();
            var modelEquiposCel = new EquiposCelularesModel();
            var modelClientes = new ClientesModel();
            var modelDirecciones = new DireccionesModel();
            var modelTerceros = new TercerosModel();
            
            try
            {
                var gamaId = repositoryGamas.GetByValueGamas(view.Gama).ElementAt(0);
                var marca = repositoryTelefonos.GetMarcaTelefono(view.Marca).ElementAt(0);
                modelEquiposCel.Gama = gamaId.Gama_ID.ToString();
                modelEquiposCel.Marca = marca.Marca;
                modelEquiposCel.Numero_serie = view.NumSerie;
                modelEquiposCel.Modelo = view.Modelo;
                modelEquiposCel.Color = view.Color;
                
                var comunaId = repositoryDirecciones.GetComunaId(view.ComunaCliente, view.RegionCliente).ElementAt(0);
                modelDirecciones.Calle = view.DireccionCliente;
                modelDirecciones.Num_calle = view.NumCalleCliente;
                modelDirecciones.Num_dpto = view.NumDptoCliente;
                modelDirecciones.Comuna = comunaId.Comuna;
                modelDirecciones.Region = comunaId.Region;
                
                try
                {
                    modelDirecciones.Direccion_id = Convert.ToInt32(view.DireccionId);
                    repositoryDirecciones.Edit(modelDirecciones);
                }
                catch
                {
                    modelDirecciones.Direccion_id = repositoryDirecciones.Add(modelDirecciones);
                }
                /*                
                if (direcciones != null)
                {
                    modelDirecciones.Direccion_id = Convert.ToInt32(view.DireccionId);
                    repositoryDirecciones.Edit(modelDirecciones);
                }
                else
                {
                    repositoryDirecciones.Add(modelDirecciones);
                }
                */
                modelClientes.Rut = Convert.ToInt32(view.RutCliente);
                modelClientes.Nombres = view.NombresCliente;
                modelClientes.Apellido_paterno = view.ApellidoPatCliente;
                modelClientes.Apellido_materno = view.ApellidoMatCliente;
                modelClientes.Telefono_contacto = Convert.ToInt32(view.NumTelefonoCliente);
                modelClientes.Email = view.EmailCliente;
                modelClientes.Direccion_id = modelDirecciones.Direccion_id;

                try
                {
                    var tmp = repositoryTelefonos.GetByValueTelefonos(view.NumSerie).ElementAt(0);
                    modelEquiposCel.Telefonos_id = tmp.Telefonos_id;
                    repositoryTelefonos.Edit(modelEquiposCel);
                }
                catch
                {
                    repositoryTelefonos.Add(modelEquiposCel);
                }

                try
                {
                    var tmp = repositoryClientes.GetByValueClientes(view.RutCliente).ElementAt(0);
                    modelClientes.Cliente_id = Convert.ToInt32(tmp.Cliente_id);
                    
                    repositoryClientes.Edit(modelClientes);
                }
                catch
                {
                    repositoryClientes.Add(modelClientes);
                }

                if (view.RutTercero != "")
                {
                    modelTerceros.Rut_tercero = Convert.ToInt32(view.RutTercero);
                    modelTerceros.Nombres_tercero = view.NombresTercero;
                    modelTerceros.Apellido_paterno = view.ApellidoPatTercero;
                    modelTerceros.Apellido_materno = view.ApellidoMatTercero;
                    modelTerceros.Codigo_tercero = view.CodigoTercero;
                    try
                    {
                        var tmp = repositoryTerceros.GetByValueTerceros(view.RutTercero).ElementAt(0);
                        modelTerceros.Tercero_id = Convert.ToInt32(tmp.Tercero_id);
                        repositoryTerceros.Edit(modelTerceros);
                    }
                    catch
                    {
                        repositoryTerceros.Add(modelTerceros);
                    }
                    var terceroId = repositoryTerceros.GetByValueTerceros(view.RutTercero).ElementAt(0);
                    modelOrdenes.Tercero = terceroId.Tercero_id.ToString();
                }
                else
                    modelOrdenes.Tercero = null;

                var planId = repositoryPlanes.GetPlanId(view.PlanReparacion, gamaId.Gama_ID.ToString()).ElementAt(0);
                var telefonoId = repositoryTelefonos.GetByValueTelefonos(view.NumSerie).ElementAt(0);
                var clienteId = repositoryClientes.GetByValueClientes(view.RutCliente).ElementAt(0);
                var direcciones = repositoryDirecciones.GetByValueDirecciones(modelDirecciones.Direccion_id.ToString()).ElementAt(0);

                modelOrdenes.Tecnico = "1";
                modelOrdenes.Estado = "1";
                modelOrdenes.Telefono = telefonoId.Telefonos_id.ToString();
                modelOrdenes.Cliente = clienteId.Cliente_id.ToString();
                modelOrdenes.Plan = planId.Plan_id.ToString();
                
                modelOrdenes.Fecha_orden = DateTime.UtcNow.ToString("MM-dd-yyyy");

                new Common.ModelDataValidation().Validate(modelEquiposCel);
                new Common.ModelDataValidation().Validate(modelClientes);
                new Common.ModelDataValidation().Validate(modelDirecciones);
                if (view.RutTercero != "")
                    new Common.ModelDataValidation().Validate(modelTerceros);
                
                if (view.IsEdit)
                {
                    modelOrdenes.Orden_id = Convert.ToInt32(view.OrdenId);
                    var ordenId = repository.GetByValueIdOrdenes(view.OrdenId).ElementAt(0);
                    new Common.ModelDataValidation().Validate(modelOrdenes);

                    repository.Edit(modelOrdenes);
                    view.Message = "Orden editada correctamente";
                }
                else
                {
                    repository.Add(modelOrdenes);
                    view.Message = "Orden guardada correctamente";
                }
                view.IsSucessfull = true;
                LoadAllOrdenesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = ex.Message;
            }
            
        }
        private void CleanViewFields()
        {
            
            view.Marca = "";
            view.Gama = "";
            view.NumSerie = "";
            view.Modelo = "";
            view.Color = "";

            view.RutCliente = "";
            view.NombresCliente = "";
            view.ApellidoPatCliente = "";
            view.ApellidoMatCliente = "";
            view.NumTelefonoCliente = "";
            view.EmailCliente = "";

            view.PlanReparacion = "";

            view.DireccionCliente = "";
            view.ComunaCliente = "";
            view.NumCalleCliente = "";
            view.NumDptoCliente = "";

            view.RutTercero = "";
            view.NombresTercero = "";
            view.ApellidoPatTercero = "";
            view.ApellidoMatTercero = "";
            view.CodigoTercero = "";
        }
        private void CancelarAccion(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void BorrarOrdenSeleccionada(object sender, EventArgs e)
        {
            try
            {
                var orden = (OrdenesModel)ordenesBindingSource.Current;
                repository.Delete(orden.Orden_id);
                view.IsSucessfull = true;
                view.Message = "Plan eliminado correctamente";
                LoadAllOrdenesList();
            }
            catch (Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = "Un error ha ocurrido, no se pudo eliminar correctamente " + ex;
            }
        }

        
    }
}
