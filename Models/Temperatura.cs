namespace apis.Models
{
    public class Temperatura
    {
        public int iot { get; set; }
        public DateTime fechaHora { get; set; }
        public float valor { get; set; }

        public Temperatura(int iot, DateTime fechaHora, float valor)
        {
            this.iot = iot;
            this.fechaHora = fechaHora;
            this.valor = valor;
        }

    }
}
