Imports System.Data.Entity

Public Class DailyActivityDBContext
    Inherits DbContext

    Public Property UserLogin As DbSet(Of UserAccount)
End Class
