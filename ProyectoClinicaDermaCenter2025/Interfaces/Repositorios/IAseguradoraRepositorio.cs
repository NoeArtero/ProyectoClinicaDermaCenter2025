using ProyectoClinicaDermaCenter2025.Models.Aseguradoras_Polizas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IAseguradoraRepositorio
    {
        IEnumerable<Aseguradora> Listar(string filtro = null);
        Aseguradora ObtenerPorId(int id);
        int Agregar(Aseguradora aseguradora);
        bool Editar(Aseguradora aseguradora);   
        bool Eliminar(int id);  
    }
}
