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
                            if (this.readyState == 4 ) { 
                                document.getElementById("slcSuburb").innerHTML = this.responseText; // This will add all Districts which match selected region into District dropdownlist.
                            }
                        };
                        xmlhttp.send(null);
                    }
                }