@ModelType IEnumerable(Of GetDailyActivityFromDateToDate_Result)
<table class="table table-bordered table-striped table-responsive">
    <tr>
        <th>
            Activity Name
        </th>
        <th>
            Date
        </th>
        <th>
            Stat Time
        </th>
        <th>
            End Time
        </th>
        <th>
            Location
        </th>
        <th>
            Status
        </th>
        <th>
            Cost
        </th>
        <th>
            Description
        </th>
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
                @Html.DisplayFor(Function(modelItem) item.cost)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.description)
            </td>
        </tr>
    Next
</table>

<div>
    <input type="button" class="btn btn-info" value="Back" onclick="location.href = '@Url.Action("Show")';" />
</div>