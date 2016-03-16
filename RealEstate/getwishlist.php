<?php
    $userid = $_SESSION['user_id'];
    $wish_sql = "SELECT * FROM wishlist WHERE userid=".$userid ;
    $wish_qry = mysqli_query($dbconn,$wish_sql);
    $rs_row = mysqli_fetch_assoc($wish_qry);
    echo "<table border = '1' width= '100%'>";
    do{
        $property_id = $rs_row['propertyid'];
    
        $wish_sql2 = "SELECT * FROM property WHERE propertyid=".$property_id;
        $wish_qry2 = mysqli_query($dbconn,$wish_sql2);
        $rs_row2 = mysqli_fetch_assoc($wish_qry2);
        echo "<tr>";
        echo "<td>";
        echo '<img height = "200" width = "400" src="data:image;base64,'.$rs_row2['propertyimage'].'">';
        echo "</td>";
        echo "</tr>" ;
    }while($rs_row = mysqli_fetch_assoc($wish_qry));
    //mysql_close($dbconn);
    echo "</table>";
?>