Imports System.Web.Mvc.Filters
Imports System.Security.Principal
Imports System.Web.Mvc

Public Class CustomizeAuthAttribute
    Inherits ActionFilterAttribute
    Implements IAuthenticationFilter

    Public Sub OnAuthentication(filterContext As AuthenticationContext) Implements IAuthenticationFilter.OnAuthentication
        If Me.IsAnonymousAction(filterContext) Then
            Exit Sub
        End If      
    End Sub

    Public Sub OnAuthenticationChallenge(filterContext As AuthenticationChallengeContext) Implements IAuthenticationFilter.OnAuthenticationChallenge
        If filterContext.Result Is Nothing Or TypeOf filterContext.Result Is HttpUnauthorizedResult Then
            'Dim routeValueDictionary As New Dictionary(Of String, Object)
            'routeValueDictionary.Add("controller", "UserAccount")
            'routeValueDictionary.Add("action", "Login")
            'routeValueDictionary.Add("resultUrl", filterContext.HttpContext.Request.RawUrl)
            'filterContext.Result = New RedirectToRouteResult(New RouteValueDictionary(routeValueDictionary))
            filterContext.Result = New RedirectResult("Login")
        End If
    End Sub
    'Allow Anonymous Attribute on Action or Controller
    Private Function IsAnonymousAction(filterContext As AuthenticationContext)
        Return filterContext.ActionDescriptor.GetCustomAttributes(True).OfType(Of AllowAnonymousAttribute).Any Or filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(True).OfType(Of AllowAnonymousAttribute).Any
    End Function
End Class
