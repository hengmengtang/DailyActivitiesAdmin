@ModelType ActivityDetail
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>ActivityDetail</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.user_id)

        @Html.HiddenFor(Function(model) model.activity_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CCY, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CCY)
                @Html.ValidationMessageFor(Function(model) model.CCY)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.rate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.rate)
                @Html.ValidationMessageFor(Function(model) model.rate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Cost, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Cost)
                @Html.ValidationMessageFor(Function(model) model.Cost)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
