using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD.EntityLayer;
using System.Data;
using System.Data.SqlClient;


namespace CRUD.DataLayer
{
    public class EmpleadoDL
    {

        public List<Empleado> Lista()
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_empleados()", oConexion);
                cmd.CommandType = CommandType.Text;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                Nombre = dr["NombreEmpleado"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Cargo = dr["Cargo"].ToString(),
                                Sueldo = Convert.ToDecimal(dr["Sueldo"]),
                                Telefono = dr["Telefono"].ToString(),
                                Email = dr["Email"].ToString(),
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                                IdEmpresa = Convert.ToInt32(dr["IdEmpresaEmpleado"]),
                                Estado = dr["Estado"].ToString(),

                                // Relación con Empresa
                                Empresa = new Empresa
                                {
                                    IdEmpresa = Convert.ToInt32(dr["IdEmpresaEmpleado"]),
                                    Nombre = dr["NombreEmpresa"].ToString(),
                                    CUIT = dr["CUIT"].ToString(),
                                    Direccion = dr["Direccion"].ToString()
                                }
                            };

                            lista.Add(empleado);
                        }
                    }

                    return lista;
                }
                catch
                {
                    throw;
                }
            }
        }


        public Empleado Obtener(int idEmpleado)
        {
            Empleado entidad = null;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_empleados() WHERE IdEmpleado = @idEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.CommandType = CommandType.Text;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                Nombre = dr["NombreEmpleado"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Cargo = dr["Cargo"].ToString(),
                                Sueldo = Convert.ToDecimal(dr["Sueldo"]),
                                Telefono = dr["Telefono"].ToString(),
                                Email = dr["Email"].ToString(),
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                                IdEmpresa = Convert.ToInt32(dr["IdEmpresaEmpleado"]),
                                Estado = dr["Estado"].ToString(),

                                Empresa = new Empresa
                                {
                                    IdEmpresa = Convert.ToInt32(dr["IdEmpresaEmpleado"]),
                                    Nombre = dr["NombreEmpresa"].ToString(),
                                    CUIT = dr["CUIT"].ToString(),
                                    Direccion = dr["Direccion"].ToString()
                                }
                            };
                        }
                    }

                    return entidad;
                }
                catch
                {
                    throw;
                }
            }
        }


        public bool Crear(Empleado entidad)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_CrearEmpleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", entidad.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Cargo", entidad.Cargo);
                cmd.Parameters.AddWithValue("@Sueldo", entidad.Sueldo);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@Email", entidad.Email);
                cmd.Parameters.AddWithValue("@FechaIngreso", entidad.FechaIngreso);
                cmd.Parameters.AddWithValue("@IdEmpresa", entidad.IdEmpresa);
                cmd.Parameters.AddWithValue("@Estado", entidad.Estado);

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch
                {
                    throw;
                }
            }
        }


        public bool Editar(Empleado entidad)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EditarEmpleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEmpleado", entidad.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", entidad.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Cargo", entidad.Cargo);
                cmd.Parameters.AddWithValue("@Sueldo", entidad.Sueldo);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@Email", entidad.Email);
                cmd.Parameters.AddWithValue("@FechaIngreso", entidad.FechaIngreso);
                cmd.Parameters.AddWithValue("@IdEmpresa", entidad.IdEmpresa);
                cmd.Parameters.AddWithValue("@Estado", entidad.Estado);

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch
                {
                    throw;
                }
            }
        }


        public bool Eliminar(int idEmpleado)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch
                {
                    throw;
                }
            }
        }


    }
}
