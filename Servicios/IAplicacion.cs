using apis.Models;
namespace apis.Servicios

{
    public interface IAplicacion
    {
        Productos create(int id,string nombre, decimal precio);
        List<Productos> read();
        Productos read(int id);
        //bool update(List<>);
        bool delete(int id);
    }
}
