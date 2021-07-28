function Correcto() {
    $(document).ready(() => {


        swal({
            title: "Todo listo!",
            icon: "correct",
            text: "Su compra fue registrada con exito",
        }).then(function () {
            window.location = "Index.aspx";
        });

    });
}
function ups() {
    $(document).ready(() => {


        swal({
            title: "Ups!",
            icon: "error",
            text: "Por el momento no contamos con las existencias solcitadas,prueba mas tarde",
        }).then(function () {
            window.location = "Catalogo.aspx";
        });

    });
}