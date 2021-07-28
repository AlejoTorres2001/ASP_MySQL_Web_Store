function Correcto() {
    $(document).ready(() => {

        swal({
            icon: "success",
        }).then(function () {
            window.location = "Index.aspx";
        });

    });
}
function Incorrecto() {
    $(document).ready(() => {
        swal({
            title: "Usuario y/o contraseña incorrecto/s",
            icon: "error",
        });

    })

}