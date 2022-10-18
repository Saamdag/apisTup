using apis.Models;

namespace apis.Servicios
{
    public class Aplicacion : IAplicacion
    {
        static List<Productos> lst = new List<Productos>();
        
        
        public Aplicacion()
        {
            lst.Add(new Productos(1, "sedas", 150));
            lst.Add(new Productos(2, "filtros", 100));
            lst.Add(new Productos(3, "pica", 2500)); ;
        }





         Productos IAplicacion.create(int id,string nombre,decimal precio)
        {
            Productos p = new Productos(id, nombre, precio);
            lst.Add(p);
            return (p);
        }

        List<Productos> IAplicacion.read()
        {
            return lst;
        }

        Productos IAplicacion.read(int id)
        {        
            var p = lst.Find(p => p.codigo == id);
            if (Productos.ReferenceEquals(p,new Productos())) return null;       
            return p;
        }

        bool IAplicacion.delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
