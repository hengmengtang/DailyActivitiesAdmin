<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav id="navbar-top" class="navbar navbar-inverse" role="navigation">
        <div>
            <div class="navbar-header">
                <img src="1.png">
            </div>

            <div>
                <div>

                </div>
                <div class="pull-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">ទំព័រដើម</a></li>
                        <li><a href="#">អំពីយើង</a></li>
                        <li><a href="#">ទំនាក់ទំនង</a></li>
                    </ul>

                    <ul class="nav navbar-nav">
                        <li class="dropdown pull-right">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                                <i class="glyphicon glyphicon-user"></i>
                            </a>
                            <ul class="dropdown-menu dropdown-user">
                                <li>
                                    <a href="#"><i class="glyphicon glyphicon-user"></i> User Profile </a>
                                </li>
                                <li>
                                    <a href="~/Login"><i class="glyphicon glyphicon-log-in"></i> Log In</a>
                                </li>
                                <li class="divider"></li>
                                <li>
                                    <a href="~/Logout"><i class="glyphicon glyphicon-log-out"></i> Log Out</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>

            </div>
        </div>
    </nav>
   @*end nav-header*@ 

   <div id="page-body">
       <div id="sidebar" class="navbar-inverse sidebar" role="navigation" style="background: black">
           <div id="sidebar-nav" class="sidebar-nav navbar-collapse">
               <ul class="nav" id="side-menu">
                   <li>
                       <a href="~/Dashboard/@Session("username").ToString" ><i class="glyphicon glyphicon-dashboard"></i> Dashboard</a>
                   </li>
                   <li>
                       <a href="~/Create"><i class="glyphicon glyphicon-pencil"></i> Create Daily Activities</a>
                   </li>
                   <li>
                       <a href="~/Show"><i class="glyphicon glyphicon-eye-open"></i> Show Daily Activities</a>
                   </li>
               </ul>
           </div>
       </div>

       <div id="page-wrapper">
           <div class="container">
               <div class="row" style="margin-top: 45px;">
                   @RenderBody()
               </div>
           </div>
       </div>

   </div>

    <div id="footer" class="head" style="background: black;">
        <center>
            <p style="color:white;">All Rights Reserved, Copyright © 2016 Royal University of Phnom Penh (RUPP)<br>Russian Federation Boulevard, Toul Kork, Phnom Penh, Cambodia. Tel: 855-23-883-640 Fax: 855-23-880-116  <br>Designed by: <a href="http://www.rupp.edu.kh/center/itcenter" title="">IT Center</a></p>
        </center>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
