using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Punto.Venta.BE
{
    public class Usuario
    {
        public  string Nombre          { get; set; }
        public  string ApellidoPaterno { get; set; }
        public string ApellidoMaterno  { get; set; }
        public string Telefono         { get; set; }
        public string Correo           { get; set; }
        public string Contrasena       { get; set; }
        public int RolId               { get; set; }
        public int Activo              { get; set; }
    }
}
