
<div class="container">
<div class="row" style="width: 100%">
    <div class="register-header">
        <h2>Register</h2>
    </div>
    
    <div class="register-input" style="margin-bottom: 10px">
        <form action="index.php?page=register" method="post" enctype="multipart/form-data">
            <p>Username or email </p><input type="text" name="txtemail" autocomplete="off" placeholder="Username or email" id="email" required/>
            <p>Password </p><input type="password" name="txtpassword" autocomplete="off" placeholder="Password" id="password" required/> <br>
            <input type="submit" name="submit" value="Submit" style="width: 150px" class="button"/>
        </form>
        <?php
        $salt = md5('newzealand');
        $key = md5('newzealand');
        
        //Encrypt
        function encrypt($string,$key){
            $string = rtrim(base64_encode(mcrypt_encrypt(MCRYPT_RIJNDAEL_256,$key,$string,MCRYPT_MODE_ECB)));
            return $string;
        }
        //Decrypt
        function decrypt($string,$key){
            $string = rtrim(mcrypt_decrypt(MCRYPT_RIJNDAEL_256,$key,base64_decode($string),MCRYPT_MODE_ECB));
            return $string;
        }
        function hashword($string,$salt){
            $string = crypt($string,"$1$".$salt."$");
            return $string;
        }
        if(isset($_POST['submit'])){
            $con = mysqli_connect("localhost","root","");
            if(!$con){
                echo "Not connected to server.";
            }
            if(!mysqli_select_db($con,'realestate')){
                echo "Database not selected.";
            }
            $username = $_POST['txtemail'];
            $passcode = $_POST['txtpassword'];
            
            if(!empty($username) and !empty($passcode)){ 
               //$password = hashword($passcode,$salt); //encryption password
               $password = encrypt($passcode,$key);
                $sql = "INSERT INTO user (username,password,roleid) VALUES('".encrypt($username,$key)."','$password','2')";
                if(!mysqli_query($con,$sql)){
                    echo "Cannot insert into database.";
                }else{
                    ?> <p class="successful"><?php echo "Successfully inserted.";?></p>
                    <?php
                    
                }
            }else{
                ?> <p class= "error"><?php echo "Missing data. Please enter all data."; ?></p>
                <?php
            } 
        }
        ?>
    </div>
</div>
</div>
