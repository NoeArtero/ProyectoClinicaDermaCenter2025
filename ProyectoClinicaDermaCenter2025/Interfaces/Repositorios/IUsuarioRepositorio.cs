using ProyectoClinicaDermaCenter2025.Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> Listar(string filtro = null);
        Usuario ObtenerPorId(int id);
        int Crear(Usuario usuario);
        bool Editar(Usuario usuario);
        bool Eliminar(int id);

        IEnumerable<Rol> ObtenerRoles(int usuarioId);
        bool AsignarRol(int usuarioId, int rolId);
        bool RemoverRol(int usuarioId, int rolId);
    }
}
