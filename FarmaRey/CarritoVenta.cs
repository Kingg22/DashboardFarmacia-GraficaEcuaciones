using FarmaRey.models;

namespace FarmaRey
{
    internal class CarritoVenta
    {
        public Guid IdVenta { get; private set; } = Guid.NewGuid();
        public List<DetalleVenta> ListDetalleVenta { get; private set; } = new List<DetalleVenta>();

        public void AgregarProducto (Medicamento medicamento, int cantidad)
        {
            DetalleVenta detalle = new()
            {
                Id = Guid.NewGuid(),
                MedicamentoId = medicamento.Id,
                VentaId = this.IdVenta,
                Cantidad = cantidad,
                Medicamento = medicamento
            };
            this.ListDetalleVenta.Add(detalle);
        }

        public List<Guid> GetDetallesIds()
        {
            return this.ListDetalleVenta.Select(d => d.Id).ToList();
        }

        // Get personalizado para eliminar referencia de Medicamento y evitar conflictos
        public List<DetalleVenta> GetDetallesVentas()
        {
            return ListDetalleVenta.Select(x => new DetalleVenta()
            {
                Cantidad = x.Cantidad,
                VentaId = x.VentaId,
                MedicamentoId = x.MedicamentoId
            }).ToList();
        }

        public void EliminarProducto(Guid id)
        {
            var item = this.ListDetalleVenta.Find(d => d.Id == id);
            if (item != null)
            {
                this.ListDetalleVenta.Remove(item);
            }
        }

        public void VaciarCarrito()
        {
            this.ListDetalleVenta.Clear();
        }

        public int CantidadProductos()
        {
            return this.ListDetalleVenta.Count;
        }
    }
}
