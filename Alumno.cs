namespace TP1
{
    public class Alumno
    {
        private int dni; 
        private string nombre;
        private double cantidadFaltas;

        public Alumno(int dni, string nombre){
            this.dni = dni;
            this.nombre = nombre;
            this.cantidadFaltas = 0;
        }

        public double Faltas
        {
            get{return this.cantidadFaltas;}
            set{this.cantidadFaltas = value;}
        }

        public string Nombre
        {
            get{return this.nombre;}
            set{this.nombre = value;}
        }

        public double Dni
        {
            get{return this.dni;}
            set{this.dni = value;}
        }

    }
}
