<div class="container">
<div class="row" style="width: 100%">
    <div class="register-header">
        <h2>User Login</h2>
    </div>
    
    <div class="register-input" style="margin-bottom:10px">
        <form action="index.php?page=checkuserlogin" method="post" enctype="multipart/form-data">
            <p>Username or email </p><input type="text" name="txtusername" autocomplete="off" placeholder="Username or email" id="email" required/>
            <p>Password </p><input type="password" name="txtpassword" autocomplete="off" placeholder="Password" id="password" required/> <br>
            <?php
               // header('Refresh: 0; url=index.php?page=checkuserlogin'); // Refresh page 
            //Check if correct username and password
            if(isset($_POST['btnlogin'])&& !isset($_SESSION['userlogin'])){
                ?>
                <p><span class="error">Incorrect username or password.</span></p>
                <?php
            }
            ?>
            <input type="submit" name="btnlogin" value="Login" style="width: 150px" class="button"/>
        </form>
       
    </div>
</div>
</div>