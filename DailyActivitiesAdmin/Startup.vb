Imports Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.AspNet.Identity

<Assembly: OwinStartupAttribute(GetType(Startup))> 

Partial Public Class Startup
    Public Sub Configuration(app As IAppBuilder)
        'ConfigureAuth(app)
        'app.UseTwoFactorSignInCookie("cookie", expires:=New TimeSpan(0.2, 0, 0))
        Dim appOption As New CookieAuthenticationOptions
        appOption.AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
        appOption.LoginPath = New PathString("/Login")
        app.UseCookieAuthentication(appOption)
    End Sub
End Class
