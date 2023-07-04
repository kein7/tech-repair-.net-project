using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Views;
using TechRepair.Models;

namespace TechRepair.Presenters
{
    public class PlanesRepPresenter
    {
        private IPlanesRepForm view;
        private IPlanesRepRepository repository;
        private BindingSource planesBindingSource;
        private IEnumerable<PlanesRepModel> planesList;

        public PlanesRepPresenter(IPlanesRepForm view, IPlanesRepRepository repository)
        {
            this.planesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += BuscarPlan;
            this.view.AddNewEvent += AñadirNuevoPlan;
            this.view.EditEvent += CargarPlanSeleccionadoEditar;
            this.view.DeleteEvent += BorrarPlanSeleccionado;
            this.view.SaveEvent += GuardarPlan;
            this.view.CancelEvent += CancelarAccion;

            this.view.SetPlanesListBindingSource(planesBindingSource);

            LoadAllPlanesList();

            this.view.Show();
        }

        private void LoadAllPlanesList()
        {
            planesList = repository.GetAll();
            planesBindingSource.DataSource = planesList;
        }

        private void BuscarPlan(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                planesList = repository.GetByValue(this.view.SearchValue);
            }
            else planesList = repository.GetAll();
            planesBindingSource.DataSource = planesList;
        }

        private void AñadirNuevoPlan(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void CargarPlanSeleccionadoEditar(object sender, EventArgs e)
        {
            var planes = (PlanesRepModel)planesBindingSource.Current;
            view.PlanId = planes.Plan_id.ToString();
            view.PlanReparacion = planes.Plan_reparacion;
            view.PlanValor = planes.Valor_plan.ToString();
            view.PlanEstado = planes.Estado_plan;
            view.PlazoEntrega = planes.Plazo_entrega.ToString();
            view.GamaId = planes.Gama_id.ToString();
            view.IsEdit = true;
        }
        private void GuardarPlan(object sender, EventArgs e)
        {
            var model = new PlanesRepModel();
            try
            {
                model.Plan_id = Convert.ToInt32(view.PlanId);
            }
            catch
            {
                
            }
            model.Plan_reparacion = view.PlanReparacion;
            model.Valor_plan = Convert.ToInt32(view.PlanValor);
            model.Estado_plan = view.PlanEstado;
            model.Plazo_entrega = Convert.ToInt32(view.PlazoEntrega);
            model.Gama_id = Convert.ToInt32(view.GamaId);
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Plan editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Plan editado correctamente";
                }
                view.IsSucessfull = true;
                LoadAllPlanesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSucessfull = false;
                view.Message= ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PlanId = "0";
            view.PlanReparacion = "";
            view.PlanValor = "0";
            view.PlanEstado = "";
            view.PlazoEntrega = "0";
            view.GamaId = "0";
        }

        private void CancelarAccion(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        
        private void BorrarPlanSeleccionado(object sender, EventArgs e)
        {
            try
            {
                var plan = (PlanesRepModel)planesBindingSource.Current;
                repository.Delete(plan.Plan_id);
                view.IsSucessfull = true;
                view.Message = "Plan eliminado correctamente";
                LoadAllPlanesList();
            }
            catch (Exception ex)
            {
                view.IsSucessfull = false;
                view.Message = "Un error ha ocurrido, no se pudo eliminar correctamente"; 
            }
        }

    }
}
