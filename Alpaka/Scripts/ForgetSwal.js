function EnvioCorrecto() {
    $(document).ready(() => {

        swal({
            title: "Correo Enviado!",
            text: "Verifica tu buzon de entrada",
            icon: "success",
        }).then(function () {
            window.location = "Login.aspx";
        });

    });
}
function EnvioIncorrecto() {
    $(document).ready(() => {
        swal({
            title: "Ups!",
            text: "Verifique el correo ingresado",
            icon: "error",
        });

    })

}