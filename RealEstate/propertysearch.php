
<div class="navbar navbar-inverse navbar-static-top no-border"><!--searchpanel-->
    <div class="control-search">
        <script type="text/javascript" src="js/jquery.js"></script>
        <script type="text/javascript" src="getregionalproperty.js"></script>
            <script>
                function showDistricts() {
                    //Disable Suburb selection
                    var y = document.getElementById("slcDistrict");
                        y.disable = true;
                    var x = document.getElementById("slcSuburb");
                    
                        x.disabled = true;
                         document.getElementById("slcSuburb").innerHTML = ""; //Reset Suburb selection to empty;  
                    var selected_index = document.getElementById('slcRegion').options.selectedIndex; //Get selected index from the dropdwonlist
                    var region_name =  document.getElementById('slcRegion').options[selected_index].text;//Get the text from dropdownlist
                    var selected_value = document.getElementById('slcRegion').options[selected_index].value; //Get the value from dropdownlist(it could be an ids from DB)
                    
                    var xmlhttp;
                    try {
                        xmlhttp = new XMLHttpRequest;
                    } catch(e) {
                        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
                    }
                    if (xmlhttp) {
                        xmlhttp.open("GET","http://localhost:1531/RealEstate/getdistricts.php?region="+region_name,true); 
                        xmlhttp.onreadystatechange = function(){
                            if (this.readyState == 4 && this.status ==200) { //get response back
                               
                                document.getElementById("slcDistrict").innerHTML = this.responseText; // This will add all Districts which match selected region into District dropdownlist.
                            }
                        };
                        xmlhttp.send(null);
                    }
                }
            </script>
            <script>
                function showSuburbs() {
                    //Enable Suburb selection
                    var x = document.getElementById("slcSuburb");
                        x.disabled = false;
                    var selected_index = document.getElementById('slcDistrict').options.selectedIndex; //Get selected index from the dropdwonlist
                    var district_name =  document.getElementById('slcDistrict').options[selected_index].text;//Get the text from dropdownlist
                    var selected_value = document.getElementById('slcDistrict').options[selected_index].value; //Get the value from dropdownlist(it could be an ids from DB)
                    
                    var xmlhttp;
                    try {
                        xmlhttp = new XMLHttpRequest;
                    } catch(e) {
                        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
                    }
                    if (xmlhttp) {
                        xmlhttp.open("GET","http://localhost:1531/RealEstate/getsuburbs.php?district="+district_name,true);
                        xmlhttp.onreadystatechange = function(){
                            if (this.readyState == 4  && this.status ==200 ) {
                                
                                document.getElementById("slcSuburb").innerHTML = this.responseText; // This will add all Districts which match selected region into District dropdownlist.
                            }
                        };
                        xmlhttp.send(null);
                    }
                }
            </script>
           
            <form action="" method="post" name="frmsearch">
                <!-----------------------------------------RegionName dropdown list------------------------------------------------------------------------->
                <div class="col-xs-12 col-sm-6 col-md-3"> 
                    <p style="margin-top:20px" >Regions</p>
                    <select id="slcRegion" class="form-control" name="slc_regionid" onclick="showDistricts();">
                        <option value="0">Regions</option> 
                        <?php
                        $locatlist_sql = "SELECT * FROM location"; 
                        $locatlist_qry = mysqli_query($dbconn,$locatlist_sql);
                        $locatlist_rs = mysqli_fetch_assoc($locatlist_qry);
                        /* To retain value from dropdown list after clicked on search button */
                        $array_data = array();
                        do{
                            $array_data[$locatlist_rs['locationid']]=$locatlist_rs['locationname']; //Add all locations into array with key and value.
                            //locationid is key, locationname is value
                        }while($locatlist_rs = mysqli_fetch_assoc($locatlist_qry));
                        foreach($array_data as $id=>$chosen){
                            if($id == $_POST['slc_regionid']){
                                $sel = 'selected="selected"';
                            }else{
                                $sel = '';
                            }
                            $chosen = ucwords(strtolower($chosen));
                            echo "<option $sel value='$id'>$chosen</option>";
                        }
                        
                        ?>
                    </select>
                    <p style="margin-top:10px">Search via keyword</p><input type="text" name="txtlocation" autocomplete="off" placeholder=" All locations..." style="height: 40px" id="txtsearch" onchange="getRegionalProperty(this.value);" />
                </div>
                <!-----------------------------------------------End RegionName dropdown list------------------------------------------------------------------------------------>
            <div class="col-xs-12 col-sm-6 col-md-3">
                <!-----------------------------------------------DistrictName dropdown list------------------------------------------------------------------->
                <p style="margin-top:20px">District</p>
                <select id="slcDistrict" class="form-control" name="slc_districtid" onchange="showSuburbs();">
                    <!--Retain selected district name after searching -->
                    <?php
                        if(isset($_POST['slc_districtid'])){
                            //$dist_sql = "SELECT * FROM district WHERE districtid = '".$_POST['slc_districtid']."' ";
                            $dist_sql = "SELECT * FROM district WHERE locationid='".$_POST['slc_regionid']."'";
                            $dist_qry = mysqli_query($dbconn,$dist_sql);
                            $dist_rs = mysqli_fetch_assoc($dist_qry);
                           // $id = $_POST['slc_districtid'];
                            
                            $array_data = array();
                            do{
                                $array_data[$dist_rs['districtid']]=$dist_rs['districtname']; //Add all locations into array with key and value.
                                //districtid is key, districtname is value
                            }while($dist_rs = mysqli_fetch_assoc($dist_qry));
                            foreach($array_data as $id=>$chosen){
                                if($id == $_POST['slc_districtid']){
                                    $sel = 'selected="selected"';
                                }else{
                                    $sel = '';
                                }
                                $chosen = ucwords(strtolower($chosen));
                                echo "<option $sel value='$id'>$chosen</option>";
                            }
                           
                        }
                        
                    ?>
                </select>
                <!-----------------------------------------------End DistrictName dropdown list--------------------------------------------------------------------->
                <p style="margin-top: 10px">Suburb</p>
                <!-----------------------------------------------SuburbName dropdown list------------------------------------------------------------------------>
                <select id="slcSuburb" class="form-control" name="slc_suburbid" >
                     <!--Retain selected suburb name after searching -->
                    <?php
                        if(isset($_POST['slc_suburbid'])){
                            //$sub_sql = "SELECT * FROM suburb WHERE suburbid = '".$_POST['slc_suburbid']."' ";
                            $sub_sql = "SELECT * FROM suburb WHERE districtid = '".$_POST['slc_districtid']."' ";
                            $sub_qry = mysqli_query($dbconn,$sub_sql);
                            $sub_rs = mysqli_fetch_assoc($sub_qry);
                            
                            $array_data = array();
                            do{
                                $array_data[$sub_rs['suburbid']]= $sub_rs['suburbname']; //Add all locations into array with key and value.
                                //suburbid is key, suburbname is value
                            }while($sub_rs = mysqli_fetch_assoc($sub_qry));
                            foreach($array_data as $id=>$chosen){
                                if($id == $_POST['slc_suburbid']){
                                    $sel = 'selected="selected"';
                                }else{
                                    $sel = '';
                                }
                                $chosen = ucwords(strtolower($chosen));
                                echo "<option $sel value='$id'>$chosen</option>";
                            }
                        }
                    ?>
                </select>
            </div>
            <!--------------------------------------------------------End SuburbName dropdown list----------------------------------------------------------------->
               <?php
                    $val_froms = array('0'=>'0','100000'=>'$100k','150000'=>'$150k','200000'=>'$200k','250000'=>'$250k','300000'=>'$300k','350000'=>'$350k','400000'=>'$400k','500000'=>'$500k');
                    $val_tos = array('600000'=>'$600k','650000'=>'$650k','700000'=>'$700k','750000'=>'$750k','800000'=>'$800k','850000'=>'$850k','900000'=>'$900k','950000'=>'$950k','1000000'=>'$1M','1100000'=>'$1.1M','1200000'=>'$1.2M','1300000'=>'$1.3M','1400000'=>'$1.4M','1500000'=>'$1.5M+');
               ?>
               <div class="col-xs-12 col-sm-6 col-md-3">
                    <p style="margin-top:20px">From</p>
                    <select id="valfrom" class="form-control" name="valfrom">
                        <?php
                            foreach($val_froms as $id=>$chosen){
                                if($id == $_POST['valfrom']){
                                    $sel = 'selected="selected"' ;
                                }else{
                                    $sel = '';
                                }
                                echo "<option $sel value='$id'>$chosen</option>";
                            }
                        ?>
                    </select>
                    <p style="margin-top: 10px">To</p>
                    <select id="valto" class="form-control" name="valto">
                        <?php
                            foreach($val_tos as $id=>$chosen){
                                if($id == $_POST['valto']){  
                                    $sel = 'selected="selected"';
                                }else{  
                                    $sel = '';
                                }
                                echo "<option $sel value='$id'>$chosen</option>";
                            }
                        ?>
                    </select>
                    
               </div>
               <div class="col-search-bu col-xs-6 col-sm-6 col-md-2"> <!--col-search-bu-->
                    <input  class="button-search"type="submit" value="SEARCH" name="btnsearch" id="busearch"/>
               </div> 
            </form>
    </div>
