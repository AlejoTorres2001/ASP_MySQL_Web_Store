function Actualizacion() {
    $(document).ready(() => {

        swal({
            title: "Datos modificados!",
            icon: "success",
        }).then(function () {
            window.location = "Perfil.aspx";
        });

    });
}
function NoPuedeEntrar() {
    $(document).ready(() => {
        console.log("hola");
        swal({
            title: "Debe Iniciar sesion primero",
            icon: "error",
        }).then(function () {
            window.location = "Login.aspx";
        });

    });
}