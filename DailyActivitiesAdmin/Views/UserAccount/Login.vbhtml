@ModelType UserAccount
@Code
    ViewData("Title") = "Login"
End Code

@Using Html.BeginForm("Login", "UserAccount", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()
    
    @<div class="panel-body">
            <input type="submit" value="Login" class="btn btn-default pull-right btn btn-success" />
        </div>
    
    @<div class="form-horizontal">      
        @Html.ValidationSummary(true)

        <div class="form-group">
            <label class="control-label col-md-2">User Name : </label>
                @Html.TextBoxFor(Function(model) model.username, New With {.class = "form-control", .placeholder = "UserName"})
                @Html.ValidationMessageFor(Function(model) model.username)         
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">Password : </label>      
              @Html.TextBoxFor(Function(model) model.password, New With {.type = "password", .class = "form-control", .placeholder = "Password"})
              @Html.ValidationMessageFor(Function(model) model.password)      
        </div>

        <div>
            <a href="@Url.Action("Register")" class="col-md-offset-6 btn-link">Register</a>
        </div>
    </div>
End Using

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
