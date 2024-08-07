using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_10_Herencia
{
    public class Ordenador : Producto
    {
        public string Procesador { get; set; }

        public Ordenador(string nombre, double precio, string procesador)
            : base(nombre, precio)
        {
            Procesador = procesador;
        }

        public new string ObtenerDescripcion()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}, Procesador: {Procesador}";
        }
    }
}
