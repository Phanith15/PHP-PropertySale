<!DOCTYPE html>
    <?php
        include("dbconnect.php");
    ?>
    
<html>
    <head>
        <meta charset= "UTF-8">
        <!--<meta name="viewport" content="width=device-width, initial-scale=1.0">-->
        <!--Link to new create css file-->
        <link href="css1/style.css" rel="stylesheet">
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
        <link href="bootstrap/css/mynewstyling.css" rel="stylesheet">
        <link rel="shortcut icon" href="images/iconKS.png"><!--Add icon to your webpage.-->
        <title> The Property For Sale</title>
    </head>
    <body bgcolor="#838383">
        <!--New Design1-->
        <div class="page-header no-margin no-padding" style="background-color: #0f0f0f">
            <div class="container">
                <img src="images/OT.gif" height="110px;"/> <!--Header image-->
            </div>
            
        </div>
        <nav class="navbar navbar-inverse navbar-static-top " role="navigation" style="margin:0px;"><!--navbar-fixed-top-->
            <div class="container">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-OnlineTrade-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.php">ONLINE-TRADES</a>
                </div>
                <div class="collapse navbar-collapse" id="bs-OnlineTrade-navbar-collapse-1">
                    
                    <ul class="nav navbar-nav navbar-center">
                        <?php ob_start(); ?><!--Enable redirect header when user enter correct password in checkuserlogin.php-->
                        <li style="color: white"><a href="index.php"><i class="glyphicon glyphicon-home"></i> Home</a></li>
                        <li><a href="index.php?page=propertysearch"><i class="glyphicon glyphicon-briefcase"></i> For Sale</a></li>
                        <li><a href="index.php?page=accessories"><i class="glyphicon glyphicon-phone"></i> Accessories</a></li>
                        <li><a href="index.php?page=about"><i class="glyphicon glyphicon-info-sign"></i> About</a></li>
                        <li><a href="index.php?page=contact"><i class="glyphicon glyphicon-phone-alt"></i> Contact</a></li>
                        <li ><a href="index.php?page=admin"><i class="glyphicon glyphicon-lock"></i> Admin</a></li>
                        
                        <!--<li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Sale<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Link1</a></li>
                                <li><a href="#">Link2</a></li>
                                <li><a href="#">Link3</a></li>
                            </ul>
                        </li>-->
                    </ul>
                    <div>
                        <?php
                            include("loginheader.php");
                        ?>
                    </div>
                    <!--Javascript for highting on current page-->
                    <script type="text/javascript" src="js/jquery.js"></script>
                    <script>
                        $(function(){// For hilight on current page.
                            $('a').each(function(){
                                if($(this).prop('href')==window.location.href){
                                     $(this).addClass('current');
                                } 
                            });
                        });
                    </script>
                    <!--End Javascript-->
                    
                </div>
            </div>
            </div>
        </nav>
        
        <!--End New Design1-->
       <!--Testing1 <header class="header-top">
            <a href="index.php"><img src="images/OT.gif" height="90%" width= "20%"/></a>
            <div class="weblogo-top-left"></div>
            <div class="weblogo-top-right"></div>
        </header> End Testing1-->
        
       <!-- <header class="header">
            <div class="weblogo">
                <!--<a href="index.php"><img src="images/kh24.gif" height="70%" width= "70%" style=""/></a> -->
            <!--</div>
            <?php
                //include("loginheader.php");
                //include("menuheader.php");
            ?>
        <!--</header>-->
       
        <!--Trial new -->
         <?php
            if(!isset($_GET['page'])){
                ?>
                <div class="bodybanner"> <!--bodybanner-->
                    <div id="photos">
                        <img src="images/1.jpg" class="img-responsive"/>
                        <img src="images/2.jpg" class="img-responsive"/>
                        <img src="images/3.jpg" class="img-responsive"/>
                        <img src="images/4.jpg" class="img-responsive"/>
                        <img src="images/5.jpg" class="img-responsive"/>
                        <img src="images/6.jpg" class="img-responsive"/>
                        <img src="images/7.jpg" class="img-responsive"/>
                        <img src="images/8.jpg" class="img-responsive"/>
                    </div>
                    <script type="text/javascript" src="js/jquery.js"></script>
                    <script type="text/javascript" src="bannershow.js"></script>
                </div> <?php
            }
        ?>    
        
       <div class="container"> <!--bodycontainer-->
            <?php
                if (!isset($_GET['page'])){
                    ?>
                        <div style="padding-top:405px"></div>
                    <?php
                    include("home.php");
                }
            ?>
       </div>
       <div class="searchpanel-property" style="padding-top:0"><!--searchpanel-property-->
        <?php
            if(isset($_GET['page'])){
                 $page= $_GET['page'];
                include("$page.php");
            }
        ?>
       </div>
       
       <div class="footertop">
            <a href="index.php"><img src="images/OT.gif" height="90%" width= "20%"/></a>
        </div>
       <footer class="footer">
            <!--<img src="images/back1.png" id="bg" alt="">-->
            <div class="footerrow">
                
                <div class= "row">
                    <!--<a href="index.php"><img src="images/AT.jpg" height="100%" width= "50%" style="margin-top:50px"/></a>-->
                </div>
                
                 <p style="margin-top:50px">Instant update database project by <a href="mailto:pnlovenz@gmail.com">pnlovenz@gmail.com</a></p>
                 <p>Copyright 2016 Khmer24Stars(New Zealand). All rights reserved.</p>
            </div>
           
        </footer>
       
       <script scr="bootstrap/js/jquery1.12.1.js"></script>
       <script src="bootstrap/js/bootstrap.min.js"></script>
    </body>
</html>