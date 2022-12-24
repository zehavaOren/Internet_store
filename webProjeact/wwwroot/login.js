/* ------------------------------------ Click on login and Sign Up to  changue and view the effect
---------------------------------------
*/

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
  
  
  
    async function enter ()  {
      const user = window.document.getElementById("user").value;
      const pass = window.document.getElementById("pass").value;
  
       const url = `https://localhost:44319/Api/User?email=${user}&password=${pass}`
       const res = await fetch(url);
      if (!res.ok) {
          alert("please try again");
          return;
  //        localStorage.setItem('thisUser', JSON.stringify(gooddata2));
  //        window.location.href = "user.html";
      }
      if (res.status == 204) {
          alert("no data");
          return;
      }
      const gooddata = await res.json();
           alert(`welcome ${gooddata.firstName}`);
           sessionStorage.setItem('details', JSON.stringify(gooddata))
          // localStorage.setItem('thisUser', JSON.stringify(gooddata));
           window.location.href = "menu.html";
  
      return;
  }
  async function signIn() {

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
    if (res.status == 204) {
        alert("no data");
        return;
    }
    //if (res.status == 400) {
    //    alert(res.title)
  //  }
    //console.log(res.title);
    // console.log(ValidityState);
    console.log(res);
    if (res.status == 201) { 
    const gooddata = await res.json();
    alert(`welcome ${gooddata.firstName}`);
    }
    return;
}
async function check() {

  const password = window.document.getElementById("password").value;
    
    const res = await fetch('https://localhost:44319/api/Password',
        {
            headers: { "Content-Type": "application/json" },
            method: 'POST',
            body: JSON.stringify(password)
        })
  //alert(res);
  const data = await res.json
  alert(data);
    window.document.getElementById("res").value = res;
    return;
}