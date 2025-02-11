using BlazorApp1.Components.Entities;
using BlazorApp1.Components.Pages;
using Microsoft.AspNetCore.Components;


namespace BlazorApp1.Components.Pages.Peliculas
{
    public partial class Peliculas
    {
        private string MensajeError = "";
        private bool EstamosModificando = false;
        private PeliculasEntity? PeliculasModificando;

        private int Calificación = 0;
        private string Nombre = "";

        private List<PeliculasEntity> PeliculasList = new();

        private PeliculaModal modal = default!;

        private void NuevaPelicula()
        {
            PeliculasModificando = new PeliculasEntity();
            modal.Open();
        }

        private void Guardar()
        {
            if (PeliculasModificando.Calificación > 5 || PeliculasModificando.Calificación < 1)
            {
                MensajeError = "La calificación debe ser del valor 1 al 5!";
            }
            else if (PeliculasModificando.Nombre == "")
            {
                MensajeError = "Faltaron datos por ingresar!";
            }
            else
            {
                if (!EstamosModificando)
                {
                    PeliculasList.Add(PeliculasModificando);
                }
                else
                {
                    EstamosModificando = false;
                }

                //Nombre = "";
                //Calificación = 0;

                PeliculasModificando = null;

                MensajeError = "";
                modal.Close();
            }

        }

        private void Modificar(PeliculasEntity peliculaModificar)
        {
            EstamosModificando = true;
            PeliculasModificando = peliculaModificar;

            modal.Open();
        }

        private void GuardarCambios()
        {
            if (Calificación > 5 || Calificación < 1)
            {
                MensajeError = "La calificación debe ser del valor 1 al 5!";
            }
            else if (Nombre == "")
            {
                MensajeError = "Faltaron datos por ingresar!";
            }
            else
            {
                PeliculasModificando.Nombre = Nombre;
                PeliculasModificando.Calificación = Calificación;

                Nombre = "";
                Calificación = 0;

                EstamosModificando = false;
                PeliculasModificando = null;
            }
        }

        private void Eliminar(PeliculasEntity peliculaEliminar)
        {
            PeliculasList.Remove(peliculaEliminar);
        }
    }
}