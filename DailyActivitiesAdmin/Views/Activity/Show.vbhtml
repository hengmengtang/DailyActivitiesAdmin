@ModelType IEnumerable(Of GetDailyActivityFromDateToDate_Result)
@Code
    ViewData("Title") = "ShowActivity"
End Code

<div class="container">
    <div class="panel-group">
        <div class="panel panel-default">
            <div class="panel-heading">Show Activity</div>
            <div class="panel-body">
                @Using (Html.BeginForm("ShowActivity", "Activity", FormMethod.Post))
                    @Html.AntiForgeryToken()

                    @<div class="panel-body">
                        <input type="submit" value="Show" class="btn btn-default pull-right btn btn-success" />
                    </div>

                    @<div class="form-horizontal">
                        @Html.ValidationSummary(True)

                        <input type="hidden" name="txtUsername" value="@Session("username")" />
                        <div class="form-group">
                            <label class="control-label col-sm-2">Stat Date: </label>
                            <div class="col-sm-10">
                                <input type="date" class="form-control" name="txtStatDate" required />
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="control-label col-sm-2">End Date: </label>
                            <div class="col-sm-10">
                                <input id="myDate" type="date" class="form-control" name="txtEndDate" required />
                            </div>                         
                        </div>
                    </div>
                End Using
            </div>
        </div>
    </div>
</div>
