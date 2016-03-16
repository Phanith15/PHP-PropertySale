<?php
 //Decrypt
    $key = md5('newzealand');
    function decrypt($string,$key){
        $string = rtrim(mcrypt_decrypt(MCRYPT_RIJNDAEL_256,$key,base64_decode($string),MCRYPT_MODE_ECB));
        return $string;
    }
    if(!session_id()) session_start();
    //check to see if user is logged out
    if(isset($_GET['action'])){
        if($_GET['action']=="logout"){
            //echo "logout";
            unset($_SESSION['userlogin']); // load back to login form after logged out.
            header("Location:index.php?page=checkuserlogin"); // Redirect to login page.
            //unset($_SESSION["username"]);
        } 
    }
    //if login form has been submitted, check if username and password match
    if(isset($_POST['btnlogin'])){
        $login_sql = "SELECT * FROM user where roleid = '2' ";
        $login_qry = mysqli_query($dbconn,$login_sql);
        while($row = mysqli_fetch_assoc($login_qry)){
            if($_POST['txtusername'] == decrypt($row['username'],$key) and $_POST['txtpassword']==decrypt($row['password'],$key)){
                $_SESSION['userlogin'] = $_POST['txtusername'];
                //$is_login = true;
                $_SESSION["username"] = $_POST['txtusername'];
                $_SESSION['user_id'] = $row['userID'];
            }
        }
    }
    if(isset($_SESSION['userlogin'])){ // If correct password, then redirect to forsale page.
        
        //header("Refresh: 5; url=index.php?page=propertysearch");
        header("Location:index.php?page=propertysearch");
        //header('Refresh: 0; url=index.php'); // Refresh page  
    }else{
        include("userlogin.php");
    }
    
?>