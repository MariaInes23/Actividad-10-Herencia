using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_10_Herencia
{
    public class Telefono:Producto
    {
        public string Modelo { get; set; }

        public Telefono(string nombre, double precio, string modelo)
            : base(nombre, precio)
        {
            Modelo = modelo;
        }

        public new string ObtenerDescripcion()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}, Modelo: {Modelo}";
        }
    }
}
