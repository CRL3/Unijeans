using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    class UsuarioDao
    {
        private int id_usuario;
        private String nombre;
        private String apellidos;
        private String fecha_nac;
        private String direccion;
        private String correo;
        private String usuario; 
        private String password;
        private int estado;
        private int id_rol;

        public UsuarioDao() { }
        public UsuarioDao(int id, String nombre, String apellidos, String fecha_nac, String direccion,String correo, String usuario, String password, int estado, int id_rol)
        {
            this.id_usuario = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fecha_nac = fecha_nac;
            this.direccion = direccion;
            this.correo = correo;
            this.usuario = usuario;
            this.password = usuario;
            this.estado = estado;
            this.id_rol = id_rol;
        }
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
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
        public String Fecha_nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
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
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
    }
}
