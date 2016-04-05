<?php
//Redirect back to indexp page if no propertyID has been set
if(!isset($_GET['property_ID'])){
    header("Location:index.php");
}
$property_id = $_GET['property_ID'];

//Get image
$sql = "SELECT * FROM property WHERE propertyid=".$property_id;
$qry = mysqli_query($dbconn,$sql);
//check if query working fine
if ($qry=mysqli_query($dbconn,$sql)){
    $result= mysqli_fetch_assoc($qry);
    //Get location name
    $loc_sql = "SELECT * FROM location WHERE locationid= '".$result['locationid']."' ";
    $loc_qry = mysqli_query($dbconn,$loc_sql);
    $loc_rs = mysqli_fetch_assoc($loc_qry);
    //End Get location name
    //Get agent detail
    $agent_sql = "SELECT * FROM agent WHERE agentid= '".$result['agentid']."' ";
    $agent_qry = mysqli_query($dbconn,$agent_sql);
    $agent_rs = mysqli_fetch_assoc($agent_qry);
    //End Get agent detail
    //Get District name
    $district_sql = "SELECT * FROM district WHERE districtid ='".$result['districtid']."' ";
    $district_qry =mysqli_query($dbconn,$district_sql);
    $district_rs = mysqli_fetch_assoc($district_qry);
    // End Get District name
    //Get Suburb name
    $suburb_sql = "SELECT * FROM suburb WHERE suburbid ='".$result['suburbid']."' ";
    $suburb_qry =mysqli_query($dbconn,$suburb_sql);
    $suburb_rs = mysqli_fetch_assoc($suburb_qry);
    //End Get suburb name
    ?>
    <!-- JQery for Add to Wishlist-->
    
    <script type="text/javascript" src="js/jquery.js"></script>
<script>
   $(document).ready(function(){
        $("#wishlist").mouseover(function(){
            $("#wishlist").css("color","red");
            });
        $("#wishlist").mouseout(function(){
            $("#wishlist").css("color","black");
            });
       
        $("#wishlist").click(function(){
            //var id = <?php echo $result['propertyid']; ?> ;
           // var userid = <?php echo $_SESSION["userid"]?>;
           
           //alert(id );
           // alert(userid);
            });
            
    });
</script>
    <!--End jQuery-->
<!--New Edit-->

<!--End New Edit-->
<div class="container">
    <div class="row" style="width: 100%">
        <div class="forsale-title">
            <h4 style="padding-top:10px;">PROPERTY DETAIL</h4>
        </div>
    </div>
    <div class="row" style="width: 100%">
        <div class="row-property-detail"> 
        <?php
            echo '<img height="450" width="100%" src="data:image;base64,'.$result['propertyimage'].' ">';
        ?>
        </div>
    </div>
    <div class="row" style="width: 100%">
            <div class="property-desc">
                <div class="property-name">
                    <h3><?php echo $loc_rs['locationname'] ?></h3>
                </div>
                <div class="property-desc-detail" style="padding-left:20px;">
                    <h2><?php echo "$".number_format($result['price'],0); ?></h2>
                    <h4><?php echo "District : " .$district_rs['districtname'] ?></h4>
                    <h4><?php echo "Suburb : ".ucwords(strtolower($suburb_rs['suburbname'])) ?></h4>
                    <h4><?php echo "Address : " .$result['address'];?></h4>
                    <h4>Description</h4>
                    <p><?php echo $result['description']; ?></p>
                    <br>
                    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
                    <form method="post">
                        <input type="submit" value="Add to Wishlist" id="wishlist" name="btnaddwishlist" class="button"/>
                        
                    </form>
                    <?php
                    if(isset($_POST['btnaddwishlist']) && isset($_SESSION['userlogin'])){//btnaddwishlist
                        $con= mysqli_connect ("localhost","root","");
                        if(!$con){
                            echo "Not connected to server.";
                        }
                        if(!mysqli_select_db($con,'realestate')){
                            echo "Database not selected.";
                        }
                    
                        $userid = $_SESSION['user_id'];
                        $wishlist_sql = "INSERT INTO wishlist (userid,propertyid,locationid) VALUES('$userid','".$result['propertyid']."','".$result['locationid']."')";
                        if(!mysqli_query($con,$wishlist_sql)){
                            echo "Cannot insert into database.";
                        }else{
                            echo "Successfully inserted.";
                        }
                        // unset($_SESSION["userid"]);
                    }
                    if(isset($_POST['btnaddwishlist']) && !isset($_SESSION['userlogin'])){
                        //Redirect to login page.
                         header("Location:index.php?page=userlogin");
                    }
                    ?>
                </div>
            </div>
    </div>
    <div class="row" style="width: 100%">
        <div class="property-agent" style="margin-top: 5px">
            <div class="property-contact">
                <h2>CONTACT INFORMATION</h2>
            </div>
            <div class="property-contact-detail" style="padding-left: 20px;">
                <p><?php echo "Name : ".$agent_rs['name']; ?></p>
                <p> <?php echo "Phone : ".$agent_rs['phone']; ?></p>
                <p> <?php echo "Email : ".$agent_rs['email'];  ?></p>
            </div>
        </div>    
    </div>
</div>
    <?php
}
?>