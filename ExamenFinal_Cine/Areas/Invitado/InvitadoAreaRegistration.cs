using System.Web.Mvc;

namespace Semana13_2_AJAX_Cine.Areas.Invitado
{
    public class InvitadoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Invitado";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Invitado_default",
                "Invitado/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}