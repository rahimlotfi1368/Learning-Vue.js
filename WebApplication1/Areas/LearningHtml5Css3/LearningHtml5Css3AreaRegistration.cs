using System.Web.Mvc;

namespace WebApplication1.Areas.LearningHtml5Css3
{
    public class LearningHtml5Css3AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LearningHtml5Css3";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LearningHtml5Css3_default",
                "LearningHtml5Css3/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces:new[] { "WebApplication1.Areas.LearningHtml5Css3.Controllers" }
            );
        }
    }
}