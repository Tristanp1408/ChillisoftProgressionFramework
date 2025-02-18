class Counter {
  private count: number;
  public id: number;

  constructor(id: number) {
    this.count = 0;
    this.id = id;
  }

  increment(): void {}
  decrement(): void {}
  reset(): void {}
  updateUI(): void {}
}

Counter.prototype.increment = function () {
  this.count++;
  this.updateUI();
};

Counter.prototype.decrement = function () {
  this.count--;
  this.updateUI();
};

Counter.prototype.reset = function () {
  this.count = 0;
  this.updateUI();
};

Counter.prototype.updateUI = function () {
  const counterDisplay = document.getElementById(`counter-value-${this.id}`);
  if (counterDisplay) {
    counterDisplay.textContent = this.count.toString();
  }
};

const counters: Counter[] = [];
const container = document.getElementById("counter-container")!;

function addCounter() {
  const counterId = counters.length;
  const newCounter = new Counter(counterId);
  counters.push(newCounter);

  const counterElement = document.createElement("div");
  counterElement.classList.add("counter-box");

  const counterDisplay = document.createElement("p");
  counterDisplay.id = `counter-value-${counterId}`;
  counterDisplay.classList.add("counter-display");
  counterDisplay.textContent = "0";

  const buttonContainer = document.createElement("div");
  buttonContainer.classList.add("buttons");

  const incrementBtn = document.createElement("button");
  incrementBtn.textContent = "Increment";
  incrementBtn.addEventListener("click", () => newCounter.increment());

  const decrementBtn = document.createElement("button");
  decrementBtn.textContent = "Decrement";
  decrementBtn.addEventListener("click", () => newCounter.decrement());

  const resetBtn = document.createElement("button");
  resetBtn.textContent = "Reset";
  resetBtn.addEventListener("click", () => newCounter.reset());

  buttonContainer.appendChild(incrementBtn);
  buttonContainer.appendChild(decrementBtn);
  buttonContainer.appendChild(resetBtn);

  counterElement.appendChild(counterDisplay);
  counterElement.appendChild(buttonContainer);

  container.appendChild(counterElement);
}

document
  .getElementById("add-counter-btn")!
  .addEventListener("click", addCounter);
