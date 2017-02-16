@ModelType IEnumerable(Of ExchangeRate)
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
            @Html.DisplayNameFor(Function(model) model.FY)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MONTH)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CCY)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RATE)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FY)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MONTH)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CCY)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RATE)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.SEQ }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.SEQ }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.SEQ })
        </td>
    </tr>
Next

</table>
