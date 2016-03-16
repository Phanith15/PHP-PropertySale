
<?php
     include("dbconnect.php");
       $locatlist_sql = "SELECT * FROM location";
       $data = mysqli_query($dbconn,$locatlist_sql);
       
       $regions = array();
       
       while($row = mysqli_fetch_array($data)){
              array_push($regions,$row["locationname"]);
       }
       echo json_encode($regions);
?>

