namespace BlazorApp1.Components.Entities
{
    public class PeliculasEntity
    {
        public string Nombre = "";
        public int Calificación = 0;

        public PeliculasEntity(string nombre, int calificacion)
        {
            Nombre = nombre;
            Calificación = calificacion;
        }
    }
}
