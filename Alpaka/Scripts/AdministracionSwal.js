function Incorrecto() {
    $(document).ready(() => {
        swal({
            title: "Ups!",
            text: "No tiene los permisos necesarios",
            icon: "error",
        }).then(function () {
            window.location = "Index.aspx";
        });

    })

}