<div class="container">
    
<div class="row">
    <?php
    $userid = $_SESSION['user_id'];
    $wish_sql = "SELECT * FROM wishlist WHERE userid=".$userid ;
    $wish_qry = mysqli_query($dbconn,$wish_sql);
    $rs_row = mysqli_fetch_assoc($wish_qry);
    if($rs_row){
        do{
        $property_id = $rs_row['propertyid'];
    
        $wish_sql2 = "SELECT * FROM property WHERE propertyid=".$property_id;
        $wish_qry2 = mysqli_query($dbconn,$wish_sql2);
        $rs_row2 = mysqli_fetch_assoc($wish_qry2);
        ?>
        <div class="row-property-detail">
            <?php echo '<img height = "200" width = "50%" src="data:image;base64,'.$rs_row2['propertyimage'].'">'; ?>
        </div><br>
        <?php
        
        }while($rs_row = mysqli_fetch_assoc($wish_qry)); 
    }
    else{
        ?>
            <div class="notfound" style="padding-top:50px">
                <?php echo "No property in wishlist." ;?>
            </div>
        <?php
    }
    ?>
    
        <!--include("getwishlist.php"); //Display in table style -->
</div>
</div>