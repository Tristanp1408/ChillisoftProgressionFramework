var Counter = /** @class */ (function () {
    function Counter(id) {
        this.count = 0;
        this.id = id;
    }
    Counter.prototype.increment = function () { };
    Counter.prototype.decrement = function () { };
    Counter.prototype.reset = function () { };
    Counter.prototype.updateUI = function () { };
    return Counter;
}());
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
    var counterDisplay = document.getElementById("counter-value-".concat(this.id));
    if (counterDisplay) {
        counterDisplay.textContent = this.count.toString();
    }
};
var counters = [];
var container = document.getElementById("counter-container");
function addCounter() {
    var counterId = counters.length;
    var newCounter = new Counter(counterId);
    counters.push(newCounter);
    var counterElement = document.createElement("div");
    counterElement.classList.add("counter-box");
    var counterDisplay = document.createElement("p");
    counterDisplay.id = "counter-value-".concat(counterId);
    counterDisplay.classList.add("counter-display");
    counterDisplay.textContent = "0";
    var buttonContainer = document.createElement("div");
    buttonContainer.classList.add("buttons");
    var incrementBtn = document.createElement("button");
    incrementBtn.textContent = "Increment";
    incrementBtn.addEventListener("click", function () { return newCounter.increment(); });
    var decrementBtn = document.createElement("button");
    decrementBtn.textContent = "Decrement";
    decrementBtn.addEventListener("click", function () { return newCounter.decrement(); });
    var resetBtn = document.createElement("button");
    resetBtn.textContent = "Reset";
    resetBtn.addEventListener("click", function () { return newCounter.reset(); });
    buttonContainer.appendChild(incrementBtn);
    buttonContainer.appendChild(decrementBtn);
    buttonContainer.appendChild(resetBtn);
    counterElement.appendChild(counterDisplay);
    counterElement.appendChild(buttonContainer);
    container.appendChild(counterElement);
}
document
    .getElementById("add-counter-btn")
    .addEventListener("click", addCounter);
