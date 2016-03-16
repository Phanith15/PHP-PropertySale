<div class="container">
<div class="row" style="width: 100%">
    <div class="register-header">
        <h2>Login</h2>
    </div>
    <div class="register-input" style="margin-bottom: 10px">
        <form name="login" method="post" action="index.php?page=admin">
            <p>Username <input name= "username" type="text" maxlength= 50 required></p>
            <p>Password <input name= "password" type="password" maxlength= 50  required></p>
            <?php
            //Check if correct username and password
            if(isset($_POST['btnlogin'])&& !isset($_SESSION['admin'])){
                ?>
                <p><span class="error">Incorrect username or password.</span></p>
                <?php
            }
            ?>
            <br><input class="button" type="submit" name="btnlogin" value="Submit" style= "width:150px"/>
        </form>
    </div>
</div>
</div>

