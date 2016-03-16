function showDistricts() {
    //Disable Suburb selection
                    
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
            if (this.readyState == 4 ) { //get response back
                document.getElementById("slcDistrict").innerHTML = this.responseText; // This will add all Districts which match selected region into District dropdownlist.
            }
        };
        xmlhttp.send(null);
    }
}
                
                
            