<?php
     if(!session_id()) session_start();
    if(!isset($_SESSION['admin'])){
        header("Location:index.php?page=admin");
    }
    if(!isset($_SESSION['addproperty'])){
        $_SESSION['addproperty']['locationid']= "";
        $_SESSION['addproperty']['agentid']="";
        $_SESSION['addproperty']['address']= "";
        $_SESSION['addproperty']['price']= "";  
    }
?>
<div class="container">
<div class="row full-width">
    <div class="add-property-title">
        <h3>Enter Property Details</h3>
    </div>
     <script type="text/javascript" src="js/jquery.js"></script>
     <script type="text/javascript" src="showdistricts.js"></script> <!-- Get All Districts and show to dropdownlist-->
     <script type="text/javascript" src="showsuburbs.js"></script><!-- Get All Suburbs and show to dropdownlist-->
     
     <div class="add-property">
          
    <form method="post" action="index.php?page=addproperty" enctype="multipart/form-data">
        
         <p style="padding-left: 5px">Agent:<select class="dropdownagent" name="agentID">
           <?php
                $sql = "SELECT * FROM agent";
                $qry = mysqli_query($dbconn,$sql);
                $rs = mysqli_fetch_assoc($qry);
                do{
                    ?>
                    <option value="<?php echo $rs['agentid'];?>"
                    
                    ><?php echo $rs['name'];?> </option>
                <?php }while($rs=mysqli_fetch_assoc($qry));
            ?> 
        </select></p>
         <p style="padding-left: 5px">Location:<select id="slcRegion" class="dropdownloc" name="locationID" onClick="showDistricts();">
            <?php
                $locatlist_sql = "SELECT * FROM location";
                $locatlist_qry = mysqli_query($dbconn,$locatlist_sql);
                $locatlist_rs = mysqli_fetch_assoc($locatlist_qry);
                do{?>
                    <option value="<?php echo $locatlist_rs['locationid'];?>"
                    <?php
                        if($locatlist_rs['locationid']==$_SESSION['addproperty']['locationid']){
                            echo "selected = selected";
                        }
                    ?>
                    ><?php echo ucwords(strtolower($locatlist_rs['locationname'])); ?> </option> <!--Set first letter to capital-->
                <?php }while($locatlist_rs = mysqli_fetch_assoc($locatlist_qry));
            ?>
        </select></p>
        <p style="padding-left: 5px">District: <select class="dropdownloc" id="slcDistrict" name="slc_districtid" onclick="showSuburbs();"> </select></p>
        <p style="padding-left: 5px">Suburb: <select class="dropdownloc" id="slcSuburb" name="slc_suburbid" ></select></p>
        
        <p style="padding-left: 5px">Property Image:<input class="uploadfile" type="file" name="image" id="fileToUpload"/></p>
        <p style="padding-left: 5px">Price: $<input class="addproperty-price" type="number" name="price" value= "<?php echo $_SESSION['addproperty']['price'];?>"</p>
        <p style="padding-left: 5px">Address: <input class="addproperty-address" type="text" name="address" value="<?php echo $_SESSION['addproperty']['address'];?>"</p>
        <p style="padding-left: 5px">Description:<textarea class="description" name="description" cols=60 rows=5></textarea></p>
        <input class="button" type= "submit" name="submit" value="Upload" style="width:150px" />
   </form>
</div>
    <?php
        if (isset($_POST['submit'])){
           // require("dbconnect.php");
            $con= mysqli_connect("localhost","root","");
            if (!$con){
                echo 'Not connected to server.';
            }
            if (!mysqli_select_db($con,'realestate')){
                echo 'Database Not Selected.';
            }
            $agentid = $_POST['agentID'];
            $locationID = $_POST['locationID'];
            $price = $_POST['price'];
            $addresss= $_POST['address'];
            $description = $_POST['description'];
            if(!empty($_POST['slc_districtid'])and !empty($_POST['slc_suburbid'])){
               $districtid= $_POST['slc_districtid'];
               $suburbid = $_POST['slc_suburbid'];
            }
            //echo "District ID is ".$districtid." and suburb ID ".$suburbid;
            
            $imageName = mysql_real_escape_string($_FILES["image"]["name"]);
            //$imageData = mysql_real_escape_string(file_get_contents($_FILES["image"]["tmp_name"]));
            
            $imageData = addslashes($_FILES['image']['tmp_name']);
            if(empty($imageData)){
               ?><p class="error" style="margin-left: 10px"><?php echo "Please choose image from file!";?></p>
               <?php
            }else{
               $imageData = file_get_contents($imageData);
            }
            
            $imageData = base64_encode($imageData);
            
            $imageType = mysql_real_escape_string($_FILES["image"]["type"]);
            //pick up first 5 charecters of the string $imagetype
            if(substr($imageType,0,5)=="image"){
                //insert image into db
                //echo $_POST['price'];
                if (!empty($imageName) and !empty($price) and !empty($addresss)){
                    $sql = "INSERT INTO property (locationid,districtid,suburbid,propertyname,propertyimage,price,address,description,agentid) VALUES('$locationID','$districtid','$suburbid','$imageName','$imageData','$price','$addresss','$description','$agentid')";
                    if(!mysqli_query($con,$sql)){
                        echo 'Cant not insert into database.';
                    }else{
                        echo 'Successfully inserted.';
                    }
                }
                else{
                    ?> <p class="error"><?php  die("Missing data. Please enter all data again."); ?></p>
                   <?php
                }
                
                
            }else{
               ?><p class="error" style="margin-left:10px"><?php echo " Only images are allowed."; ?></p>
               <?php
            }
        
        }
    ?>
    
</div>