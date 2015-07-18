using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class UsuarioDao
    {
        //atributos de la clase personal
        private int idusuario;
        private String nombre;
        private String apellidos;
        private String direccion;
        private String usuario; 
        private String password;
        private String email;
        //Constructor de la clase
        public UsuarioDao(){

        }
        
        /*Metodos de cada atributo para poder editar y sacar sus datos */
        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
