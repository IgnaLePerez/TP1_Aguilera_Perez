namespace TP1
{
    public class Curso
    {
        private const double MAXIMO_FALTAS = 15;
        private List <Alumno> alumnos;

        public Curso (){
            alumnos = new();
        }

        public bool AgregarAlumno(Alumno alumno)
        {
            int i = BuscarAlumnoDni(alumno.Dni);

            if (i == -1){
                alumnos.Add(alumno);
                return true;
            }
            else{
                return false;
            }
        }

        public int BuscarAlumnoDni(int dni)
        {
            int i = 0;
                
            while (i < alumnos.Count && alumnos[i].Dni != dni)
            i++;

            if (i == alumnos.Count){
                return -1;
            }
            else{
                return i;
            }
        }

        public bool AgregarFalta(int dni, double falta)
        {
            int i = BuscarAlumnoDni(dni);

            if(i == -1){
                return false;
            }
            
            else{
                alumnos[i].Faltas += falta;
                return true;
            }
        }

        public List<Alumno> Alumnos
        {
            get{return this.alumnos;}
        }

        public List<Alumno> AlumnosLibres()
        {
            List <Alumno> alumnosLibres = new();

            foreach (Alumno a in this.alumnos)
            {
                if (a.Faltas > MAXIMO_FALTAS)
                    alumnosLibres.Add(a);
            }

            return alumnosLibres;
        } 

        public Alumno BuscarAlumno(int dni)
        {
            int i = BuscarAlumnoDni(dni);

            if (i == alumnos.Count){
                return null;
            }
            else{
                return alumnos[i];
            }
        }
    }
}
    

