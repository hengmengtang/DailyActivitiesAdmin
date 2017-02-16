Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesAdmin
    Public Class ActivityController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /Activity/
        Function Index() As ActionResult
            Return View(db.Activities.ToList())
        End Function

        ' GET: /Activity/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activity As Activity = db.Activities.Find(id)
            If IsNothing(activity) Then
                Return HttpNotFound()
            End If
            Return View(activity)
        End Function

        ' GET: /Activity/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Activity/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="activity_id,activity_name,date,start_time,end_time,location,execute_status,description")> ByVal activity As Activity) As ActionResult
            If ModelState.IsValid Then
                db.Activities.Add(activity)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(activity)
        End Function

        ' GET: /Activity/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activity As Activity = db.Activities.Find(id)
            If IsNothing(activity) Then
                Return HttpNotFound()
            End If
            Return View(activity)
        End Function

        ' POST: /Activity/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "activity_id,activity_name,date,start_time,end_time,location,execute_status,description")> ByVal activity As Activity) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activity).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(activity)
        End Function

        ' GET: /Activity/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activity As Activity = db.Activities.Find(id)
            If IsNothing(activity) Then
                Return HttpNotFound()
            End If
            Return View(activity)
        End Function

        ' POST: /Activity/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activity As Activity = db.Activities.Find(id)
            db.Activities.Remove(activity)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        '==============My code==================
        Public Function CreateDailyActivity() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Function CreateDailyActivity(<Bind(include:="username")> useraccount As UserAccount, <Bind(Include:="activity_name,date,start_time,end_time,location,execute_status,description")> activity As Activity, frm As FormCollection) As ActionResult
            Dim cost As Double = Double.Parse(Request("txtCost").ToString)
            Dim ccy As String = Request("txtCCY").ToString
            db.Create_DailyActivity(useraccount.username, activity.activity_name, activity.date, activity.start_time, activity.end_time, activity.location, activity.execute_status, ccy, cost, activity.description)
            db.SaveChanges()
            Return View()
        End Function

        Public Function UserDashboard(username As String) As ActionResult
            Dim activity As List(Of ActivityToday_Result) = Nothing
            If ModelState.IsValid Then
                activity = db.ActivityToday(username).ToList()
            Else
                ModelState.AddModelError("", "Activity Detail today not found!")
            End If

            Return View(activity.ToList)
        End Function

        <HttpPost>
        Public Function ShowActivity(frm As FormCollection) As ActionResult
            Dim activity As List(Of GetDailyActivityFromDateToDate_Result) = Nothing
            Try
                Dim username As String = Request("txtUsername").ToString
                Dim statDate As Date = Convert.ToDateTime(Request("txtStatDate").ToString)
                Dim endDate As Date = Convert.ToDateTime(Request("txtEndDate").ToString)
                activity = db.GetDailyActivityFromDateToDate(username, statDate, endDate).ToList
            Catch ex As Exception
                ModelState.AddModelError("", "Stat Date or End Not Select!")
            End Try

            Return View(activity.ToList)
        End Function

        Public Function Show() As ActionResult
            Return View()
        End Function

        '<HttpPost>
        'Public Function Show(frm As FormCollection) As ActionResult

        '    Return Redirect("Activity")
        'End Function
    End Class

End Namespace
