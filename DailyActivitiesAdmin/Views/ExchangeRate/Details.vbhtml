@ModelType ExchangeRate
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.SEQ }) |
    @Html.ActionLink("Back to List", "Index")
</p>
