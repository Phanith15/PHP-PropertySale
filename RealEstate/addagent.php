
<?php
    if(!session_id()) session_start();
    if(!isset($_SESSION['admin'])){
        header("Location:index.php?page=admin");
    }
?>
<div class="container">
<div class="row" style="width: 100%">
    <div class="register-header">
        <h2>Enter Agent information</h2>
    </div>
    <div class="register-input" style="margin-bottom: 10px">
        <form action="index.php?page=addagent" method="post" enctype="multipart/form-data">
        <p><input type="text" name="txtname" autocomplete="off" placeholder="Name" required></p>
        <p><input type="text" name="txtphone" autocomplete="off" placeholder="Phone" required></p>
        <p><input type="text" name="txtemail" autocomplete="off" placeholder="Email" required></p> <br>
        <input class="button" type="submit" name="submit" value="Upload" style="width: 150px"/>
        </form>
        <?php
        //add into database
        if(isset($_POST['submit'])){
            $con = mysqli_connect("localhost","root","");
            if(!$con){
                echo "Not connected to server.";
            }
            if (!mysqli_select_db($con,'realestate')){
                echo "Database Not Selected.";
            }
            $name = $_POST['txtname'];
            $phone = $_POST['txtphone'];
            $email = $_POST['txtemail'];
        
            if (!empty($name) and !empty($phone) and !empty($email)){
                $sql = "INSERT INTO agent (name,phone,email) VALUES('$name','$phone','$email')";
                if(!mysqli_query($con,$sql)){
                    echo "Can not insert into database.";
                }else{
                    echo "Successfully inserted.";
                }
            }
            else{
            
                ?> <p class="error"> <?php echo "Missing data. Please enter all data.";  ?></p>
                <?php
            }
        }
        ?>
    </div>
</div>  
</div>