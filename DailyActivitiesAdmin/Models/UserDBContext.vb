Imports System.Data.Entity

Public Class UserDBContext
    Inherits DbContext

    Public Property UserLogin As DbSet(Of UserAccount)
End Class
