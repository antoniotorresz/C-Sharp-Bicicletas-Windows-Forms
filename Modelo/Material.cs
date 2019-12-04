namespace Modelo
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float PrecioCompra { get; set; }
        public int Estatus { get; set; }
        public string IdProvedor { get; set; }
    }
}
