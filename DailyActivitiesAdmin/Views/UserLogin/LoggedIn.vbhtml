@Code
    ViewData("Title") = "LoggedIn"
End Code

<html>
<body>
    <h4>
        @If Session("UserID") IsNot Nothing Then
            @Session("Username").ToString        
        End If
    </h4> 
</body>
</html>



