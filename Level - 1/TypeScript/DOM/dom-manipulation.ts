const form = document.getElementById("nameForm") as HTMLFormElement;
const nameInput = document.getElementById("nameInput") as HTMLInputElement;
const greetingDiv = document.getElementById("greeting") as HTMLDivElement;
const imageSelect = document.getElementById("imageSelect") as HTMLSelectElement;
const displayedImage = document.getElementById(
  "displayedImage"
) as HTMLImageElement;
const sizeSlider = document.getElementById("sizeSlider") as HTMLInputElement;
const resetButton = document.getElementById("resetBtn") as HTMLButtonElement;

const images: Record<string, string> = {
  nature: "./assets/images/nature.jpg",
  city: "./assets/images/city.jpg",
  desert: "./assets/images/desert.jpg",
};

form.addEventListener("submit", (event) => {
  event.preventDefault();
  const name = nameInput.value.trim();
  const selectedImageKey = imageSelect.value;
  const selectedImage = images[selectedImageKey];

  if (name) {
    greetingDiv.innerText = `Hello, ${name}! Welcome to DOM Manipulation.`;
    greetingDiv.style.color = "green";

    if (selectedImage) {
      displayedImage.src = selectedImage;
      displayedImage.style.display = "block";
      sizeSlider.style.display = "block";
      resetButton.style.display = "block";

      if (selectedImageKey === "nature") {
        document.body.style.backgroundColor = "#c3e6cb";
      } else if (selectedImageKey === "city") {
        document.body.style.backgroundColor = "#cce5ff";
      } else if (selectedImageKey === "desert") {
        document.body.style.backgroundColor = "#ffe5b4";
      }
    } else {
      greetingDiv.innerText = "Please select an image before submitting.";
      greetingDiv.style.color = "red";
    }
  } else {
    greetingDiv.innerText = "Please enter your name.";
    greetingDiv.style.color = "red";
  }

  nameInput.value = "";
});

sizeSlider.addEventListener("input", () => {
  displayedImage.style.width = `${sizeSlider.value}px`;
  displayedImage.style.height = "auto";
});

resetButton.addEventListener("click", () => {
  displayedImage.style.display = "none";
  sizeSlider.style.display = "none";
  resetButton.style.display = "none";
  document.body.style.backgroundColor = "#f4f4f4";

  greetingDiv.innerText = "";
  greetingDiv.style.color = "";
});
