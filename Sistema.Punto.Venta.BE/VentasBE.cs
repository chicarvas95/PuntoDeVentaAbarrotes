using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Punto.Venta.BE
{
    public class VentasBE
    {
        public int IdVenta       { get; set; }
        public string Producto   { get; set; }
        public decimal Precio    { get; set; }
        public int Cantidad      { get; set; }
        public string Empleado   { get; set; }
        public int RolId         { get; set; }
        public string FechaVenta { get; set; }
        public string HoraVenta  { get; set; }
    }
}
