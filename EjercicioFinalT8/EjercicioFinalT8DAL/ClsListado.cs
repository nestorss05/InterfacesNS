using EjercicioFinalT8Ent;
namespace EjercicioFinalT8DAL;

public class ClsListado
{

    /// <summary>
    /// Funcion que nos devuelve un listado de clientes
    /// </summary>
    /// <returns>Listado de clientes</returns>
    public static List<ClsClientes> getListadoClientes()
    {
        return new List<ClsClientes>
        {
            new ClsClientes {id = 1, nombre = "Hector Salamanca", direccion = "Plaza Circular 1, Valladolid", telefono=600000000, ingeniero="Pablo Motos", apto=false}
        };
    }

}
