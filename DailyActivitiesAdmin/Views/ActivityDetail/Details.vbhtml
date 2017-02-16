@ModelType ActivityDetail
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ActivityDetail</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CCY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CCY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cost)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cost)
        </dd>

    </dl>
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
