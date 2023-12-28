var poductsArray = [];
var count = 0;
var i = 0;
var prod = [];

load = () => {
    loadProducts();
    loadCategories();
}

loadProducts = async () => {
   
    const url = "Api/Products";
    const res = await fetch(url);
    if (!res.ok)
        alert("Error! Products!");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
        sessionStorage.setItem("products", JSON.stringify(data));
        showProducts(data);
    }

    var res2 = sessionStorage.getItem("cart");
    if (res2 == "") {
        sessionStorage.setItem("cart", prod);
    }
    else {
        var res3 = JSON.parse(res2);
        document.getElementById("ItemsCountText").innerHTML = res3.length;
    }
    
}

loadCategories = async () => {
    const url = "Api/Categories";
    var res = await fetch(url);
    if (!res.ok)
        alert("Error! category");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
         displayCategorys(data);
    }
    return;
}

displayCategorys = (data) => {
    if (i == 0) {
        for (; i < data.length; i++) {
            tnp = data[i];
            displayCategory(tnp);
        }
    }
    
    return;
}

displayCategory = (category) => {
    var temp = document.getElementById("temp-category");
    var clone = temp.content.cloneNode(true);
    clone.querySelector(".OptionName").innerText = category.categoryName;
    clone.querySelector(".Count").innerText = `(${category.productsAmount})`;
    clone.querySelector(".opt").value = category.id;
    document.getElementById("categoryList").appendChild(clone);
    
}

fullProductsInCategory = (data) => {
    var products1 = sessionStorage.getItem("products");
    var products = JSON.parse(products1);
    for (var i = 0; i < data.length; i++) {
        for (var product = 0; product < products.length; product++) {
            if (products[product].category == data[i].id) {
                data[i].products.push(products[product]);
            }
        }
    }
}

showProducts = (data) => {
    document.getElementById("counter").innerText = data.length;
    for (var i = 0; i < data.length; i++) {
        showProduct(data[i]);
    }

}

showProduct = (product) => {
    var temp = document.getElementById("temp-card");
    var clone = temp.content.cloneNode(true);
    document.getElementById("ItemsCountText").innerHTML = count;
    clone.querySelector("h1").innerText = product.name;
    clone.querySelector(".price").innerText = product.price;
    clone.querySelector(".description").innerText = product.description;
    clone.querySelector("img").src = `/img/${product.imgUrl}`;
    clone.querySelector("button").value = product.id;
    document.getElementById("PoductList").appendChild(clone);
}

filterProducts = async () => {
    var priceTo = document.getElementById("minPrice").value;
    var priceFrom = document.getElementById("maxPrice").value;

    var name = document.getElementById("nameSearch").value;
    var start = 1;
    var limit = 20;
    var direction = "ASC";
    var orderBy = "price";
    var categoryId = "";

    var categoryList = document.getElementsByClassName("opt");
    for (var i = 0; i < categoryList.length; i++) {
        if (categoryList[i].checked) {
            categoryId += `&categoryId=${categoryList[i].value}`;
        }
    }

    const url = `Api/Products/?name=${name}${categoryId}&priceFrom=${priceFrom}&priceTo=${priceTo}&start=${start}&limit=${limit}&orderBy=${orderBy}&direction=${direction}`;
    const res = await fetch(url);
    if (!res.ok)
        alert("Error! filter!");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
        deleteItem();
        showProducts(data);

    }

}

deleteItem = () => {
    var cards = document.getElementsByClassName("card");
    for (var i = cards.length; i > 0; i--) {
        cards[0].remove();
    }

}

addToCart = (id) => {
    var products1 = sessionStorage.getItem("cart");
    var products;
    if (products1 == null) {
        count = 0;
        products = [];
    }
    else {
        products = JSON.parse(products1);
        count = products.length;
    }
  
    const data = sessionStorage.getItem("products");
    const goodData = JSON.parse(data);
    
    for (var i = 0; i < goodData.length; i++) {
        if (goodData[i].id == id) {
            poductsArray.push(goodData[i]);
            products.push(goodData[i])
            
        }
    }
    sessionStorage.setItem("cart", JSON.stringify(products));
    document.getElementById("ItemsCountText").innerHTML = count + 1;
    count = count + 1;

}
document.addEventListener("load", load());

const GPTaddToCart = (id) => {
    let products = JSON.parse(sessionStorage.getItem("cart")) || [];
    const productsData = JSON.parse(sessionStorage.getItem("products"));
    const selectedProduct = productsData.find(product => product.id === id);

    products.push(selectedProduct);
    sessionStorage.setItem("cart", JSON.stringify(products));
    document.getElementById("ItemsCountText").innerHTML = products.length;
}

document.addEventListener("load", load());