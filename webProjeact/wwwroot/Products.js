var productArry = [];
 var count = 0;
load = () => {
    loadProducts();
    loadCategories();
}


loadProducts =async () => {
    const url = "Api/Products";
    const res = await fetch(url);
   /* console.log(res);*/
    if (!res.ok)
        alert("Error! Products!");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
        /* console.log(data);*/
        sessionStorage.setItem("products", JSON.stringify(data));
        showProducts(data);
    }
}
loadCategories =async () => {
    const url = "Api/Categories";
    const res = await fetch(url);
   /* console.log(res);*/
    if (!res.ok)
        alert("Error! category");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
        /*  console.log(data);*/
        fullProductsInCategory(data);
        displayCategorys(data);
    }
}


displayCategorys = (data) => {
    console.log("scssful");
    for (var i = 0; i < data.length; i++) {
       /* console.log(data[i]);*/
       displayCategory(data[i]);

    }
}
displayCategory = (category) => {
   /* console.log(category);*/
    var temp = document.getElementById("temp-category");
    var clone = temp.content.cloneNode(true);
    clone.querySelector(".OptionName").innerText = category.categoryName;
    clone.querySelector(".Count").innerText = `(${category.products.length})`;
    clone.querySelector(".opt").value = category.id;
    console.log(clone.querySelector(".opt").value);
    document.getElementById("categoryList").appendChild(clone);
}
fullProductsInCategory = (data) => {
    var products1 = sessionStorage.getItem("products");
    var products = JSON.parse(products1);
    console.log(products);
    console.log(data);
    for (var i = 0; i < data.length; i++) {
        for (var product = 0; product < products.length; product++) {
            if (products[product].category == data[i].id) {
                data[i].products.push(products[product]);
            }
        }
    }
    console.log(data);
}



showProducts = (data) => {
    document.getElementById("counter").innerText = data.length;
    for (var i = 0; i < data.length; i++) {
        showProduct(data[i]);
    }

}
showProduct = (product) => {
    console.log(product.name);
    var temp = document.getElementById("temp-card");
    var clone = temp.content.cloneNode(true);

  /*  console.log(product.name);*/
    clone.querySelector("h1").innerText = product.name;
    clone.querySelector(".price").innerText = product.price;
    clone.querySelector(".description").innerText = product.description;
    clone.querySelector("img").src = `/img/${product.imgUrl}`;
    clone.querySelector("button").value = product.id;
    // clone.querySelector("button").setAttribute("value",product.id);
    document.getElementById("PoductList").appendChild(clone);
}

filterProducts = async () => {
    console.log("filter");
    var priceTo = document.getElementById("minPrice").value;
    var priceFrom = document.getElementById("maxPrice").value;

   /* var categoryId = document.getElementsByClassName("opt");*/
    var name = document.getElementById("nameSearch").value;
    var start = 1;
    var limit = 20;
    var direction = "ASC";
    var orderBy = "price";
    var categoryId = "";

    var categoryList = document.getElementsByClassName("opt");
    console.log(categoryList);
    for (var i = 0; i < categoryList.length; i++) {
        if (categoryList[i].checked) {
            categoryId+=`&categoryId=${categoryList[i].value}`;
            console.log(categoryList[i].value);
        }
    }

    console.log(categoryId);
    const url = `Api/Products/?name=${name}${categoryId}&priceFrom=${priceFrom}&priceTo=${priceTo}&start=${start}&limit=${limit}&orderBy=${orderBy}&direction=${direction}`;
    const res = await fetch(url);
    /* console.log(res);*/
    if (!res.ok)
        alert("Error! filter!");
    else if (res.status == 204) {
        alert("no data");
        return;
    }
    else {
        const data = await res.json();
        console.log(data);
        deleteItem();
        showProducts(data);

    }

}
deleteItem = () => {
    console.log("vghh")
    /*document.getElementById("PoductList").remove();
    var div1 = document.createElement("div");
    div1.setAttribute("id", "PoductList");
    document.body.appendChild(div1);*/


    var cards = document.getElementsByClassName("card");
    console.log(cards);
    for (var i = cards.length; i > 0; i--) {
        console.log(cards[0]);
        cards[0].remove();
    }

}

addToCart = (id) => {
    addToCart = (id) => {
        var products1 = sessionStorage.getItem("cart");
        var products = JSON.parse(products1);
        count = products.length;
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

