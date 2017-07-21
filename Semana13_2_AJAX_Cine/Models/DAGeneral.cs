using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana13_2_AJAX_Cine.Models
{
    public class DAGeneral
    {
        static public List<Interprete> listadoInterprete()
        {
            List<Interprete> listado = new List<Interprete>();
            using (var data = new CineDBEntities())
            {
                return data.Interprete.ToList();
            }
        }

        static public List<Protagonista> ListadoProtagonista()
        {
            List<Protagonista> protagonista = new List<Protagonista>();
            using (var data = new CineDBEntities())
            {
                return data.Protagonista.ToList();
            }
        }

        static public List<Asiento> ListadoAsiento()
        {
            List<Asiento> asiento = new List<Asiento>();
            using (var data = new CineDBEntities())
            {
                return data.Asiento.ToList();
            }
        }

        static public List<Cine> ListadoCine()
        {
            List<Cine> cine = new List<Cine>();
            using (var data = new CineDBEntities())
            {
                return data.Cine.ToList();
            }
        }

        static public List<CinePelicula> ListadoCinePelicula()
        {
            List<CinePelicula> cinepelicula = new List<CinePelicula>();
            using (var data = new CineDBEntities())
            {
                return data.CinePelicula.ToList();
            }
        }

        static public List<Director> ListadoDirector()
        {
            List<Director> director = new List<Director>();
            using (var data = new CineDBEntities())
            {
                return data.Director.ToList();
            }
        }

        static public List<Funcion> ListadoFuncion()
        {
            List<Funcion> funcion = new List<Funcion>();
            using (var data = new CineDBEntities())
            {
                return = data.Funcion.ToList();
            }
            return funcion;
        }

        static public List<Pedido> ListadoPedido()
        {
            List<Pedido> pedido = new List<Pedido>();
            using (var data = new CineDBEntities())
            {
                pedido = data.Pedido.ToList();
            }
            return pedido;
        }

        static public List<CinePelicula> ListadoCine()
        {
            List<CinePelicula> cinepelicula = new List<CinePelicula>();
            using (var data = new CineDBEntities())
            {
                cinepelicula = data.CinePelicula.ToList();
            }
            return cinepelicula;
        }

    }
}