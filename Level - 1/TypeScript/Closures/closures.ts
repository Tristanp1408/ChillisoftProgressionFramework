function setupCounter() {
  function createCounter() {
    let count = 0;

    return {
      increment: () => ++count,
      decrement: () => --count,
      reset: () => {
        count = 0;
        return count;
      },
    };
  }

  const counter = createCounter();

  const counterDisplay = document.getElementById("counter-value")!;
  const incrementBtn = document.getElementById("increment-btn")!;
  const decrementBtn = document.getElementById("decrement-btn")!;
  const resetBtn = document.getElementById("reset-btn")!;

  const updateCounter = () => {
    counterDisplay.textContent = counter.reset().toString();
  };

  incrementBtn.addEventListener("click", () => {
    counterDisplay.textContent = counter.increment().toString();
  });

  decrementBtn.addEventListener("click", () => {
    counterDisplay.textContent = counter.decrement().toString();
  });

  resetBtn.addEventListener("click", () => {
    counterDisplay.textContent = counter.reset().toString();
  });

  updateCounter();
}

document.addEventListener("DOMContentLoaded", () => {
  setupCounter();
});
