
async function update() {
    let thisUser = sessionStorage.getItem('details');
    let goodUser = JSON.parse(thisUser);

    const email = window.document.getElementById("email").value;
    const firstName = window.document.getElementById("fName").value;
    const lastName = window.document.getElementById("lName").value;
    const password = window.document.getElementById("password").value;
    const newUser = {
        "Id": goodUser.gooddata.id,
        "FirstName": firstName,
        "Password": password,
        "Lastname": lastName,
        "Email": email
    }
    const res = await fetch(`https://localhost:44319/api/User/${goodUser.gooddata.id}`,
        {
            headers: { "Content-Type": "application/json" },
            method: 'PUT',
            body: JSON.stringify(newUser)
        });

    if (!res.ok) {
        alert("please try again");
    }
    if (res.status == 204) {
        alert("no data");
        return;
    }
    if (res.status == 200) {
        alert(`${firstName},the data update`);
        const data = {
            "gooddata": JSON.stringify(newUser),
            "password": password
        }
        sessionStorage.setItem('details', JSON.stringify(data))
        window.location.href = "menu.html";

    }
    return;
}

async function GPTupdate() {
    const thisUser = JSON.parse(sessionStorage.getItem('details'));

    const email = document.getElementById("email").value;
    const firstName = document.getElementById("fName").value;
    const lastName = document.getElementById("lName").value;
    const password = document.getElementById("password").value;

    const newUser = {
        "Id": thisUser.id,
        "FirstName": firstName,
        "Password": password,
        "Lastname": lastName,
        "Email": email
    }

    try {
        const res = await fetch('https://localhost:44319/api/User', {
            method: 'PUT',
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(newUser)
        });

        if (!res.ok) {
            throw new Error(res.statusText);
        }

        const goodData = await res.json();
        alert(`${goodData.firstName}, the data update`);
    } catch (error) {
        console.error(error);
        alert("please try again");
    }
}

function load() {

    let thisUser = sessionStorage.getItem('details');
    let goodUser = JSON.parse(thisUser);
    window.document.getElementById("email").value = goodUser.gooddata.email;
    window.document.getElementById("password").value = goodUser.password;
    window.document.getElementById("fName").value = goodUser.gooddata.firstName;
    window.document.getElementById("lName").value = goodUser.gooddata.lastname;

    return;
}

