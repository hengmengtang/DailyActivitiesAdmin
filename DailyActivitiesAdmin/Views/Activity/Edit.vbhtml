﻿@ModelType Activity
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Activity</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.activity_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.activity_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.activity_name)
                @Html.ValidationMessageFor(Function(model) model.activity_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.date, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.date)
                @Html.ValidationMessageFor(Function(model) model.date)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.start_time, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.start_time)
                @Html.ValidationMessageFor(Function(model) model.start_time)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.end_time, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.end_time)
                @Html.ValidationMessageFor(Function(model) model.end_time)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.location, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.location)
                @Html.ValidationMessageFor(Function(model) model.location)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.execute_status, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.execute_status)
                @Html.ValidationMessageFor(Function(model) model.execute_status)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.description)
                @Html.ValidationMessageFor(Function(model) model.description)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
