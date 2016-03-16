<?php
    //echo "hello loginheader";
    if(!session_id()) session_start();
    if(isset($_SESSION['userlogin'])){ //if we're logged in then display the page cpanel.php
        include("userlogoutpanel.php");
    }else{ // if not logged in , then display the log in page.
        include("registerpanel.php");
    }
    
?>