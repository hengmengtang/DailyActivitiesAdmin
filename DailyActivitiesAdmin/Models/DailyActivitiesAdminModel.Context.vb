﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class DailyActivityDBEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DailyActivityDBEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Activities() As DbSet(Of Activity)
    Public Overridable Property ActivityCategories() As DbSet(Of ActivityCategory)
    Public Overridable Property ActivityDetails() As DbSet(Of ActivityDetail)
    Public Overridable Property ActivitySubCategories() As DbSet(Of ActivitySubCategory)
    Public Overridable Property Jobs() As DbSet(Of Job)
    Public Overridable Property Users() As DbSet(Of User)

End Class
