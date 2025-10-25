using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo01_T2
{
    public class Producto_G1
    {
        public string G1_Nombre { get; set; }
        public string G1_Categoria { get; set; }
        public decimal G1_Precio { get; set; }
        public int G1_Cantidad { get; set; }

        public Producto_G1(string nombre, string categoria, decimal precio, int cantidad)
        {
            G1_Nombre = nombre;
            G1_Categoria = categoria;
            G1_Precio = precio;
            G1_Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{G1_Nombre} - {G1_Categoria} - S/{G1_Precio} - Stock: {G1_Cantidad}";
        }
    }
}
