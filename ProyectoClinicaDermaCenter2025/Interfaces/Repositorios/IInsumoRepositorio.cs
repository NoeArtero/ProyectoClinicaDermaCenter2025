using ProyectoClinicaDermaCenter2025.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IInsumoRepositorio
    {
        IEnumerable<Insumo> listar(string filtro = null);
        Insumo ObtenerPorId(int id);
        int Agregar(Insumo insumo); 
        bool Editar(Insumo insumo);
        bool Eliminar(int id);

        int ObtenerCantidadDisponibleInsumos(int insumoId);

        IEnumerable<Insumo> ListarAlertasBajoStock();

        IEnumerable<Insumo> ListarLotes(int insumo);
        LoteInsumo ObtenerLotePorId(int id);

        int AgregarLote(LoteInsumo lote);
        bool EditarLote(LoteInsumo lote);
        bool EliminarLote(int LoteId);

        int RegistrarEntrada(MovimientoInventario movimientoInventario);

        bool DescontarSalida(int insumoId, int cantidad, int? loteId = null);
    }
}
