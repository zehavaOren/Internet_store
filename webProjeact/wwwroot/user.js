// JavaScript source code

 update= async()=> {
    let thisUser = sessionStorage.getItem('details');
    console.log(thisUser);
    let goodUser = JSON.parse(thisUser);
    console.log(goodUser);

    const email = window.document.getElementById("email").value;
    const firstName = window.document.getElementById("fName").value;
    const lastName = window.document.getElementById("lName").value;
    const password = window.document.getElementById("password").value;

    console.log(email);
    const newUser = {
        "Id": goodUser.id,
        "FirstName": firstName,
        "Password": password,
        "Lastname": lastName,
        "Email": email
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

        if (res.status == 204) {
            alert("no data");
            return;
        }
        if (res.status == 200) {
            const gooddata = await res.json();
            alert(`${gooddata.firstName} , the data update`);
        }
        return;
    }
}
    function load() {

        let thisUser = sessionStorage.getItem('details');
        let goodUser = JSON.parse(thisUser);
        console.log(goodUser);
        console.log(goodUser.lastname);

        window.document.getElementById("email").value = goodUser.email;
        window.document.getElementById("password").value = goodUser.password;
        window.document.getElementById("fName").value = goodUser.firstName;
        window.document.getElementById("lName").value = goodUser.lastname;

        return;
    }
