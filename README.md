se han hecho estos cambios:

Models/
  Seguridad/ Usuario.cs, Rol.cs
  RRHH/ Empleado.cs
  Pacientes/ Paciente.cs, Aseguradora.cs, PolizaPaciente.cs
  Agenda/ Cita.cs, Atencion.cs, Servicio.cs, AtencionServicio.cs
  Inventario/ Insumo.cs, Proveedor.cs, LoteInsumo.cs, MovimientoInventario.cs
  Facturacion/ Factura.cs, Pago.cs

Controllers/
  Seguridad/ SeguridadController.cs
  RRHH/ EmpleadoController.cs
  Pacientes/ PacienteController.cs, AseguradoraController.cs
  Agenda/ CitaController.cs, ServicioController.cs, AtencionController.cs
  Inventario/ InventarioController.cs, ProveedorController.cs
  Facturacion/ FacturacionController.cs
  // (Opcional) ReporteController.cs

Views/
  Inicio/ DermaCenterInicio_View.cs
  Seguridad/ UsuarioListForm.cs, UsuarioUpsertForm.cs, RolListForm.cs, RolUpsertForm.cs
  RRHH/ EmpleadoListForm.cs, EmpleadoUpsertForm.cs
  Pacientes/ PacienteListForm.cs, PacienteUpsertForm.cs, AseguradoraListForm.cs, AseguradoraUpsertForm.cs, PolizaPacienteUpsertForm.cs
  Agenda/ CitaListForm.cs, CitaUpsertForm.cs, ServicioListForm.cs, ServicioUpsertForm.cs, AtencionListForm.cs, AtencionUpsertForm.cs
  Inventario/ InsumoListForm.cs, InsumoUpsertForm.cs, ProveedorListForm.cs, ProveedorUpsertForm.cs
  Facturacion/ FacturaListForm.cs, FacturaDetalleForm.cs
  Reportes/ ReporteQuincenalForm.cs
