interface Product {
  id: number;
  name: string;
  price: number;
}

let cart: Product[] = [];

const productNameInput = document.getElementById(
  "productName"
) as HTMLInputElement;

const productPriceInput = document.getElementById(
  "productPrice"
) as HTMLInputElement;

const cartList = document.getElementById("cartList") as HTMLUListElement;
const totalPrice = document.getElementById("totalPrice") as HTMLSpanElement;
const addProductBtn = document.getElementById(
  "addProductBtn"
) as HTMLButtonElement;

const clearCartBtn = document.getElementById(
  "clearCartBtn"
) as HTMLButtonElement;

function addProduct(): void {
  const name = productNameInput.value.trim();
  const price = parseFloat(productPriceInput.value);

  if (name && !isNaN(price)) {
    const product: Product = { id: Date.now(), name, price };
    cart.push(product);
    updateCartUI();
  }
}

function removeProduct(id: number): void {
  cart = cart.filter((product) => product.id !== id);
  updateCartUI();
}

function calculateTotal(): number {
  return cart.reduce((total, product) => total + product.price, 0);
}

function updateCartUI(): void {
  cartList.innerHTML = "";
  cart.forEach((product) => {
    const li = document.createElement("li");
    li.innerHTML = `${product.name} - $${product.price} 
        <button onclick="removeProduct(${product.id})">Remove</button>`;
    cartList.appendChild(li);
  });

  totalPrice.innerText = calculateTotal().toFixed(2);
}

addProductBtn.addEventListener("click", addProduct);
clearCartBtn.addEventListener("click", () => {
  cart = [];
  updateCartUI();
});
