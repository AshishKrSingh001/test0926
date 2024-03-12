// Initialize images in an array
var picPaths = ['image/ad_image01.jpg','image/ad_image02.jpg','image/ad_image03.jpg','image/ad_image04.jpg','image/ad_image05.jpg'];
// An index to track the contender image 
var imageIndex = 0;
var bannerImage; 

// An event callback for starting the interval
function startInterval() {
setInterval(displayNextImage, 3000);
}

function displayNextImage() {
bannerImage.src = picPaths[imageIndex];
if(imageIndex === (picPaths.length-1)) {
    imageIndex = 0;
}
else {
    imageIndex = imageIndex + 1; // It can be replaced with imageIndex ++  
}
}

window.onload=function() {
bannerImage = document.getElementById('imgBanner');
startInterval();
}