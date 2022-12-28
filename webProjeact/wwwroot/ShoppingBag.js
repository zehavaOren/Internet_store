load = () => {
    const products1 = sessionStorage.getItem("cart");
    const products = JSON.parse(products1);
  /*  showCart(products);*/
}
/*showCart = (product) => {


    var temp = document.getElementById("temp-row");
    var clone = temp.content.cloneNode(true);

    clone.querySelector(".imageColumn").src =`/img/${product.imgUrl}`;
    clone.querySelector(".descriptionColumn").innerText = product.description;
    clone.querySelector(".itemName").innerText = product.name;
    clone.querySelector(".price").src = product.price;
    document.getElementById(".itemsColumn").appendChild(clone);

}*/
placeOrder =async () => {
    console.log("vghv");
    var products1 = sessionStorage.getItem("cart");
    var products = JSON.parse(products1);
    

    const user1 = sessionStorage.getItem("details");
    const user = JSON.parse(user1);
    const orderItem = [];
    console.log(user);
    var totaiPrice = 0;
    var totaiPrice = 0;
    for (var i = 0; i < products.length; i++) {
        const newItem = {
            "Productid": products[i].id,
            "Quentity": 1,
        };
        orderItem.push(newItem);
        totaiPrice = totaiPrice+ products[i].price;
        console.log(newItem);
    }
    const newOrder = {
        "UserId": user.id,
        "Price": totaiPrice,
        "Date":new Date(),
        "orderItem": orderItem
    };
    console.log(newOrder);


    const res = await fetch('https://localhost:44319/api/Orders',
        {
            headers: { "Content-Type": "application/json" },
            method: 'POST',
            body: JSON.stringify(newOrder)
        })

    if (!res.ok) {
        alert("please try again");
    }
    if (res.status == 204) {
        alert("no data");
    }
    if (res.status == 200) {
        alert("woooooooooooo");
    }
   

}

document.addEventListener("load",load());