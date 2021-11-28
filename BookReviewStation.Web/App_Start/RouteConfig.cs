namespace BookReviewStation.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{bookId}",
                defaults: new { controller = "Book", action = "GetBook", bookId = 1 }
            );
        }
    }
}