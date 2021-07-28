const CargarCarrito = (IDs,cantidades,nombres, precios, talles, colores, composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            cantidades = JSON.parse(cantidades)
            nombres = JSON.parse(nombres)
            precios = JSON.parse(precios)
            talles = JSON.parse(talles)
            colores = JSON.parse(colores)
            composiciones = JSON.parse(composiciones)
            urls = JSON.parse(urls)
            for (let index = 0; index < nombres.length; index++) {

                $("#articulos").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h3>" + nombres[index] + "</h3> <h4>Color: " + colores[index] + "</h4> <h5>Talle: " + talles[index] + "</h5> <h6>Tela: " + composiciones[index] + "</h6> <p>Precio: " + precios[index] + "</p> <p>Cantidad: " + cantidades[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
            }


        }

    )

}
