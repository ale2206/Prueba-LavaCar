using Entidades;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class ServicioVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDLServico();
                FillDDLVehiculo();
            }
        }

        private void FillDDLVehiculo()
        {
            DDLVehiculo.DataSource = LNVehiculo.FillDDLVehiculo();
            DDLVehiculo.DataTextField = "Placa";
            DDLVehiculo.DataValueField = "ID_Vehiculo";
            DDLVehiculo.DataBind();
            DDLVehiculo.Items.Insert(0, "Seleccione un valor");
        }

        private void FillDDLServico()
        {
            DDLServicio.DataSource = LNServicioVehiculo.FillDDLServicio();
            DDLServicio.DataTextField = "Descripción";
            DDLServicio.DataValueField = "ID_Servicio";
            DDLServicio.DataBind();
            DDLServicio.Items.Insert(0, "Seleccione un valor");
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (DDLServicio.SelectedValue.Equals("Seleccione un valor"))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se debe seleccionar un servicio')", true);
            }
            else if (DDLVehiculo.SelectedValue.Equals("Seleccione un valor"))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se debe seleccionar un vehiculo')", true);
            }
            else
            {
                try
                {
                    Vehiculo_Servicio dataVehiculo_Servicio = new Vehiculo_Servicio();

                    dataVehiculo_Servicio.ID_Vehiculo = Convert.ToInt32(DDLVehiculo.SelectedValue);
                    dataVehiculo_Servicio.ID_Servicio = Convert.ToInt32(DDLServicio.SelectedValue);

                    LNServicioVehiculo vehiculo_servicio = new LNServicioVehiculo();
                    vehiculo_servicio.IngresarVehiculoServicio(dataVehiculo_Servicio);

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a ingresado con exito')", true);
                    Limpiar();
                }

                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un problema al ingresar, inteta mas tarde')", true);
                }
            }
            
        }

        protected void Limpiar()
        {
            DDLServicio.Text = "Seleccione un valor";
            DDLVehiculo.Text = "Seleccione un valor";
        }
    }
}