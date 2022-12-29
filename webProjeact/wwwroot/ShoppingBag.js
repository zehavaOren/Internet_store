load = () => {
    const products1 = sessionStorage.getItem("cart");
    const products = JSON.parse(products1);
   showCarts(products);
}
showCarts = (products) => {
    var count= 0;
    for (var i = 0; i < products.length; i++) {
        count += products[i].price;

        showCart(products[i]);
    }
    document.getElementById("totalAmount").innerHTML = count;
    document.getElementById("itemCount").innerHTML = products.length;
}
showCart = (productCart) => {

    console.log(productCart)
    var temp = document.getElementById("temp-row");
    var clone = temp.content.cloneNode(true);
    console.log(productCart.name);
    console.log(productCart.id);
    let stringImag = "./img/" + productCart.imgUrl;
    console.log(stringImag);
    clone.querySelector(".image").style.backgroundImage = `url(${stringImag})`;
    clone.querySelector(".itemName").innerText = productCart.name;
    clone.querySelector(".itemNumber").innerText = 1;
    clone.querySelector(".price").innerText = productCart.price;
    document.getElementsByTagName("tbody")[0].appendChild(clone);

   


}
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

