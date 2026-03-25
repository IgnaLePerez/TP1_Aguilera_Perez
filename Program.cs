namespace TP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            int decision = 0;
            do{
                MenuPrincipal();
                decision = InputHelper.LeerInt("Ingrese una opción:", 1, 6);       
                switch(decision)
                {
                    case -1:
                        Console.WriteLine("Opción no válida. Vuelve a intentarlo.");
                        break;

                    case 1:
                        AgregarNuevoAlumno(curso);
                        break;

                    case 2:
                        BuscarAlumno(curso);
                        break;
                        
                    case 3:
                        AgregarFalta(curso);
                        break;
                    case 4:
                        ListarAlumnos(curso);
                        break;
                    case 5:
                        ListarAlumnosLibres(curso);
                        break;
                    case 6:

                        break;
                    
                }
            } while(decision != 6);
            Console.WriteLine("Gracias por usar nuestro sistema!");
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

        static void ListarAlumnos(Curso curso)
        {
            int i = 0;
            Console.WriteLine("Alumnos:");
            Console.WriteLine("-----------------------------------------");
            foreach (Alumno a in curso.Alumnos.Values)
            {
                Console.WriteLine($"[{i}] ({a.Dni}) {a.Nombre}");
            }
            Console.WriteLine("-----------------------------------------");
        }

        static void ListarAlumnosLibres(Curso curso)
        {
            int i = 0;
            Console.WriteLine("Alumnos:");
            Console.WriteLine("-----------------------------------------");
            foreach (Alumno a in curso.AlumnosLibres())
            {
                Console.WriteLine($"[{i}] ({a.Dni}) {a.Nombre}");
            }
            Console.WriteLine("-----------------------------------------");
        }

        static void AgregarNuevoAlumno(Curso curso)
        {
            int dni = InputHelper.LeerInt("Ingresa el dni del alumno:", 0);
            if (dni != -1){
                string nombre = InputHelper.LeerString("Ingresa el nombre del alumno:");
                Alumno a = new Alumno(dni, nombre);
                bool sePudo = curso.AgregarAlumno(a);
                if (!sePudo){
                    Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id repetido). Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
                else{
                    Console.WriteLine("Se ha agregado al alumno con éxito! Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
            else{
                Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id inválido). Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
            
        }

        static void BuscarAlumno(Curso curso){
            int dni = InputHelper.LeerInt("Ingresa el dni del alumno a buscar: ", 0);
            if (dni != -1){
                Alumno a = curso.BuscarAlumno(dni);
                if (a == null){
                    Console.WriteLine("[ERROR] No se encontró el alumno. Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
                else{
                    Console.WriteLine("Alumno encontrado!");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"- Nombre: {a.Nombre}");
                    Console.WriteLine($"- DNI: {a.Dni}");
                    Console.WriteLine("---------------------------------");
                }
            }
            else{
                Console.WriteLine("[ERROR] No se encontró el alumno (DNI inválido). Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }

        static void AgregarFalta(Curso curso){
            int cantidadFaltasEnteras = InputHelper.LeerInt("Ingrese la cantidad de faltas enteras a agregar (Pueden ser 0): ", 0);
            if (cantidadFaltasEnteras == -1){
                Console.WriteLine("[ERROR] Cantidad de faltas inválida. Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
            else{
                int cantidadMediasFaltas = InputHelper.LeerInt("Ingrese la cantidad de medias faltas a agregar (Pueden ser 0): ", 0);
                if (cantidadMediasFaltas == -1){
                    Console.WriteLine("[ERROR] Cantidad de faltas inválida. Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
                else{
                    int dni = InputHelper.LeerInt("Ingresa el dni del alumno al cual agregar las faltas: ", 0);
                    if (dni == -1){
                        Console.WriteLine("[ERROR] DNI inválido. Presione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                    }
                    else{
                        double faltasTotales = cantidadFaltasEnteras + cantidadMediasFaltas * 0.5;
                        bool sePudo = curso.AgregarFalta(dni, faltasTotales);
                        if (!sePudo){
                            Console.WriteLine("[ERROR] No se encontró el alumno. Presione cualquier tecla para volver al menú...");
                            Console.ReadKey();
                        }
                        else{
                            Console.WriteLine("Se han agregado las faltas exitosamente! Presione cualquier tecla para volver al menú...");
                            Console.ReadKey();
                        }
                    }
                }
            }        
        }
    }
}
