'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(ActivityMetaData))>
Partial Public Class Activity
    Public Property activity_id As Integer
    Public Property activity_name As String
    Public Property [date] As Date
    Public Property start_time As System.TimeSpan
    Public Property end_time As System.TimeSpan
    Public Property location As String
    Public Property execute_status As Boolean
    Public Property description As String

    Public Overridable Property ActivityDetails As ICollection(Of ActivityDetail) = New HashSet(Of ActivityDetail)

End Class

Public Class ActivityMetaData

    <Display(name:="Activity ID:")>
    Public Property activity_id As Integer

    <Display(name:="Activity Name:")>
    Public Property activity_name As String

    <Display(name:="Date")>
    Public Property [date] As Date
    Public Property start_time As System.TimeSpan
    Public Property end_time As System.TimeSpan
    Public Property location As String
    Public Property execute_status As Boolean
    Public Property description As String
End Class