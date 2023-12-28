var psd =0;

function cambiar_login() {
  document.querySelector('.cont_forms').className = "cont_forms cont_forms_active_login";  
  document.querySelector('.cont_form_login').style.display = "block";
  document.querySelector('.cont_form_sign_up').style.opacity = "0";               
  
  setTimeout(function(){  document.querySelector('.cont_form_login').style.opacity = "1"; },400);  
    
  setTimeout(function(){    
  document.querySelector('.cont_form_sign_up').style.display = "none";
  },200);  
 
    }
  
function cambiar_sign_up(at) {
    document.querySelector('.cont_forms').className = "cont_forms cont_forms_active_sign_up";
    document.querySelector('.cont_form_sign_up').style.display = "block";
  document.querySelector('.cont_form_login').style.opacity = "0";
    
  setTimeout(function(){  document.querySelector('.cont_form_sign_up').style.opacity = "1";
  },100);  
  
  setTimeout(function(){   document.querySelector('.cont_form_login').style.display = "none";
  },400);  
  
  
  }      
  
function ocultar_login_sign_up() {
  
  document.querySelector('.cont_forms').className = "cont_forms";  
  document.querySelector('.cont_form_sign_up').style.opacity = "0";               
  document.querySelector('.cont_form_login').style.opacity = "0"; 
  
  setTimeout(function(){
  document.querySelector('.cont_form_sign_up').style.display = "none";
  document.querySelector('.cont_form_login').style.display = "none";
  },500);  
    
    } 
  
async function enter() {
   
      const user = window.document.getElementById("user").value;
      const pass = window.document.getElementById("pass").value;
  
       const url = `https://localhost:44319/Api/User?email=${user}&password=${pass}`
       const res = await fetch(url);
      if (!res.ok) {
          alert("please try again");
          return;

      }
      if (res.status == 204) {
          alert("no data");
          return;
        }
        var gooddata = await res.json();
        alert(`welcome ${gooddata.firstName}`);
        const data = {
            "gooddata": gooddata,
            "password":pass
        }
        sessionStorage.setItem('details', JSON.stringify(data))
        window.location.href = "menu.html";
      return;
}

async function signIn() {
    if (!validate()) {
        return;
    }
    if (this.psd ==0 ) {
        alert("the password isn't checked, please check it");
        return;
    }
    if (this.psd < 3) {
        alert("the password isn't strong please enter new password");
        return;
    }


    const email = window.document.getElementById("email").value;
    const firstName = window.document.getElementById("fName").value;
    const lastName = window.document.getElementById("lName").value;
    const password = window.document.getElementById("password").value;

    newUser = {
        "firstName": firstName,
        "password": password,
        "lastName": lastName,
        "email": email
    };

      const res = await fetch('https://localhost:44319/api/User',
        {
            headers: { "Content-Type": "application/json" },
            method: 'POST',
            body: JSON.stringify(newUser)
        })

    if (!res.ok) {
        alert("please try again");
    }
   
    else  { 
        alert(`welcome ${firstName}`);
        window.location.href = "login.html";
    }
    return;
}

async function check() {

    password = window.document.getElementById("password").value;
    
    const res = await fetch('https://localhost:44319/api/Password',
        {
            headers: { "Content-Type": "application/json" },
            method: 'POST',
            body: JSON.stringify(password)
        })
    if (res.ok) {
        let data = await res.json();
        this.psd = data;
        alert(data);
    }
    else {
        alert("the password isn't strong' please enter new password");
    }
 
   
}

function validate ()  {
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;
    var firstName = document.getElementById("fName").value;
    var lastName = document.getElementById("lName").value;
    var error_message = document.getElementById("error_message");
    var text;
    if (email == "") {
        text = "Please Enter Email";
        error_message.innerHTML = text;
        return false;
    }
    
    if (firstName == "") {
        text = "Please Enter first name";
        error_message.innerHTML = text;
        return false;
    }
    if (firstName.length < 5) {
        text = "Your first name too short";
        error_message.innerHTML = text;
        return false;
    }
    if (lastName == "") {
        text = "Please Enter last name";
        error_message.innerHTML = text;
        return false;
    }
    if (lastName.length < 5) {
        text = "Your last name too short";
        error_message.innerHTML = text;
        return false;
    }
    if (password == "") {
        text = "Please Enter password";
        error_message.innerHTML = text;
        return false;
    }
    

    return true;
}