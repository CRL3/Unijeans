using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    class RolDao
    {
        public int id_rol { get; set; }
        public String descripcion { get; set; }

        public RolDao(int pass_id, String pass_descripcion)
        {
            id_rol = pass_id;
            descripcion = pass_descripcion;
        }

    }
}
