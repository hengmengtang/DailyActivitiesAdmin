Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
           name:="Login",
           url:="Login",
           defaults:=New With {.controller = "UserAccount", .action = "Login"}
       )
        routes.MapRoute(
           name:="Detail",
           url:="Show",
           defaults:=New With {.controller = "Activity", .action = "Show"}
       )

        routes.MapRoute(
           name:="Dashboard",
           url:="Dashboard/{username}",
           defaults:=New With {.controller = "Activity", .action = "UserDashboard", .username = ""}
       )

        routes.MapRoute(
           name:="Show",
           url:="Activity",
           defaults:=New With {.controller = "Activity", .action = "ShowActivity"}
       )

        routes.MapRoute(
           name:="Activity",
           url:="Create",
           defaults:=New With {.controller = "Activity", .action = "CreateDailyActivity"}
       )
        routes.MapRoute(
           name:="Register",
           url:="Register",
           defaults:=New With {.controller = "UserAccount", .action = "Register"}
       )


        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "UserAccount", .action = "Login", .id = UrlParameter.Optional}
        )
    End Sub
End Module