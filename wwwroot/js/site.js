function verContra() {
    const passwordInput = document.getElementById("Contrasena");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }

}