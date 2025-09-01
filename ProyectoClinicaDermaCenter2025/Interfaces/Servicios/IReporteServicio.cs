using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Servicios
{
    public interface IReporteServicio
    {
        DataTable GenerarReporteQuincenal(DateTime desde, DateTime hasta, string tipo);
    }
}
