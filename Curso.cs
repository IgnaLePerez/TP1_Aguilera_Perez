namespace TP1
{
    public class Curso
    {
        private const double MAXIMO_FALTAS = 15;
        Dictionary<int, Alumno> alumnos;

        public Curso (){
            alumnos = new Dictionary<int, Alumno>();
        }

        public bool AgregarAlumno(Alumno alumno)
        {
            if (alumnos.ContainsKey(alumno.Dni)){
                alumnos.Add(Alumno.Dni, alumno)
                return true;
            }
            return false;
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
            if(alumnos.ContainsKey(dni)){
                alumnos[dni].cantidadFaltas += falta;
                return true;
            }     
            else{
                return false;
            }
        }

        public Dictionary<int, Alumno> Alumnos
        {
            get{return this.alumnos;}
        }

        public List<Alumno> AlumnosLibres()
        {
            List <Alumno> alumnosLibres = new();

            foreach (Alumno a in this.alumnos.Values)
            {
                if (a.Faltas > MAXIMO_FALTAS)
                    alumnosLibres.Add(a);
            }
            return alumnosLibres;
        } 

        public Alumno BuscarAlumno(int dni)
        {
            if (alumnos.ContainsKey(dni)){
                return alumnos[dni];
            }
            else{
                return null;
            }
        }
    }
}
    

