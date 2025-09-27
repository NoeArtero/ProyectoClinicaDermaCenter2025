using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Seguridad
{
    public class Usuario 
    {
        public int Id { get; set; }

        [Required, MaxLength(40)] public string NombreUsuario { get; set; } = "";

        [Required] public string ContraHash { get; set; } = "";

        public int? EmpleadoId { get; set; } // si el usuario está ligado a un empleado
        public int RolId { get; set; }

        public bool Activo { get; set; } = true;

    }
}
