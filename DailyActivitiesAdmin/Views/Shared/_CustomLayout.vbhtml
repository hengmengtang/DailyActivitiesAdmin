@ModelType UserAccount
<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="panel with-nav-tabs panel-primary">
                <div class="panel-heading" style="background-color: #F5F5F5; ">
                    <!--panel header-->
                    <ul class="nav nav-tabs">
                        <li class="active" style="font-size: 22px;text-align:center; ">
                            <a href="#login" data-toggle="tab">Login Page </a>
                        </li>
                    </ul>
                 </div>
                    <!--panel body-->
                    <div id="panel-collapse-1" class="collapse in" aria-expanded="true">
                        <div class="panel-body panel panel-default" style="min-height: 200px;padding: 15px;">
                            <div class="tab-content">
                                <div class="tab-pane fade active in" id="login">                                 
                                        @RenderBody()                           
                                </div>
                            </div>
                        </div>
                    </div>
            </div>
        </div>
        </div>
        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
</body>
</html>
