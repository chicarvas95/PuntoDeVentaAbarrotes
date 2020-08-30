using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Punto.Venta.BE
{
    public class DatosMinMax
    {
        public string DescripcionProducto { get; set; }
        public string Categoria           { get; set; }
        public decimal PrecioUnitario     { get; set; }
        public decimal PrecioProveedor    { get; set; }
        public int EnInventario           { get; set; }
        public int Minimo                 { get; set; }
        public int Maximo                 { get; set; }
        public string Estatus             { get; set; }
    }
}
