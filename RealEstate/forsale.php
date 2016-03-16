
<div class="row">
    <div class="forsale-search">
       <form action="" method="post">
        <input type="text" name="txtlocation" autocomplete="off" placeholder=" All locations..." style="height: 25px" id="txtsearch"/>
        <input  class="button"type="submit" value="Search" name="btnsearch" id="busearch"/>
    </form> 
    </div>
    <br>
</div>
<!-- JQuery for textbox and button search -->
<script type="text/javascript" src="js/jquery.js"></script>
<script>
   $(document).ready(function(){
        $("#busearch").mouseover(function(){
            $("#busearch").css("background-color","green");
            $("#busearch").css("color","black");
            $("#busearch").attr('value','Search>>>');
            });
        $("#busearch").mouseout(function(){
            $("#busearch").css("background-color","orange");
            $("#busearch").css("color","white");
            $("#busearch").attr('value','Search');
            });
        $("#txtsearch").mouseover(function(){
            $("#txtsearch").attr('placeholder','Enter location');
            });
        $("#txtsearch").mouseout(function(){
            $("#txtsearch").attr('placeholder','All locations...');
            });
        $("#txtsearch").click(function(){
            $("#txtsearch").css("font-size","14px");
            });
    });
</script>
<!--End jQuery-->

<div class="row">
    <div class="forsale-title">
        <h1>PROPERTY FOR SALE</h1>
    </div>
    
</div>
<div class="row">
<?php
    $con = mysql_connect("localhost","root","");
    mysql_select_db("realestate",$con);
   
    if(isset($_POST['btnsearch'])){ //Check if button search was clicked
        $txtLocation = $_POST['txtlocation'];
         //echo "<script type 'text/javascript'> alert(' $txtLocation')</script>";
        if($txtLocation == '' || strtolower($txtLocation)=='all'){
            $qry = "SELECT * FROM property";
        }else{
            $locname = strtoupper($txtLocation);
            //Get locationId base on entered location
            $sql3 = "SELECT * FROM location WHERE locationname ='".$locname."'";
            $qry3 = mysql_query($sql3,$con);
            $row3 = mysql_fetch_assoc($qry3);
            if (!$row3){
                ?>
                <div class="notfound" style="padding-top:50px">
                    <?php echo "No results found!" ;?>
                </div>
                <?php
                
            }
            $qry = "SELECT * FROM property WHERE locationid = '".$row3['locationid']."' ";
        }
    }else{
         $qry = "SELECT * FROM property";
    }
    //$qry = "SELECT * FROM property";
    $result = mysql_query($qry,$con);
    echo "<table border = '0' width = '100%'> ";
    
    while($row = mysql_fetch_array($result)){
        ?>
        <a href="index.php?page=forsale&property_ID=<?php echo $row['propertyid'] ; ?>">
        <?php
        echo '<tr style="background-color:whitesmoke">'; //set row background color;
        echo "<td>";
        ?>
        <a href="index.php?page=detail&property_ID=<?php echo $row['propertyid'] ; ?>"><?php echo '<img height="180" width="300" src="data:image;base64,'.$row['propertyimage'].' ">';?></a>
        <?php
        // Select Location base on property ID
        $sql2 = "SELECT * FROM location WHERE locationid ='".$row['locationid']."'";
        $qry2 = mysql_query($sql2,$con);
        $row2 = mysql_fetch_assoc($qry2);
        $location = strtoupper($row2['locationname']);
        echo "</td>";
        echo "<td>".$location."<br><br>"."Price:"."$".$row['price']."<br>"."Address: ".$row['address']."<br>"."<br>".$row['description']."</td>";
        echo "</tr>";
        ?>
        </a>
         
        <?php
       
    }
    mysql_close($con);
    echo "</table>";
?> 
</div>