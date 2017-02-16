@ModelType ExchangeRate
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>ExchangeRate</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.FY, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FY)
                @Html.ValidationMessageFor(Function(model) model.FY)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MONTH, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MONTH)
                @Html.ValidationMessageFor(Function(model) model.MONTH)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CCY, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CCY)
                @Html.ValidationMessageFor(Function(model) model.CCY)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.RATE, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.RATE)
                @Html.ValidationMessageFor(Function(model) model.RATE)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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
