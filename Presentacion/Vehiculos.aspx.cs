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
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(tb_Marca.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para ingresar el vehiculo')", true);
            }
            else if (tb_Placa.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para ingresar el vehiculo')", true);
            }
            else if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para ingresar el vehiculo')", true);
            }
            else
            {
                try
                {
                    Vehiculo dataVehiculo = new Vehiculo();

                    dataVehiculo.Placa = tb_Placa.Text;
                    dataVehiculo.Dueño = tb_Nombre.Text;
                    dataVehiculo.Marca = tb_Marca.Text;

                    LNVehiculo vehiculo = new LNVehiculo();
                    vehiculo.IngresarVehiculo(dataVehiculo);

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

            if (tb_Marca.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para modificar el vehiculo')", true);
            }
            else if (tb_Placa.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para modificar el vehiculo')", true);
            }
            else if (tb_Nombre.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren todos los campos para modificar el vehiculo')", true);
            }
            else
            {
                try
                {
                    Vehiculo dataVehiculo = new Vehiculo();

                    dataVehiculo.Placa = tb_Placa.Text;
                    dataVehiculo.Dueño = tb_Nombre.Text;
                    dataVehiculo.Marca = tb_Marca.Text;

                    LNVehiculo vehiculo = new LNVehiculo();
                    vehiculo.ModificarVehiculo(dataVehiculo);

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
            if (tb_Placa.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren la placa para eliminar el vehiculo')", true);
            }
            else
            {
                try
                {
                    Vehiculo dataVehiculo = new Vehiculo();
                    dataVehiculo.Placa = tb_Placa.Text;
                    LNVehiculo vehiculo = new LNVehiculo();
                    vehiculo.EliminarVehiculo(dataVehiculo);

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
            if (tb_Placa.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se requieren la placa para consultar el vehiculo')", true);
            }
            else
            {
                try
                {
                    Vehiculo dataVehiculo = new Vehiculo();
                    dataVehiculo.Placa = tb_Placa.Text;
                    LNVehiculo vehiculo = new LNVehiculo();

                    tb_Nombre.Text = vehiculo.ConsultarVehiculo(dataVehiculo).Dueño;
                    tb_Marca.Text = vehiculo.ConsultarVehiculo(dataVehiculo).Marca;

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
            tb_Placa.Text = "";
            tb_Nombre.Text = "";
            tb_Marca.Text = "";
        }
    }
}