@ModelType IEnumerable(Of Activity)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.activity_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.start_time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.end_time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.location)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.execute_status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.activity_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.start_time)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.end_time)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.location)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.execute_status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.activity_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.activity_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.activity_id })
        </td>
    </tr>
Next

</table>
