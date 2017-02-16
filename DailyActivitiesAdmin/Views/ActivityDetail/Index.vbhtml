@ModelType IEnumerable(Of ActivityDetail)
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
            @Html.DisplayNameFor(Function(model) model.CCY)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cost)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CCY)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cost)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
