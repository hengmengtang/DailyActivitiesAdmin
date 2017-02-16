@ModelType UserAccount
@Code
    ViewData("Title") = "User"
End Code

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        @Html.ValidationSummary(true)

        <div class="form-group">
            <div class="col-md-10">
                <input class="form-control" value="@Session("username")" type="hidden" />
            </div>
        </div>

    </div>
End Using

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
