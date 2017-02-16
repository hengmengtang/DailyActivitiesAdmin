@ModelType UserAccount
@Code
    ViewData("Title") = "Register"
End Code

@Using Html.BeginForm("Register", "UserAccount", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

        @<div class="panel-body">
             <input type="submit" value="Register"  class="btn btn-default pull-right btn btn-success" />
        </div>

        @Html.ValidationSummary(True)
        @<div class="container">
            <div class="form-horizontal">

                <div class="form-group">
                    <label class="control-label col-sm-2">Fist Name : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.first_name, New With {.Class = "form-control", .placeholder = "First Name", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.first_name)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Last Name : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.last_name, New With {.class = "form-control", .placeholder = "Last Name", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.last_name)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">User Name : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.username, New With {.class = "form-control", .placeholder = "User Name", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.username)
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-2 control-label">Sex:</label>
                    <div class="col-sm-10">
                        <label class="radio-inline col-md-1">
                            Male  @Html.RadioButtonFor(Function(model) model.gender, "Male", New With {.checked = "checked"})
                        </label>
                        <label class="radio-inline col-md-2">
                            Female @Html.RadioButtonFor(Function(model) model.gender, "Female")
                        </label>
                        @Html.ValidationMessageFor(Function(model) model.gender)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Email Address : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.email, New With {.type="email",.class = "form-control", .placeholder = "Email Address", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.email)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Password : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.password, New With {.type = "password", .class = "form-control", .placeholder = "Password", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.password)
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Confirm Password : </label>
                    <div>
                        @Html.TextBoxFor(Function(model) model.confirmpassword, New With {.type = "password", .class = "form-control", .placeholder = "Confirm Password", .required = "required"})
                        @Html.ValidationMessageFor(Function(model) model.confirmpassword)
                    </div>
                </div>

                <div>
                    <a href="@Url.Action("Login")" class="col-md-offset-6 btn-link">Login</a>
                </div>

            </div>
        </div>
End Using

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
