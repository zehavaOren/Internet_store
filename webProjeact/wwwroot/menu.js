let li = document.querySelectorAll("li");

li.forEach((elem) => {
    elem.addEventListener("mouseover", (e) => {
        let spanElem = elem.querySelector(".ribbon span");
        let val = e.target.textContent.trim();

        if (spanElem.textContent == "") {
            spanElem.textContent = val;
        }
    });

    elem.addEventListener("mouseleave", (e) => {
        let spanElem = elem.querySelector(".ribbon span");
        spanElem.textContent = "";
    });
});
