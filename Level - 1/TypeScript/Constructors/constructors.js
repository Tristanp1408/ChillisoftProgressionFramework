var Car = /** @class */ (function () {
    function Car(brand, model, year) {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }
    Car.prototype.getDetails = function () {
        return "\uD83D\uDE97 ".concat(this.brand, " ").concat(this.model, " (").concat(this.year, ")");
    };
    return Car;
}());
var cars = [];
var carForm = document.getElementById("carForm");
var carBrandInput = document.getElementById("carBrand");
var carModelInput = document.getElementById("carModel");
var carYearInput = document.getElementById("carYear");
var carList = document.getElementById("carList");
function addCar(event) {
    event.preventDefault();
    var brand = carBrandInput.value.trim();
    var model = carModelInput.value.trim();
    var year = parseInt(carYearInput.value);
    if (!brand || !model || isNaN(year) || year <= 0) {
        alert("❌ Please enter valid car details.");
        return;
    }
    var newCar = new Car(brand, model, year);
    cars.push(newCar);
    console.log("✅ Car added:", newCar);
    updateCarList();
    carBrandInput.value = "";
    carModelInput.value = "";
    carYearInput.value = "";
}
function updateCarList() {
    carList.innerHTML = "";
    cars.forEach(function (car) {
        var li = document.createElement("li");
        li.textContent = car.getDetails();
        carList.appendChild(li);
    });
}
carForm.addEventListener("submit", addCar);
