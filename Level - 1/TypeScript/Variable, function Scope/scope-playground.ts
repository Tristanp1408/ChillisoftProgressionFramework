let globalVar = "I am a global variable";

function functionScopeExample() {
  var functionVar = "I exist only inside this function";
  let functionLet = "I am also function-scoped";
  const functionConst = "I am a constant function variable";

  console.log(globalVar);
  console.log(functionVar);
  console.log(functionLet);
  console.log(functionConst);
}

function blockScopeExample() {
  if (true) {
    var blockVar = "I am declared with var (function-scoped)";
    let blockLet = "I am block-scoped";
    const blockConst = "I am a constant block-scoped variable";

    console.log(blockVar);
    console.log(blockLet);
    console.log(blockConst);
  }

  console.log(blockVar);
  // console.log(blockLet);
  // console.log(blockConst);
}

functionScopeExample();
blockScopeExample();

document.addEventListener("DOMContentLoaded", () => {
  const outputDiv = document.getElementById("output");

  if (outputDiv) {
    outputDiv.innerHTML = `
            <p><strong>Global Variable:</strong> ${globalVar}</p>
            <p><strong>Function Scope:</strong> Open console to see function-scoped variables.</p>
            <p><strong>Block Scope:</strong> Open console to see block-scoped variables.</p>
            <p><strong>Var:</strong> is function-scoped, meaning it is accessible throughout the function. Can be reassigned in the same scope.</p>
            <p><strong>Let:</strong> let is block-scoped (inside {}). Cannot be reassigned in the same scope.</p>
            <p><strong>Const:</strong> is block-scoped (like let). Cannot be reassigned.</p>
        `;
  }
});
