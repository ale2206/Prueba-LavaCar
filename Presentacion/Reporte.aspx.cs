using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDLServicos();
            }
        }

        private void FillDDLServicos()
        {
            DDLServicios.DataSource = LNServicioVehiculo.FillDDLServicio();
            DDLServicios.DataTextField = "Descripción";
            DDLServicios.DataValueField = "ID_Servicio"; 
            DDLServicios.DataBind();
            DDLServicios.Items.Insert(0, "Seleccione un valor");
        }

        protected void DDLServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLServicios.SelectedValue.Equals("Seleccione un valor"))
            {
                Limpiar();
            }
            else
            {
                if (DDLServicios.SelectedIndex != 0)
                {
                    FillGVServicios(DDLServicios.SelectedValue);
                    FillGVVehiculoServicios(DDLServicios.SelectedValue);
                }
            }       
        }

        private void FillGVVehiculoServicios(string selectedValue)
        {
            GVVehiculosServicios.DataSource = LNServicioVehiculo.GetVehiculosServicios(selectedValue);
            GVVehiculosServicios.DataBind();
        }

        private void FillGVServicios(string selectedValue)
        {
            GVServicios.DataSource = LNServicioVehiculo.GetServicios(selectedValue);
            GVServicios.DataBind();
        }

        protected void Limpiar()
        {
            GVServicios.DataSource = null;
            GVServicios.DataBind();

            GVVehiculosServicios.DataSource = null;
            GVVehiculosServicios.DataBind();
        }
    }
}