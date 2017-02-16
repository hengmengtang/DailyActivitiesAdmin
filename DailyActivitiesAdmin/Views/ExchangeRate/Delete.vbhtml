@ModelType ExchangeRate
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ExchangeRate</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MONTH)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MONTH)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CCY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CCY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RATE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RATE)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
