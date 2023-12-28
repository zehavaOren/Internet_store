//using System;
//using System.Net;
//using System.Net.Mail;
//using Mail;
//using MailMessage;

function validate() {
    var name = document.getElementById("name").value;
    var subject = document.getElementById("subject").value;
    var phone = document.getElementById("phone").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;
    var error_message = document.getElementById("error_message");

    error_message.style.padding = "10px";

    var text;
    if (name.length < 5) {
        text = "Please Enter valid Name";
        error_message.innerHTML = text;
        return false;
    }
    if (subject.length < 10) {
        text = "Please Enter Correct Subject";
        error_message.innerHTML = text;
        return false;
    }
    if (isNaN(phone) || phone.length != 10) {
        text = "Please Enter valid Phone Number";
        error_message.innerHTML = text;
        return false;
    }
    if (email.indexOf("@") == -1 || email.length < 6) {
        text = "Please Enter valid Email";
        error_message.innerHTML = text;
        return false;
    }
    if (message.length <= 10) {
        text = "Please Enter More Than 140 Characters";
        error_message.innerHTML = text;
        return false;
    }
    send()
    alert("Form Submitted Successfully!");
    
    return true;
}

send = () => {
   
    var nodemailer = require('nodemailer');
    var email = document.getElementById("email").value;
    let transporter = nodemailer.createTransport({
        host: 'smtp.example.com',
        port: 587,
        secure: false,
        auth: {
            user: 'sender@example.com',
            pass: 'password'
        }
    });

    let mailOptions = {
        from: document.getElementById("email").value,
        to: 's.z.giftssite@gmail.com',
        subject: document.getElementById("subject").value,
        text: document.getElementById("message").value
    };

    transporter.sendMail(mailOptions, (error, info) => {
        if (error) {
            return console.log(error);
        }
        console.log('Email sent: %s', info.messageId);
    });

    alert("the form send!");
    window.location.href = "menu.html";

}
