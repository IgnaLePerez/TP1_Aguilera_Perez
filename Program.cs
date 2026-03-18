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
                    BuscarAlumno();
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
            if (dni != -1){
                string nombre = LeerString("Ingresa el nombre del alumno:");
                Alumno a = new Alumno(dni, nombre);
                bool sePudo = curso.AgregarAlumno(a);
                if (!sePudo){
                    Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id repetído). Presione cualquier tecla para volver al menú...");
                    Console.Readkey();
                }
                else{
                    Console.WriteLine("Se ha agregado al alumno con éxito. Presione cualquier tecla para volver al menú...");
                    Console.Readkey();
                }
            }
            else{
                Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id inválido). Presione cualquier tecla para volver al menú...");
                Console.Readkey();
            }
            
        }

        static void BuscarAlumno(){
            int dni = LeerInt("Ingresa el dni del alumno a buscar: ", 0);
            if (dni != -1){
                Alumno a = curso.BuscarAlumno(dni);
                Console.WriteLine("Alumno encontrado!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"- Nombre: {a.Nombre}");
                Console.WriteLine($"- DNI: {a.Dni}");
                Console.WriteLine("---------------------------------");
            }
            else{
                Console.WriteLine("[ERROR] No se encontró el alumno. Presione cualquier tecla para volver al menú...");
                Console.Readkey();
            }
        }

        static void AgregarFalta(){
            int cantidadFaltasEnteras = LeerInt("Ingrese la cantidad de faltas enteras a agregar (Pueden ser 0): ", 0);
            if (cantidadFaltasEnteras == -1){

            }
            else{
                if (cantidadMediasFaltas == -1){

                }
                else{
                    if (dni == -1){
                        
                    }
                }
            }
            int cantidadMediasFaltas = LeerInt("Ingrese la cantidad de medias faltas a agregar (Pueden ser 0): ", 0);
            int dni = LeerInt("Ingresa el dni del alumno al cual agregar las faltas: ", 0);
        }
    }
}
