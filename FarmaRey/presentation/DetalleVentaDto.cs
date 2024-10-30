namespace FarmaRey.presentation
{
    internal class DetalleVentaDto
    {
        public Guid Id { get; set; }
        public string Medicamento_Nombre { get; set; }
        public decimal Precio_Unidad { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        public DetalleVentaDto(Guid Id, string Medicamento_Nombre, decimal Precio_Unidad, int Cantidad)
        {
            this.Id = Id;
            this.Medicamento_Nombre = Medicamento_Nombre;
            this.Cantidad = Cantidad;
            this.Precio_Unidad = Precio_Unidad;
            this.SubTotal = (decimal) this.Cantidad * this.Precio_Unidad;
        }
    }
}
