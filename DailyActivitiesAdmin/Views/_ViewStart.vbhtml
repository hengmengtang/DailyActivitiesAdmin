@Code
    Dim current As String = Convert.ToString(HttpContext.Current.Request.RequestContext.RouteData.Values("Controller"))
    Select Case current
        Case "UserAccount"
            Layout = "~/Views/Shared/_CustomLayout.vbhtml"
            Exit Select
        Case Else
            Layout = "~/Views/Shared/_Layout.vbhtml"
            Exit Select
    End Select
End Code
