using InputHelper;

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
                decision = LeerInt("Ingrese una opción:", 1, 6);       
                switch(decision)
                {
                    case -1:
                        System.Console.WriteLine("Opción no válida. Vuelve a intentarlo.");
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
            System.Console.WriteLine("Gracias por usar nuestro sistema!");
        }

        static void MenuPrincipal(){
            System.Console.WriteLine("Menú Principal:");
            System.Console.WriteLine(new string('-', 47));
            System.Console.WriteLine(">>> Agregar alumno                               [1]");
            System.Console.WriteLine(">>> Buscar Alumno                                [2]");
            System.Console.WriteLine(">>> Agregar Falta a un alumno                    [3]");
            System.Console.WriteLine(">>> Listar alumnos                               [4]");
            System.Console.WriteLine(">>> Listar alumnos libres                        [5]");
            System.Console.WriteLine(">>> Salir                                        [6]");
            System.Console.WriteLine(new string('-', 47));
        } 

        static void ListarAlumnos(Curso curso)
        {
            int i = 0;
            System.Console.WriteLine("Alumnos:");
            System.Console.WriteLine("-----------------------------------------");
            foreach (Alumno a in curso.Alumnos)
            {
                System.Console.WriteLine($"[{i}] ({a.Dni}) {a.Nombre}");
            }
            System.Console.WriteLine("-----------------------------------------");
        }

        static void ListarAlumnosLibres(Curso curso)
        {
            int i = 0;
            System.Console.WriteLine("Alumnos:");
            System.Console.WriteLine("-----------------------------------------");
            foreach (Alumno a in curso.AlumnosLibres())
            {
                System.Console.WriteLine($"[{i}] ({a.Dni}) {a.Nombre}");
            }
            System.Console.WriteLine("-----------------------------------------");
        }

        static void AgregarNuevoAlumno(Curso curso)
        {
            int dni = LeerInt("Ingresa el dni del alumno:", 0);
            if (dni != -1){
                string nombre = LeerString("Ingresa el nombre del alumno:");
                Alumno a = new Alumno(dni, nombre);
                bool sePudo = curso.AgregarAlumno(a);
                if (!sePudo){
                    System.Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id repetído). Presione cualquier tecla para volver al menú...");
                    System.Console.ReadKey();
                }
                else{
                    System.Console.WriteLine("Se ha agregado al alumno con éxito. Presione cualquier tecla para volver al menú...");
                    System.Console.ReadKey();
                }
            }
            else{
                System.Console.WriteLine("[ERROR] No se pudo ingresar al alumno (Id inválido). Presione cualquier tecla para volver al menú...");
                System.Console.ReadKey();
            }
            
        }

        static void BuscarAlumno(Curso curso){
            int dni = LeerInt("Ingresa el dni del alumno a buscar: ", 0);
            if (dni != -1){
                Alumno a = curso.BuscarAlumno(dni);
                if (a == null){
                    System.Console.WriteLine("[ERROR] No se encontró el alumno. Presione cualquier tecla para volver al menú...");
                    System.Console.ReadKey();
                }
                else{
                    System.Console.WriteLine("Alumno encontrado!");
                    System.Console.WriteLine("---------------------------------");
                    System.Console.WriteLine($"- Nombre: {a.Nombre}");
                    System.Console.WriteLine($"- DNI: {a.Dni}");
                    System.Console.WriteLine("---------------------------------");
                }
            }
            else{
                System.Console.WriteLine("[ERROR] No se encontró el alumno (DNI inválido). Presione cualquier tecla para volver al menú...");
                System.Console.ReadKey();
            }
        }

        static void AgregarFalta(Curso curso){
            int cantidadFaltasEnteras = LeerInt("Ingrese la cantidad de faltas enteras a agregar (Pueden ser 0): ", 0);
            if (cantidadFaltasEnteras == -1){
                System.Console.WriteLine("[ERROR] Cantidad de faltas inválida. Presione cualquier tecla para volver al menú...");
                System.Console.ReadKey();
            }
            else{
                int cantidadMediasFaltas = LeerInt("Ingrese la cantidad de medias faltas a agregar (Pueden ser 0): ", 0);
                if (cantidadMediasFaltas == -1){
                    System.Console.WriteLine("[ERROR] Cantidad de faltas inválida. Presione cualquier tecla para volver al menú...");
                    System.Console.ReadKey();
                }
                else{
                    int dni = LeerInt("Ingresa el dni del alumno al cual agregar las faltas: ", 0);
                    if (dni == -1){
                        System.Console.WriteLine("[ERROR] DNI inválido. Presione cualquier tecla para volver al menú...");
                        System.Console.ReadKey();
                    }
                    else{
                        double faltasTotales = cantidadFaltasEnteras + cantidadMediasFaltas * 0.5;
                        bool sePudo = curso.AgregarFalta(dni, faltasTotales);
                        if (!sePudo){
                            System.Console.WriteLine("[ERROR] No se encontró el alumno. Presione cualquier tecla para volver al menú...");
                            System.Console.ReadKey();
                        }
                        else{
                            System.Console.WriteLine("Se han agregado las faltas exitosamente! Presione cualquier tecla para volver al menú...");
                            System.Console.ReadKey();
                        }
                    }
                }
            }        
        }
    }
}
