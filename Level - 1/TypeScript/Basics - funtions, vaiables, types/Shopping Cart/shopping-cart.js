var cart = [];
var productNameInput = document.getElementById("productName");
var productPriceInput = document.getElementById("productPrice");
var cartList = document.getElementById("cartList");
var totalPrice = document.getElementById("totalPrice");
var addProductBtn = document.getElementById("addProductBtn");
var clearCartBtn = document.getElementById("clearCartBtn");
function addProduct() {
    var name = productNameInput.value.trim();
    var price = parseFloat(productPriceInput.value);
    if (name && !isNaN(price)) {
        var product = { id: Date.now(), name: name, price: price };
        cart.push(product);
        updateCartUI();
    }
}
function removeProduct(id) {
    cart = cart.filter(function (product) { return product.id !== id; });
    updateCartUI();
}
function calculateTotal() {
    return cart.reduce(function (total, product) { return total + product.price; }, 0);
}
function updateCartUI() {
    cartList.innerHTML = "";
    cart.forEach(function (product) {
        var li = document.createElement("li");
        li.innerHTML = "".concat(product.name, " - $").concat(product.price, " \n        <button onclick=\"removeProduct(").concat(product.id, ")\">Remove</button>");
        cartList.appendChild(li);
    });
    totalPrice.innerText = calculateTotal().toFixed(2);
}
addProductBtn.addEventListener("click", addProduct);
clearCartBtn.addEventListener("click", function () {
    cart = [];
    updateCartUI();
});
