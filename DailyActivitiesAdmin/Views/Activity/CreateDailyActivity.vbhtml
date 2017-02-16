@ModelType Activity
@Code
    ViewData("Title") = "CreateDailyActivity"
End Code

<div class="panel panel-default">
    <div class="panel-heading">Write your Daily Activity</div>
    <div class="panel-body">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="panel-body">
                <input type="submit" value="Create" class="btn btn-default pull-right btn btn-success" />
            </div>

            @<div class="form-horizontal">
                @Html.ValidationSummary(True)

                @Html.Partial("User")

                <div class="form-group">
                    <label class="control-label col-sm-2">Activity Name:</label>
                    <div class="col-sm-10">
                        @Html.TextBoxFor(Function(model) model.activity_name, New With {.value = Session("username"), .class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.activity_name)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Date:</label>
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.date, New With {.type = "date", .required = "required", .class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.date)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Stat Time:</label>
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.start_time, New With {.type = "time", .required = "required", .class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.start_time)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">End Time:</label>
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.end_time, New With {.type = "time", .required = "required", .class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.end_time)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Location:</label>
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.location, New With {.required = "required", .class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.location)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Execute Status:</label>
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.execute_status)
                        @Html.ValidationMessageFor(Function(model) model.execute_status)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">CCY</label>
                    <div class="col-sm-10">
                        <select class="form-control" name="txtCCY">
                            <option value="RIEL">Riel</option>
                            <option class="USE">USD</option>
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Cost:</label>
                    <div class="col-sm-10">
                        <input class="form-control" type="number" name="txtCost" />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Description:</label>
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.description, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.description)
                    </div>
                </div>
            </div>
        End Using
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
