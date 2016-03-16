// This Function is not being used yet .
function getRegionalProperty(val) {
    if (val == "") {
        document.getElementById("result_via_textbox").innerHTML="";
        return;
    }
    if (window.XMLHttpRequest) {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange= function(){
        if (xmlhttp.readyState== 4 && xmlhttp.status==200) {
            document.getElementById("result_via_textbox").innerHTML = xmlhttp.responseText;
        }
    }
    xmlhttp.open("GET","http://localhost:1531/RealEstate/propertyfromtextsearch.php?region="+val,true);
    xmlhttp.send();
}