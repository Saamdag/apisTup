namespace apis.Models
{
    public class Fecha
    {
        public Fecha()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;
            Dia = DateTime.Now.Day;
            DiaSemana = DateTime.Now.DayOfWeek.ToString();
        }

        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public string DiaSemana { get; set; }

    }
}
