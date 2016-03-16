<?php
    if(isset($_GET['district'])){
        include("dbconnect.php");
        $district = $_GET['district'];
        $sub_sql = "SELECT suburb.suburbid,suburb.suburbname FROM suburb INNER JOIN district ON suburb.districtid = district.districtid WHERE district.districtname LIKE '{$district}'";
       
        $sub_qry = mysqli_query($dbconn,$sub_sql);
        $sub_rs = mysqli_fetch_assoc($sub_qry);
        do{
            ?>
            <option value="<?php echo $sub_rs['suburbid'] ?>" ><?php echo ucwords(strtolower($sub_rs['suburbname'])) ; ?> </option>
            <?php
        }while($sub_rs = mysqli_fetch_assoc($sub_qry));
        include("dbcloseconnection.php");
    }
?>