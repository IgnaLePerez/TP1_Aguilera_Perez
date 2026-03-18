namespace TP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            int decision = LeerInt("Ingrese una opción:", 1, 6);
            Curso curso = new Curso();

            switch(decision)
            {
                case -1:
                Console.Writeline("Opción no válida. Vuelve a intentarlo.");
                break;
                case 1:
                AgregarNuevoAlumno();

                break;
                case 2:
                
                break;
                case 3:
                
                break;
                case 4:
                
                break;
                case 5:
                
                break;
                case 6:
                
                break;
                
            }
        }

        static void MenuPrincipal(){
            Console.WriteLine("Menú Principal:");
            Console.WriteLine(new string('-', 47));
            Console.WriteLine(">>> Agregar alumno                               [1]");
            Console.WriteLine(">>> Buscar Alumno                                [2]");
            Console.WriteLine(">>> Agregar Falta a un alumno                    [3]");
            Console.WriteLine(">>> Listar alumnos                               [4]");
            Console.WriteLine(">>> Listar alumnos libres                        [5]");
            Console.WriteLine(">>> Salir                                        [6]");
            Console.WriteLine(new string('-', 47));
        } 

        static void ListarAlumnos(List<Alumno> alumnos)
        {
            int i = 0;
            Console.WriteLine("Alumnos:");
            Console.WriteLine("-----------------------------------------");
            foreach (alumno a in alumnos)
            {
                Console.WriteLine($"[{i}] ({a.Dni}) {a.Nombre}");
            }
            Console.WriteLine("-----------------------------------------");
        }

        static void AgregarNuevoAlumno()
        {
            int dni = LeerInt("Ingresa el dni del alumno:", 0);
            string nombre = LeerString("Ingresa el nombre del alumno:");
            Alumno a = new Alumno(dni, nombre);
            curso.AgregarAlumno(a);


        }

        static Alumno BuscarAlumno(int dni){
            return curso.BuscarAlumno(dni);
        }
    }
}
