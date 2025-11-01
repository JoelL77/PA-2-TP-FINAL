using CRUD.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataLayer
{
    public class EmpresaDL
    {

        public List<Empresa> Lista()
        {
            List<Empresa> lista = new List<Empresa>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                // Consulta a la función fn_empresas()
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_empresas()", oConexion);
                cmd.CommandType = CommandType.Text;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var empresa = new Empresa
                            {
                                IdEmpresa = Convert.ToInt32(dr["IdEmpresa"]),
                                Nombre = dr["NombreEmpresa"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                // Este campo solo existe en la función, no en la tabla original
                                CantidadEmpleados = Convert.ToInt32(dr["CantidadEmpleados"])
                            };
                            lista.Add(empresa);
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

    }
}
