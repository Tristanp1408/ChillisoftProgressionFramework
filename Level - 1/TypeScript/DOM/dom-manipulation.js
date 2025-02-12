var form = document.getElementById("nameForm");
var nameInput = document.getElementById("nameInput");
var greetingDiv = document.getElementById("greeting");
var imageSelect = document.getElementById("imageSelect");
var displayedImage = document.getElementById("displayedImage");
var sizeSlider = document.getElementById("sizeSlider");
var resetButton = document.getElementById("resetBtn");
var images = {
    nature: "./assets/images/nature.jpg",
    city: "./assets/images/city.jpg",
    desert: "./assets/images/desert.jpg",
};
form.addEventListener("submit", function (event) {
    event.preventDefault();
    var name = nameInput.value.trim();
    var selectedImageKey = imageSelect.value;
    var selectedImage = images[selectedImageKey];
    if (name) {
        greetingDiv.innerText = "Hello, ".concat(name, "! Welcome to DOM Manipulation.");
        greetingDiv.style.color = "green";
        if (selectedImage) {
            displayedImage.src = selectedImage;
            displayedImage.style.display = "block";
            sizeSlider.style.display = "block";
            resetButton.style.display = "block";
            if (selectedImageKey === "nature") {
                document.body.style.backgroundColor = "#c3e6cb";
            }
            else if (selectedImageKey === "city") {
                document.body.style.backgroundColor = "#cce5ff";
            }
            else if (selectedImageKey === "desert") {
                document.body.style.backgroundColor = "#ffe5b4";
            }
        }
        else {
            greetingDiv.innerText = "Please select an image before submitting.";
            greetingDiv.style.color = "red";
        }
    }
    else {
        greetingDiv.innerText = "Please enter your name.";
        greetingDiv.style.color = "red";
    }
    nameInput.value = "";
});
sizeSlider.addEventListener("input", function () {
    displayedImage.style.width = "".concat(sizeSlider.value, "px");
    displayedImage.style.height = "auto";
});
resetButton.addEventListener("click", function () {
    displayedImage.style.display = "none";
    sizeSlider.style.display = "none";
    resetButton.style.display = "none";
    document.body.style.backgroundColor = "#f4f4f4";
    greetingDiv.innerText = "";
    greetingDiv.style.color = "";
});
