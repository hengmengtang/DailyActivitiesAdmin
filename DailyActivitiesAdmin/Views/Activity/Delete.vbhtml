@ModelType Activity
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
