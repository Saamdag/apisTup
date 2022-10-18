namespace apis.Models
{
    public class Productos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }

        public Productos()
        {
            nombre=string.Empty;
        }
        public Productos(int codigo, string nombre, decimal precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
