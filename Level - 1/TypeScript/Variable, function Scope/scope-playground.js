var globalVar = "I am a global variable";
function functionScopeExample() {
    var functionVar = "I exist only inside this function";
    var functionLet = "I am also function-scoped";
    var functionConst = "I am a constant function variable";
    console.log(globalVar);
    console.log(functionVar);
    console.log(functionLet);
    console.log(functionConst);
}
function blockScopeExample() {
    if (true) {
        var blockVar = "I am declared with var (function-scoped)";
        var blockLet = "I am block-scoped";
        var blockConst = "I am a constant block-scoped variable";
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
document.addEventListener("DOMContentLoaded", function () {
    var outputDiv = document.getElementById("output");
    if (outputDiv) {
        outputDiv.innerHTML = "\n            <p><strong>Global Variable:</strong> ".concat(globalVar, "</p>\n            <p><strong>Function Scope:</strong> Open console to see function-scoped variables.</p>\n            <p><strong>Block Scope:</strong> Open console to see block-scoped variables.</p>\n            <p><strong>Var:</strong> is function-scoped, meaning it is accessible throughout the function. Can be reassigned in the same scope.</p>\n            <p><strong>Let:</strong> let is block-scoped (inside {}). Cannot be reassigned in the same scope.</p>\n            <p><strong>Const:</strong> is block-scoped (like let). Cannot be reassigned.</p>\n        ");
    }
});
