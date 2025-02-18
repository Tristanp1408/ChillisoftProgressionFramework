function setupCounter() {
    function createCounter() {
        var count = 0;
        return {
            increment: function () { return ++count; },
            decrement: function () { return --count; },
            reset: function () {
                count = 0;
                return count;
            },
        };
    }
    var counter = createCounter();
    var counterDisplay = document.getElementById("counter-value");
    var incrementBtn = document.getElementById("increment-btn");
    var decrementBtn = document.getElementById("decrement-btn");
    var resetBtn = document.getElementById("reset-btn");
    var updateCounter = function () {
        counterDisplay.textContent = counter.reset().toString();
    };
    incrementBtn.addEventListener("click", function () {
        counterDisplay.textContent = counter.increment().toString();
    });
    decrementBtn.addEventListener("click", function () {
        counterDisplay.textContent = counter.decrement().toString();
    });
    resetBtn.addEventListener("click", function () {
        counterDisplay.textContent = counter.reset().toString();
    });
    updateCounter();
}
document.addEventListener("DOMContentLoaded", function () {
    setupCounter();
});
