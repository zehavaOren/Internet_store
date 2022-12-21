// JavaScript source code

async function update() {
    let thisUser = sessionStorage.getItem('details');
    let goodUser = JSON.parse(thisUser);

    /*const email = window.document.getElementById("email").value;
    const firstName = window.document.getElementById("fName").value;
    const lastName = window.document.getElementById("lName").value;
    const password = window.document.getElementById("password").value;*/
    const newUser = {
        "id": goodUser.id,
        "firstName": goodUser.firstName,
        "password": goodUser.password,
        "lastName": goodUser.lastName,
        "email": goodUser.email
    }
    const jsonUser = JSON.stringify(newUser);
    const res = await fetch("https://localhost:44319/Api/User",
        {
            headers: { "content-type": "application/json" },
            method: 'PUT',
            body: jsonUser
        });

    if (!res.ok) {
        alert("please try again");
    }
    if (res.status == 204) {
        alert("no data");
        return;
    }
    if (res.status >= 200) { 
    const gooddata = await res.json();
        alert(`${gooddata.firstName} , the data update`);
    }
    return;
}
function load() {

    let thisUser = sessionStorage.getItem('details');
    let goodUser = JSON.parse(thisUser);

    window.document.getElementById("email").value = goodUser.email;
    window.document.getElementById("password").value = goodUser.password;
    window.document.getElementById("fName").value = goodUser.firstName;
    window.document.getElementById("lName").value = goodUser.lastName;

    return;
}
