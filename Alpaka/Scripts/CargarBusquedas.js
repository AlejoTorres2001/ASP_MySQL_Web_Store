const CargarBusquedas = (IDs,nombres, precios, talles, colores, composiciones, urls) => {
    $(document).ready(
        () => {
            IDs = JSON.parse(IDs)
            nombres = JSON.parse(nombres);
            precios = JSON.parse(precios);
            talles = JSON.parse(talles);
            colores = JSON.parse(colores);
            composiciones = JSON.parse(composiciones);
            urls = JSON.parse(urls);
            for (let index = 0; index < IDs.length; index++) {
                console.log(nombres[index], precios[index])
                $("#catbusqueda").append
                    (" <div class='col - xs - 10 col - sm - 6 col - md - 4 producto'> <div class= 'card'> <img src='" + urls[index] + "' alt='ropa1'> <h1 class='textocartas tituloproducto'>" + nombres[index] + "</h1> <h4 class='textocartas'>Color: " + colores[index] + "</h4> <h5 class='textocartas'>Talle: " + talles[index] + "</h5> <h6 class='textocartas'>Tela: " + composiciones[index] + "</h6> <p class='textocartas'>Precio: " + precios[index] + "</p> <input class='check' type='checkbox' name='carrito' id='carrito' value=" + IDs[index] + "/> <input class='cantidad-prod' type='number' name='cantidad' id='cantidad'/> </div>  </div> ");
            }


        }

    )

}