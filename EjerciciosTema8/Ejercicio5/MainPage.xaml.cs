using System.Collections.ObjectModel;

namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
    {

        /// <summary>
        /// Clase con todos los datos de la persona
        /// </summary>
        public class clsPersona
        {
            public int id { get; set; }
            public required string nombre { get; set; }
            public required string apellidos { get; set; }
            public required string fechaNac { get; set; }
        }

        ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();

        /// <summary>
        /// Función que nos devuelve un listado de todas las personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public ObservableCollection<clsPersona> getListadoCompletoPersonas{ get { return personas;}}

        public MainPage()
        {
            InitializeComponent();
            personas.Add(new clsPersona() { id = 1, nombre = "Sofia", apellidos = "Martinez", fechaNac = new DateTime(1995, 03, 12).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 2, nombre = "Diego", apellidos = "Fernandez", fechaNac = new DateTime(1988, 07, 23).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 3, nombre = "Lucia", apellidos = "Gonzalez", fechaNac = new DateTime(1992, 01, 05).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 4, nombre = "Juan", apellidos = "Perez", fechaNac = new DateTime(1985, 11, 17).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 5, nombre = "Valentina", apellidos = "Lopez", fechaNac = new DateTime(2000, 04, 29).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 6, nombre = "Sebastian", apellidos = "Ramirez", fechaNac = new DateTime(1990, 12, 08).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 7, nombre = "Camila", apellidos = "Torres", fechaNac = new DateTime(1997, 08, 03).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 8, nombre = "Andres", apellidos = "Castro", fechaNac = new DateTime(1983, 02, 14).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 9, nombre = "Isabella", apellidos = "Morales", fechaNac = new DateTime(1994, 09, 20).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 10, nombre = "Nicolas", apellidos = "Herrera", fechaNac = new DateTime(1989, 06, 10).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 11, nombre = "Nicolas", apellidos = "Superbigote", fechaNac = new DateTime(1962, 11, 23).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 12, nombre = "Elon", apellidos = "Mok", fechaNac = new DateTime(1971, 06, 28).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 13, nombre = "Hugo", apellidos = "Destructor", fechaNac = new DateTime(1954, 07, 28).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 14, nombre = "Eusebio", apellidos = "Fernandez", fechaNac = new DateTime(1966, 06, 26).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 15, nombre = "Rafael", apellidos = "Paelleras", fechaNac = new DateTime(1959, 10, 24).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 16, nombre = "Elena", apellidos = "Nito", fechaNac = new DateTime(1977, 07, 07).ToString("dd/MM/yyyy") });
            personas.Add(new clsPersona() { id = 17, nombre = "Hermenegildo", apellidos = "Iglesias", fechaNac = new DateTime(1980, 12, 08).ToString("dd/MM/yyyy") });
            PersonaView.ItemsSource = personas;
        }

    }

}
