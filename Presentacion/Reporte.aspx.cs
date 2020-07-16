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
            if (DDLServicios.SelectedIndex != 0)
            {
                FillGVServicios(DDLServicios.SelectedValue);
            }
        }

        private void FillGVServicios(string selectedValue)
        {
            GVServicios.DataSource = LNServicioVehiculo.GetServicios(selectedValue);
            GVServicios.DataBind();
        }
    }
}