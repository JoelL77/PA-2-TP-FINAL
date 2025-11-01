using CRUD.DataLayer;
using CRUD.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BusinessLayer
{
    public class EmpresaBL
    {
        EmpresaDL empresaDL = new EmpresaDL();

        public List<Empresa> Lista()
        {
            try
            {

                return empresaDL.Lista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
