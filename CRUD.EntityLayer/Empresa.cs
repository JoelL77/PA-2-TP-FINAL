using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.EntityLayer
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Direccion { get; set; }
        public int CantidadEmpleados { get; set; }
    }
}
