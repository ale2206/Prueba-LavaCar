using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Servicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para ingresar el servicio')", true);
            }
            else if (tb_Precio.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para ingresar el servicio')", true);
            }
            else
            {
                try
                {
                    Entidades.Servicios dataServicios = new Entidades.Servicios();

                    dataServicios.Descripción = tb_Nombre.Text;
                    dataServicios.Monto = Convert.ToInt32(tb_Precio.Text);

                    LNServicio servicio = new LNServicio();
                    servicio.IngresarServicio(dataServicios);

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a ingresado con exito')", true);
                    Limpiar();
                }

                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un problema al ingresar, inteta mas tarde')", true);
                }
            }    
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para modificar el servicio')", true);
            }
            else if (tb_Precio.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para modificar el servicio')", true);
            }
            else
            {
                try
                {
                    Entidades.Servicios dataServicios = new Entidades.Servicios();

                    dataServicios.Descripción = tb_Nombre.Text;
                    dataServicios.Monto = Convert.ToInt32(tb_Precio.Text);

                    LNServicio servicio = new LNServicio();
                    servicio.ModificarServicio(dataServicios);

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a modificado con exito')", true);
                    Limpiar();
                }

                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un problema al modificar, inteta mas tarde')", true);
                }
            }      
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requiere nombre o descripcion para eliminar el servicio')", true);
            }
            else
            {
                try
                {
                    Entidades.Servicios dataServicios = new Entidades.Servicios();
                    dataServicios.Descripción = tb_Nombre.Text;
                    LNServicio servicio = new LNServicio();
                    servicio.EliminarServicio(dataServicios);

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a eliminado con exito')", true);
                    Limpiar();
                }

                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un problema, inteta mas tarde')", true);
                }
            }  
        }

        protected void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requiere nombre o descripcion para consultar el servicio')", true);
            }
            else
            {
                try
                {
                    Entidades.Servicios dataServicio = new Entidades.Servicios();
                    dataServicio.Descripción = tb_Nombre.Text;
                    LNServicio servicio = new LNServicio();

                    tb_Precio.Text = servicio.ConsultarServicio(dataServicio).Monto.ToString();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a consultado con exito')", true);

                }

                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un problema, inteta mas tarde')", true);
                }
            }    
        }

        protected void Limpiar()
        {
            tb_Nombre.Text = "";
            tb_Precio.Text = "";
        }
    }
}