</div>

<!-- JQuery for textbox and button search -->
<script type="text/javascript" src="js/jquery.js"></script>
<script>
   $(document).ready(function(){
        $("#busearch").mouseover(function(){
            $("#busearch").css("background-color","orange");
            $("#busearch").css("color","white");
            $("#busearch").attr('value','SEARCH');
            });
        $("#busearch").mouseout(function(){
            $("#busearch").css("background-color","#fa086f");
            $("#busearch").css("color","white");
            $("#busearch").attr('value','SEARCH');
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

<div class="row" id="result_via_textbox">
    
</div>
<div class="container">
<div class="row" style="width: 100%">
<?php
    $con = mysql_connect("localhost","root","");
    mysql_select_db("realestate",$con);
    
    if(isset($_POST['btnsearch'])){ //Check if button search was clicked
        
        if(!empty($_POST['slc_regionid']) and !empty($_POST['slc_districtid'])){ //Region was selected, but district was not chosen.
            
            $region_id = $_POST['slc_regionid'];
            $district_id = $_POST['slc_districtid'];
            // Check to see if user select All Districts, so that search is not allowed.
            $sql_dist = "SELECT * FROM district WHERE districtid = '".$district_id."' ";
            $qry_dist = mysqli_query($dbconn,$sql_dist);
            $dist_rs = mysqli_fetch_assoc($qry_dist);
            if($dist_rs['districtname']=='All Districts'){
                 ?>
                <div class="notfound" style="padding-top:50px">
                    <?php die ("Please choose district and suburb to search.") ;?>
                </div>
            <?php
            }
          
        }
        if(empty($_POST['slc_regionid']) and empty($_POST['slc_districtid']) and empty($_POST['slc_suburbid'])){ //Region,District and Suburb are not selected.
            ?>
                <div class="notfound" style="padding-top:50px">
                    <?php die ("Please choose region and district to search.") ;?>
                </div>
            <?php
        }
        if(!empty($_POST['slc_regionid']) and !empty($_POST['slc_districtid']) and empty($_POST['slc_suburbid'])){ //Region and District were selected but no suburb
            ?>
                <div class="notfound" style="padding-top:50px">
                    <?php die ("No results found.") ;?>
                </div>
            <?php
        }
        
        if(!empty($_POST['slc_regionid']) and empty($_POST['slc_districtid']) and empty($_POST['slc_suburbid'])){
            ?>
                <div class="notfound" style="padding-top:50px">
                    <?php die( "No results found!") ;?>
                </div>
            <?php
        }
        if(!empty($_POST['slc_regionid']) and !empty($_POST['slc_districtid']) and !empty($_POST['slc_suburbid'])){
            $found_sql="";
            $found_qry="";
            $found_rs="";
            
            $region_id = $_POST['slc_regionid'];
            $district_id = $_POST['slc_districtid'];
            $suburb_id = $_POST['slc_suburbid'];
           
            // Check if user select All Suburbs
            $sql_sub = "SELECT * FROM suburb WHERE suburbid = '".$suburb_id."' AND districtid='".$district_id."' ";
            $qry_sub = mysqli_query($dbconn,$sql_sub);
            $sub_rs = mysqli_fetch_assoc($qry_sub);
            if($sub_rs['suburbname']=='all suburbs'){ // The select all property from all suburbs with chosen district
                
                $found_sql = "SELECT * FROM property WHERE districtid='".$district_id."' AND locationid='".$region_id."' AND price >='".$_POST['valfrom']."' AND price <= '".$_POST['valto']."'";
                $found_qry = mysql_query($found_sql,$con);
                $found_rs = mysql_fetch_assoc($found_qry);
                
            }
            else{ //Only select property base on suburb name
                //echo "Region id is ".$region_id." and district id is ".$district_id." and suburb id is ".$suburb_id;
                $found_sql = "SELECT * FROM property WHERE districtid='".$district_id."' AND locationid='".$region_id."' AND suburbid='".$suburb_id."' AND price >='".$_POST['valfrom']."' AND price <= '".$_POST['valto']."' ";
                $found_qry = mysqli_query($dbconn,$found_sql);
                $found_rs = mysqli_fetch_assoc($found_qry);
            }  
           
            if(!$found_rs){//When No Property to display
                ?>
                <div class="notfound" style="padding-top:50px">
                    <?php echo "No results found!" ;?>
                </div>
                <?php
            }
            else{
                $found_qry = mysqli_query($dbconn,$found_sql);
            } 
            
        }
    }else{ //When load the page.
         $found_sql = "SELECT * FROM property";
    }
        //$found_sql = "SELECT * FROM property";
        $result = mysqli_query($dbconn,$found_sql);
        $row = mysqli_fetch_assoc($result);

    if($row){ //Only excute when it has property to show
        do{
            //echo "When load page";
        ?>
        <div class="row-property-sale" style="float: left"><!--row-property-sale-->
            <div class="col-xs-12 col-sm-12 col-md-6"><!--col-md-2-left>-->
                <a href="index.php?page=detail&property_ID=<?php echo $row['propertyid'] ; ?>"><?php echo '<img height="300px" width="95%" src="data:image;base64,'.$row['propertyimage'].' ">';?></a>
            </div>
            <div class="col-xs-12 col-sm-12 col-md-6"><!--col-md-2-right-->
                <?php
                $sql2 = "SELECT * FROM location WHERE locationid ='".$row['locationid']."'";
                $qry2 = mysql_query($sql2,$con);
                $row2 = mysql_fetch_assoc($qry2);
                //$location = strtoupper($row2['locationname']);
                $location = strtoupper($row2['locationname']);
                $sql3 = "SELECT * FROM suburb WHERE suburbid='".$row['suburbid']."'";
                $qry3 = mysql_query($sql3,$con);
                $row3 = mysql_fetch_assoc($qry3);
                ?>
                <h2><?php echo ucwords(strtolower( $location));?></h2>
                <h2><?php echo "( ".ucwords(strtolower($row3['suburbname']))." )" ?></h2>
                
                <p><?php echo substr($row['description'],0,100)." ...";?></p><!--Get first 100 characters-->
                
                <p style="font-weight:bold"><?php echo $row['address']; ?></p>
                <h1><?php echo "$".number_format($row['price'],0); ?></h1>
                <div class="house-detail">
                    <div class="col-left">
                        <div class="house-detail">
                            <div class="col-left-bed-pic"><img src="images/bed.png" height="100%" width= "90%" "> </div>
                            <div class="col-left-bed-num"><h2>3</h2></div>
                        </div> 
                    </div>
                    <div class="col-right">
                        <div class="house-detail">
                            <div class="col-right-shower-pic"><img src="images/shower.png" height="100%" width= "90%" "> </div>
                            <div class="col-right-shower-num"><h2>3</h2></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <?php
        }while($row= mysqli_fetch_assoc($result));
    }
    
?>
</div>
</div>
