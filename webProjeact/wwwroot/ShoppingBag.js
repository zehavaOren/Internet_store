load = () => {
    const cart = sessionStorage.getItem("cart");
    const carts = JSON.parse(cart);
    showCarts(carts);
}

showCart = (cart, i) => {
    let temp = document.getElementById("temp-row");
    let clone = temp.content.cloneNode(true);

    clone.querySelector(".itemName").innerText = cart.name;
    clone.querySelector(".price").innerText = cart.price;
    let sringImage = "./img/" + cart.imgUrl;
    clone.querySelector(".image").style.backgroundImage = `url(${sringImage})`;
    clone.querySelector(".DeleteButton").value = i;
    document.getElementsByTagName("tbody")[0].appendChild(clone);
}

const GPTshowCart = (cart, index) => {
    const temp = document.getElementById("temp-row");
    const clone = temp.content.cloneNode(true);

    clone.querySelector(".itemName").innerText = cart.name;
    clone.querySelector(".price").innerText = cart.price;
    const imageUrl = `./img/${cart.imgUrl}`;
    clone.querySelector(".image").style.backgroundImage = `url(${imageUrl})`;
    clone.querySelector(".DeleteButton").value = index;
    document.querySelector("tbody").appendChild(clone);
}

showCarts = (cart) => {
    var count = 0;
    
    for (var i = 0; i < cart.length; i++) {
        showCart(cart[i], i);
        count = count + cart[i].price;
    }
    document.getElementById("totalAmount").innerHTML = count;
    document.getElementById("itemCount").innerHTML = cart.length;
}
const GPTshowCarts = (cart) => {
    const totalAmount = cart.reduce((sum, item) => sum + item.price, 0);
    cart.forEach((item, i) => showCart(item, i));
    document.getElementById("totalAmount").innerHTML = totalAmount;
    document.getElementById("itemCount").innerHTML = cart.length;
}

 placeOrder = async() => {
    const producs = sessionStorage.getItem("cart");
    const products = JSON.parse(producs);

    const u = sessionStorage.getItem("details");
    const user = JSON.parse(u);

    const orderItem = [];
    var totalPrice = 0;

    for (var i = 0; i < products.length; i++) {
        newItem = {
            "Productid": products[i].id,
             "Quentity":1
        };
        orderItem.push(newItem);
        totalPrice+=products[i].price;
    }
    newOrder = {
        "UserId": user.gooddata.id,
        "PRICE": totalPrice,
        "DATE": new Date(),
        "OrderItems": orderItem
     };

     const objToSend = JSON.stringify(newOrder);
     const res = await fetch('https://localhost:44319/api/Orders',
         {
             headers: { "Content-Type": "application/json" },
             method: 'POST',
             body: objToSend
         })

     if (!res.ok) {
         alert("please try again");
     }
     if (res.status == 204) {
         alert("no data");
         return;
     }

     if (res.status == 200) {
         alert("thank you!!");    
     }
     
     sessionStorage.removeItem("products");
     sessionStorage.removeItem("cart");

     window.location.href = "menu.html";
     return;
    
}

const GPTplaceOrder = async () => {
    const products = JSON.parse(sessionStorage.getItem("cart"));
    const user = JSON.parse(sessionStorage.getItem("details"));

    const orderItems = products.map(product => ({ Productid: product.id, Quantity: 1 }));
    const totalPrice = products.reduce((sum, product) => sum + product.price, 0);
    const newOrder = {
        UserId: user.id,
        Price: totalPrice,
        Date: new Date(),
        OrderItems: orderItems
    };

    const res = await fetch('https://localhost:44319/api/Orders', {
        method: 'POST',
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(newOrder)
    });

    if (!res.ok) {
        alert("please try again");
    } else if (res.status === 204) {
        alert("no data");
    } else {
        alert("thank you!!");
        sessionStorage.removeItem("details");
        sessionStorage.removeItem("products");
        sessionStorage.removeItem("cart");
        window.location.href = "login.html";
    }
}

deleteItem = (value) => {
    const producs = sessionStorage.getItem("cart");
    const products = JSON.parse(producs);
    var res = [];
    for (var i = 0; i < products.length; i++) {
        if (i != value) {
            res.push(products[i]);
            continue;
        }
        else
            continue;
    }
    sessionStorage.setItem("cart", JSON.stringify(res) );
    deleteItems();
    load();
    return;
}

const GPTdeleteItem = (value) => {
    const products = JSON.parse(sessionStorage.getItem("cart"));
    const updatedProducts = products.filter((product, i) => i !== value);
    sessionStorage.setItem("cart", JSON.stringify(updatedProducts));
    deleteItems();
    load();
}

deleteItems = () => {
    var item = document.getElementsByClassName("item-row");
    for (var i = item.length; i > 0; i--) {
        item[0].remove();
    }

}

const GPTdeleteItems = () => {
    const items = document.querySelectorAll(".item-row");
    items.forEach(item => item.remove());
}