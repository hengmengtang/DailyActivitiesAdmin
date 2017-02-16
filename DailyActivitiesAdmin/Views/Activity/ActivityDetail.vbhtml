@ModelType ActivityDetail
@Code
    ViewData("Title") = "ActivityDetail"
End Code

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        @Html.ValidationSummary(true)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CCY, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CCY)
                @Html.ValidationMessageFor(Function(model) model.CCY)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Cost, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Cost)
                @Html.ValidationMessageFor(Function(model) model.Cost)
            </div>
        </div>

    </div>
End Using

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
