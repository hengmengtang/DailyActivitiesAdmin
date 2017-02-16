Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesAdmin
    '<Authorize>
    '<CustomizeAuth>
    Public Class UserAccountController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /UserAccount/
        Function Index() As ActionResult
            Return View(db.UserAccounts.ToList())
        End Function

        ' GET: /UserAccount/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim useraccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(useraccount) Then
                Return HttpNotFound()
            End If
            Return View(useraccount)
        End Function

        ' GET: /UserAccount/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /UserAccount/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="user_id,first_name,last_name,username,gender,email,password,confirmpassword")> ByVal useraccount As UserAccount) As ActionResult
            If ModelState.IsValid Then
                db.UserAccounts.Add(useraccount)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(useraccount)
        End Function

        ' GET: /UserAccount/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim useraccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(useraccount) Then
                Return HttpNotFound()
            End If
            Return View(useraccount)
        End Function

        ' POST: /UserAccount/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="user_id,first_name,last_name,username,gender,email,password,confirmpassword")> ByVal useraccount As UserAccount) As ActionResult
            If ModelState.IsValid Then
                db.Entry(useraccount).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(useraccount)
        End Function

        ' GET: /UserAccount/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim useraccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(useraccount) Then
                Return HttpNotFound()
            End If
            Return View(useraccount)
        End Function

        ' POST: /UserAccount/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim useraccount As UserAccount = db.UserAccounts.Find(id)
            db.UserAccounts.Remove(useraccount)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        <AllowAnonymous>
        Function Register() As ActionResult
            Return View()
        End Function

        <AllowAnonymous>
        <HttpPost()>
        Public Function Register(account As UserAccount) As ActionResult
            If ModelState.IsValid Then
                With db
                    .UserAccounts.Add(account)
                    .SaveChanges()
                End With
                ModelState.Clear()
                ViewBag.Message = account.first_name & " " & account.last_name & " succesfully registered."
            End If
            Return View()
        End Function

        <AllowAnonymous>
        Public Function Login() As ActionResult
            Return View()
        End Function

        <AllowAnonymous>
        <HttpPost>
        Public Function Login(user As UserAccount) As ActionResult
            Using db As New DailyActivityDBEntities
                With db
                    Dim usr = .UserAccounts.Where(Function(u As UserAccount) u.username = user.username And u.password = user.password).FirstOrDefault
                    If usr IsNot Nothing Then
                        FormsAuthentication.SetAuthCookie(user.username, False)
                        Session("user_id") = user.user_id.ToString
                        Session("username") = user.username.ToString
                        Return Redirect("~/Dashboard/" & user.username)
                    Else
                        ModelState.AddModelError("", "Incorrect User or Password")
                        Return View()
                    End If
                End With
            End Using
        End Function

        <HttpPost>
        Public Function LogOut() As ActionResult
            If Session("user_id") IsNot Nothing And Session("username") IsNot Nothing Then
                Session.RemoveAll()
            End If
            FormsAuthentication.SignOut()
            Return Redirect("Login")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
