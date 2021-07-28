const CargarCatalogoHombresPantalones = (IDs,nombres, precios, talles, colores, composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            for (let index = 0; index < nombres.length; index++) {
                $("#cathombrespantalones").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Tela: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
            }


        }

    )

}
const CargarCatalogoHombresRemeras = (IDs, nombres, precios, talles, colores, composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            for (let index = 0; index < nombres.length; index++) {
                $("#cathombresremeras").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Tela: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
            }


        }

    )

}


const CargarCatalogoMujeresPantalones = (IDs,nombres, precios,talles,colores,composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            for (let index = 0; index < nombres.length; index++) {
                $("#catmujerespantalones").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Tela: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");

            }



            }

    )

}
const CargarCatalogoMujeresRemeras = (IDs, nombres, precios, talles, colores, composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            for (let index = 0; index < nombres.length; index++) {
                $("#catmujeresremera").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Tela: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");

            }



        }

    )

}

const CargarCatalogoAccsesorios = (IDs,nombres, precios, talles, colores, composiciones,subcat, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            subcat = JSON.parse(subcat)
            console.log(nombres, precios)
            for (let index = 0; index < nombres.length; index++) {
                if (subcat[index] === 'perfumes') {


                    $("#cataccperfumes").append
                        (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Marca: " + colores[index] + "</h4> <h5>Tamaño: " + talles[index] + "</h5> <h6>Creador: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
                }
                else {
                    $("#cataccbijouterie").append
                        (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Material: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
                }
            }


        }

    )

}
const DebeRegistrarse = () => {
    $(document).ready(() => {
        console.log("hola");
        swal({
            title: "UPS",
            icon: "information",
            text: "Debe registrarse primero",
        }).then(function () {
            window.location = "Login.aspx";
        });

    });
}
