@ModelType Activity
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Activity</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.activity_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.activity_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.start_time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.start_time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.end_time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.end_time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.location)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.location)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.execute_status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.execute_status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.activity_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
