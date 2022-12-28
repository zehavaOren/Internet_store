load = () => {
    const products1 = sessionStorage.getItem("cart");
    const products = JSON.parse(products1);
    showCart(products);
}
showCart = (product) => {


    var temp = document.getElementById("temp-row");
    var clone = temp.content.cloneNode(true);

    clone.querySelector(".imageColumn").src =`/img/${product.imgUrl}`;
    clone.querySelector(".descriptionColumn").innerText = product.description;
    clone.querySelector(".itemName").innerText = product.name;
    clone.querySelector(".price").src = product.price;
    document.getElementById(".itemsColumn").appendChild(clone);

}

document.addEventListener("load",load());