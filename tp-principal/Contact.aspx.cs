using CRUD.BusinessLayer;
using CRUD.EntityLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_principal
{
    public partial class Contact : Page
    {
        private static int idEmpleado = 0;

        EmpresaBL empresaBL = new EmpresaBL();
        EmpleadoBL empleadoBL = new EmpleadoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Obtiene el ID desde la query string
                if (Request.QueryString["idEmpleado"] != null)
                {
                    idEmpleado = Convert.ToInt32(Request.QueryString["idEmpleado"]);

                    if (idEmpleado != 0)
                    {
                        //lblTitulo.Text = "Editar Empleado"; 
                        //btnSubmit.Text = "Actualizar";

                        //Empleado empleado = empleadoBL.Obtener(idEmpleado);
                        //CargarEmpresas(empleado.IdEmpresa.ToString());

                        //// Completa los campos
                        //txtNombre.Text = empleado.Nombre;
                        //txtApellido.Text = empleado.Apellido;
                        //txtCargo.Text = empleado.Cargo;
                        //txtSueldo.Text = empleado.Sueldo.ToString("0.00");
                        //txtFechaIngreso.Text = empleado.FechaIngreso.ToString("yyyy-MM-dd");
                        //txtTelefono.Text = empleado.Telefono;
                        //txtEmail.Text = empleado.Email;
                        //ddlEstado.SelectedValue = empleado.Estado;
                    }
                    else
                    {
                        //lblTitulo.Text = "Nuevo Empleado";
                        //btnSubmit.Text = "Guardar";
                        CargarEmpresas();
                    }
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        private void CargarEmpresas(string idEmpresa = "")
        {
            List<Empresa> lista = empresaBL.Lista();

            //ddlEmpresa.DataTextField = "Nombre";
            //ddlEmpresa.DataValueField = "IdEmpresa";
            //ddlEmpresa.DataSource = lista;
            //ddlEmpresa.DataBind();

            //if (!string.IsNullOrEmpty(idEmpresa))
            //    ddlEmpresa.SelectedValue = idEmpresa;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid)
                return;

            Empleado entidad = new Empleado()
            {
                //IdEmpleado = idEmpleado,
                //Nombre = txtNombre.Text,
                //Apellido = txtApellido.Text,
                //Cargo = txtCargo.Text,
                //Sueldo = Convert.ToDecimal(txtSueldo.Text, new CultureInfo("es-AR")),
                //FechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text),
                //Telefono = txtTelefono.Text,
                //Email = txtEmail.Text,
                //IdEmpresa = Convert.ToInt32(ddlEmpresa.SelectedValue),
                //Estado = ddlEstado.SelectedValue
            };

            bool respuesta = (idEmpleado != 0)
                ? empleadoBL.Editar(entidad)
                : empleadoBL.Crear(entidad);

            if (respuesta)
                Response.Redirect("~/Default.aspx");
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                    "alert('No se pudo realizar la operación');", true);
        }
    }
}
