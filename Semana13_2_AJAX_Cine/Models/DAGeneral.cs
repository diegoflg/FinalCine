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
    }
}