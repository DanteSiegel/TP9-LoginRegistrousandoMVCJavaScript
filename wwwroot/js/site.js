function verContra() {
    const passwordInput = document.getElementById("Contrasena");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }
}
function verContra2() {
    const passwordInput = document.getElementById("Contrasena2");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }

}/*
 function isValidPassword(password) {
  const specialCharacters = /[!@#$%^&*()_+{}|:"<>?~`-]/;
  if (!specialCharacters.test(password)) {
    return false;
  }

  const uppercaseLetters = /[A-Z]/;
  if (!uppercaseLetters.test(password)) {
    return false;
  }

  if (password.length < 8) {
    return false;
  }

  return true;
}

  
const passwordInput = document.getElementById("Contrasena");

passwordInput.addEventListener("keyup", function() {
  const isPasswordValid = isValidPassword(passwordInput.value);

  if (!isPasswordValid) {
    document.getElementById("passwordError").textContent = "La contraseña debe tener al menos un carácter especial, una letra mayúscula y al menos 8 caracteres. 1";
  } else {
    document.getElementById("passwordError").textContent = "";
  }
});

const passwordInput2 = document.getElementById("Contrasena2");

passwordInput2.addEventListener("keyup", function() {
  const isPasswordValid2 = isValidPassword(passwordInput2.value);

  if (!isPasswordValid2) {
    document.getElementById("passwordError").textContent = "La contraseña debe tener al menos un carácter especial, una letra mayúscula y al menos 8 caracteres. 2";
  } else {
    document.getElementById("passwordError").textContent = "";
  }
  const passwordInput = document.getElementById("Contrasena");

  if(passwordInput.value != passwordInput2.value){
    document.getElementById("passwordError2").textContent = "Las contraseñas no coinciden";
  }else{
    document.getElementById("passwordError2").textContent = "";

  }
});

function ValidarContrasena(){
const passwordInput2 = document.getElementById("Contrasena2");

  const isPasswordValid2 = isValidPassword(passwordInput2.value);
let valido
let valido2
  if (!isPasswordValid2) {
    valido = false
    } else {
      valido = true
  }
  const passwordInput = document.getElementById("Contrasena");

  if(passwordInput.value != passwordInput2.value){
valido2 = false  }else{
valido2 = true  }
  }
  return(valido && valido2)
;*/