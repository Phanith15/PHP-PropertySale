// Javascript
var myImg = document.getElementById("myPhoto");
var imageArray=["1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg"];
var imageIndex = 0;
function changeImage() {
    myPhoto.setAttribut("src",imageArray[imageIndex]);
    imageArray++;
    if (imageIndex>= imageArray.length) {
        imageIndex = 0;
    }
}
var intervalHandle = setInterval(changeImage(),2000);
myPhoto.onclick = function(){
    clearInterval(intervalHandle);
}