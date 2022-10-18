namespace apis.Models
{
    public class Moneda
    {
        public string nombre { get; set; }
        public int valor { get; set; }

        public Moneda(string nombre, int valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
