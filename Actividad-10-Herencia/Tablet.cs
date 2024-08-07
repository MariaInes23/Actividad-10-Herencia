using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10_Herencia
{
    public class Tablet : Producto
    {
        public string TamanoPantalla { get; set; }

        public Tablet(string nombre, double precio, string tamanoPantalla)
            : base(nombre, precio)
        {
            TamanoPantalla = tamanoPantalla;
        }

        public new string ObtenerDescripcion()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}, Tamaño Pantalla: {TamanoPantalla}";
        }
    }
}
