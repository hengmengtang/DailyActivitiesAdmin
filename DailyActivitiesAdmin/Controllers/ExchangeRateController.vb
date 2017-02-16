Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesAdmin
    Public Class ExchangeRateController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /ExchangeRate/
        Function Index() As ActionResult
            Return View(db.ExchangeRates.ToList())
        End Function

        ' GET: /ExchangeRate/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exchangerate As ExchangeRate = db.ExchangeRates.Find(id)
            If IsNothing(exchangerate) Then
                Return HttpNotFound()
            End If
            Return View(exchangerate)
        End Function

        ' GET: /ExchangeRate/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /ExchangeRate/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "SEQ,FY,MONTH,CCY,RATE")> ByVal exchangerate As ExchangeRate) As ActionResult
            If ModelState.IsValid Then
                db.ExchangeRates.Add(exchangerate)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(exchangerate)
        End Function

        ' GET: /ExchangeRate/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exchangerate As ExchangeRate = db.ExchangeRates.Find(id)
            If IsNothing(exchangerate) Then
                Return HttpNotFound()
            End If
            Return View(exchangerate)
        End Function

        ' POST: /ExchangeRate/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "SEQ,FY,MONTH,CCY,RATE")> ByVal exchangerate As ExchangeRate) As ActionResult
            If ModelState.IsValid Then
                db.Entry(exchangerate).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(exchangerate)
        End Function

        ' GET: /ExchangeRate/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exchangerate As ExchangeRate = db.ExchangeRates.Find(id)
            If IsNothing(exchangerate) Then
                Return HttpNotFound()
            End If
            Return View(exchangerate)
        End Function

        ' POST: /ExchangeRate/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim exchangerate As ExchangeRate = db.ExchangeRates.Find(id)
            db.ExchangeRates.Remove(exchangerate)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
