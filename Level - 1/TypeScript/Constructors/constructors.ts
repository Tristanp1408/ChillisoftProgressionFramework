class Car {
  constructor(
    public brand: string,
    public model: string,
    public year: number
  ) {}

  getDetails(): string {
    return `🚗 ${this.brand} ${this.model} (${this.year})`;
  }
}

const cars: Car[] = [];

const carForm = document.getElementById("carForm") as HTMLFormElement;
const carBrandInput = document.getElementById("carBrand") as HTMLInputElement;
const carModelInput = document.getElementById("carModel") as HTMLInputElement;
const carYearInput = document.getElementById("carYear") as HTMLInputElement;
const carList = document.getElementById("carList") as HTMLUListElement;

function addCar(event: Event): void {
  event.preventDefault();

  const brand = carBrandInput.value.trim();
  const model = carModelInput.value.trim();
  const year = parseInt(carYearInput.value);

  if (!brand || !model || isNaN(year) || year <= 0) {
    alert("❌ Please enter valid car details.");
    return;
  }

  const newCar = new Car(brand, model, year);
  cars.push(newCar);

  console.log("✅ Car added:", newCar);
  updateCarList();

  carBrandInput.value = "";
  carModelInput.value = "";
  carYearInput.value = "";
}

function updateCarList(): void {
  carList.innerHTML = "";

  cars.forEach((car) => {
    const li = document.createElement("li");
    li.textContent = car.getDetails();
    carList.appendChild(li);
  });
}

carForm.addEventListener("submit", addCar);
