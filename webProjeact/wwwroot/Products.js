
load =  () => {
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
        displayCategorys(data);
    }
}


displayCategorys = (data) => {
    console.log("scssful");
  /* console.log(data);*/
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
    clone.querySelector(".opt").value = category.ID;
    document.getElementById("categoryList").appendChild(clone);
}
showProducts = (data) => {
    for (var i = 0; i < data.length; i++) {
        showProduct(data[i]);
    }

}
showProduct = (product) => {
    var temp = document.getElementById("temp-card");
    var clone = temp.content.cloneNode(true);
  /*  console.log(product.name);*/
    clone.querySelector("h1").innerText = product.name;
    clone.querySelector(".price").innerText = product.price;
    clone.querySelector(".description").innerText = product.description;
    clone.querySelector("img").src = "/images/" + product.imgURL;
    document.body.appendChild(clone);
}
document.addEventListener("load", load());

