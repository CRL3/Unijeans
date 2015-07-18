using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class RolDao
    {
        /*Clase destina a el almacenamiento de datos de la tabla ROL
         sus atributos y metodos*/
        private int idrol;
        private String descripcion;
        //Constructor de la clase
        public RolDao(int idrol, String descripcion)
        {
            this.idrol = idrol;
            this.descripcion = descripcion;
        }

        /*Metodos de los atributos de Rol para agregar o sacar datos*/
        public int Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
