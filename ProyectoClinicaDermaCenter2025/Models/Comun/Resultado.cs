using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Comun
{
    public class Resultado
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; } = "";
        public static Resultado Exito(string msg = "") => new Resultado { Ok = true, Mensaje = msg };
        public static Resultado Error(string msg) => new Resultado { Ok = false, Mensaje = msg };

    }

    public class Resultado<T> : Resultado
    {
        public T? Datos { get; set; }
        public static Resultado<T> Exito(T datos, string msg = "") => new Resultado<T> { Ok = true, Datos = datos, Mensaje = msg };
        public new static Resultado<T> Error(string msg) => new Resultado<T> { Ok = false, Mensaje = msg };
    }
}
