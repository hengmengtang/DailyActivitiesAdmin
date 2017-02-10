Imports System.Web.Mvc
Imports System.ComponentModel.DataAnnotations

Public Class UserLoginController
    Inherits Controller

    Public Function Index() As ActionResult
        Using db As New UserDBContext
            Return View(db.UserLogin.ToList())
        End Using
    End Function

    Function Register() As ActionResult
        Return View()
    End Function

    <HttpPost()>
    Public Function Register(account As UserAccount) As ActionResult
        If ModelState.IsValid Then
            Using db As New UserDBContext
                With db
                    .UserLogin.Add(account)
                    .SaveChanges()
                End With
            End Using
            ModelState.Clear()
            ViewBag.Message = account.first_name & " " & account.last_name & " succesfully registered."
        End If
        Return View()
    End Function

    'Login
    Public Function Login() As ActionResult
        Return View()
    End Function

    <HttpPost()>
    Public Function Login(user As UserAccount) As ActionResult
        Using db As New UserDBContext
            With db
                Dim usr = .UserLogin.Where(Function(u As UserAccount) u.username = user.username And u.password = user.password).FirstOrDefault
                If usr IsNot Nothing Then
                    Session("UserID") = usr.user_id.ToString
                    Session("UserName") = usr.UserName.ToString
                    Return RedirectToAction("LoggedIn")
                Else
                    ModelState.AddModelError("", "Username or Password is wrong.")
                End If
            End With
            Return View()
        End Using
    End Function

    Public Function LoggedIn() As ActionResult
        If Session("UserID") IsNot Nothing Then
            Return View()
        Else
            Return RedirectToAction("Login")
        End If
    End Function
End Class