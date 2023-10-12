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

}function validarFormulario() {
  let password = document.getElementById("Contrasena").value;
  let confirmPassword = document.getElementById("Contrasena2").value;

  var caracterEspecial = /[$&+,:;=?@#|'<>.^*()%!-]/.test(password);

  if (!caracterEspecial) {
      document.getElementById("mensajeError").innerHTML = "La contraseña debe contener al menos un carácter especial.";
      return false;
  } 

  if (password.length < 8) {
      document.getElementById("mensajeError").innerHTML = "La contraseña debe tener al menos 8 caracteres.";
      return false;
  }

  if (confirmPassword !== password) {
      document.getElementById("mensajeError").innerHTML = "Las contraseñas no coinciden. Por favor, inténtelo de nuevo.";
      document.getElementById("Contrasena2").value = "";
      return false;
  }
  return true;
}