

<?php
    session_start();
    if(!isset($_SESSION['search'])){
        $_SESSION['search']['districtid']="";
    }
    include("dbconnect.php");
    if(isset($_GET['region'])){
        $regionname = $_GET['region'];
        $dist_sql = "SELECT district.districtname ,district.districtid FROM district INNER JOIN location ON district.locationid = location.locationid WHERE location.locationname LIKE '{$regionname}'";
        $dist_qry = mysqli_query($dbconn,$dist_sql);
        $dist_rs = mysqli_fetch_assoc($dist_qry);
        
        
        do{
            ?>
            <option value="<?php echo $dist_rs['districtid']?>"<?php ?> ><?php echo ucwords(strtolower($dist_rs['districtname'])) ; ?> </option>
            <?php
        }while($dist_rs = mysqli_fetch_assoc($dist_qry));
        
    }
    include("dbcloseconnection.php");
?>

