using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IndioMendoza2013
{
    // Nota: para obtener instrucciones sobre cómo habilitar el modo clásico de IIS6 o IIS7, 
    // visite http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Nombre de ruta
                "{controller}/{action}/{id}", // URL con parámetros
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Valores predeterminados de parámetro
            );

        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            System.IO.StreamWriter Writer = System.IO.File.AppendText(Server.MapPath("~/App.log"));

            Writer.WriteLine("Session Started: " + DateTime.Now.ToString());
            Writer.Close();
        }

        protected void Session_End(Object sender, EventArgs e)
        {
            System.IO.StreamWriter Writer = System.IO.File.AppendText(Server.MapPath("~/App.log"));

            Writer.WriteLine("Session End: " + DateTime.Now.ToString());
            Writer.Close();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            System.IO.StreamWriter Writer = System.IO.File.AppendText(Server.MapPath("~/App.log"));

            Writer.WriteLine("App Started: " + DateTime.Now.ToString());
            Writer.Close();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            System.IO.StreamWriter Writer = System.IO.File.AppendText(Server.MapPath("~/App.log"));

            Exception exception = Server.GetLastError();
            Response.Clear();

            Writer.WriteLine("App Error: " + exception.Message);
            Writer.Close();

            HttpException httpException = exception as HttpException;

            if (httpException != null)
            {
                string action;

                switch (httpException.GetHttpCode())
                {
                    case 404:
                        // page not found
                        action = "HttpError404";
                        break;
                    case 500:
                        // server error
                        action = "HttpError500";
                        break;
                    default:
                        action = "General";
                        break;
                }

                // clear error on server
                Server.ClearError();

                Response.Redirect(String.Format("~/Error/General/?message={1}", action, exception.Message));
            }
        }

        protected void Application_End(Object sender, EventArgs e) {
            System.Web.ApplicationShutdownReason shutdownReason = System.Web.Hosting.HostingEnvironment.ShutdownReason; 
            string shutdownDetail = ""; 
            switch (shutdownReason) {     
                case ApplicationShutdownReason.BinDirChangeOrDirectoryRename:         
                    shutdownDetail = "A change was made to the bin directory or the directory was renamed";         
                    break;     
                case ApplicationShutdownReason.BrowsersDirChangeOrDirectoryRename:         
                        shutdownDetail = "A change was made to the App_browsers folder or the files contained in it";
                        break;
                case ApplicationShutdownReason.ChangeInGlobalAsax:
                    shutdownDetail = "A change was made in the global.asax file";
                    break;     
                case ApplicationShutdownReason.ChangeInSecurityPolicyFile:
                        shutdownDetail = "A change was made in the code access security policy file";         
                        break;     
                case ApplicationShutdownReason.CodeDirChangeOrDirectoryRename:         
                            shutdownDetail = "A change was made in the App_Code folder or the files contained in it";
                            break;
                case ApplicationShutdownReason.ConfigurationChange:
                    shutdownDetail = "A change was made to the application level configuration";
                    break;
                case ApplicationShutdownReason.HostingEnvironment: 
                    shutdownDetail = "The hosting environment shut down the application";
                    break; 
                case ApplicationShutdownReason.HttpRuntimeClose:
                    shutdownDetail = "A call to Close() was requested";
                    break;
                case ApplicationShutdownReason.IdleTimeout:
                    shutdownDetail = "The idle time limit was reached";
                    break; 
                case ApplicationShutdownReason.InitializationError:
                    shutdownDetail = "An error in the initialization of the AppDomain";
                    break; 
                case ApplicationShutdownReason.MaxRecompilationsReached:
                    shutdownDetail = "The maximum number of dynamic recompiles of a resource limit was reached";
                    break;
                case ApplicationShutdownReason.PhysicalApplicationPathChanged:
                    shutdownDetail = "A change was made to the physical path to the application"; 
                    break;     
                case ApplicationShutdownReason.ResourcesDirChangeOrDirectoryRename:
                        shutdownDetail = "A change was made to the App_GlobalResources foldr or the files contained within it";
                        break;
                case ApplicationShutdownReason.UnloadAppDomainCalled:
                    shutdownDetail = "A call to UnloadAppDomain() was completed";
                    break;
                default: 
                    shutdownDetail = "Unknown shutdown reason";
                    break;
            } 

            System.IO.StreamWriter Writer = System.IO.File.AppendText(Server.MapPath("~/App.log"));

            Writer.WriteLine("App End: " + DateTime.Now.ToString() + "Reason: " + shutdownDetail);
            Writer.Close();
        }  
    }
}