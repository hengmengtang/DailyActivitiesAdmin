﻿@ModelType UserAccount
@Code
    ViewData("Title") = "Register"
End Code

<h2>Register</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>UserAccount</h4>
        <hr />
        <div>
            <h4>
                @If ViewBag.Message IsNot Nothing Then
                        ViewBag.Message()
                    End If
            </h4>
        </div>
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_id, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_id)
                @Html.ValidationMessageFor(Function(model) model.user_id)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.first_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.first_name)
                @Html.ValidationMessageFor(Function(model) model.first_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.last_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.last_name)
                @Html.ValidationMessageFor(Function(model) model.last_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.username, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.username)
                @Html.ValidationMessageFor(Function(model) model.username)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.gender, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.gender)
                @Html.ValidationMessageFor(Function(model) model.gender)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.email, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.email)
                @Html.ValidationMessageFor(Function(model) model.email)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.password, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.password)
                @Html.ValidationMessageFor(Function(model) model.password)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.confirmpassword, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.confirmpassword)
                @Html.ValidationMessageFor(Function(model) model.confirmpassword)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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