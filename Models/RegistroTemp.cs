namespace apis.Models
{
    public class RegistroTemp
    {


        //private  static RegistroTemp _instance=new RegistroTemp();
        public List<Temperatura> registros; 
        
        
        
        public RegistroTemp()
        {
            registros = new List<Temperatura>();
            registros.Add(new Temperatura(1, DateTime.MaxValue, 24));
            registros.Add(new Temperatura(2, DateTime.MinValue, 31));
            registros.Add(new Temperatura(3, DateTime.Now, 0));
        }

        //public RegistroTemp obtenerInstancia()
        //{
        //    return _instance;
        //}

        
        

    }
}
