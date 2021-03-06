<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Alpaka.Index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta charset="utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="X-UA-Compatible" content="IE=edge" />

      <!-- CSS -->
    <link href="Estilos/Index.css" rel="stylesheet" />
    <!-- Bootstrap CSS -->
    <link
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"
      rel="stylesheet"
      integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"
      crossorigin="anonymous"
    />
    <!-- Bootstrap JS -->
    <script
      src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"
      integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p"
      crossorigin="anonymous"
    ></script>
     <!-- Google Fonts -->
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link
      href="https://fonts.googleapis.com/css2?family=Nunito:ital,wght@1,200&display=swap"
      rel="stylesheet"
    />
    <title>Alpaka</title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="wrapper bg-body">
      <!-- navbar -->
      <header class="header">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <div class="container-fluid">
            <a class="navbar-brand" href="#">A l p a k a
              <img  class="llama" src="/resources/llama.png" alt="">
            </a>
            
            <button
              class="navbar-toggler"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#navbarSupportedContent"
              aria-controls="navbarSupportedContent"
              aria-expanded="false"
              aria-label="Toggle navigation"
            >
              <span>-</span>
              <span>-</span>
              <span>-</span>
            </button>
            <div
              class="collapse navbar-collapse justify-content-center"
              id="navbarSupportedContent"
            >
              <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                <li class="nav-item">
                  <a class="nav-link active" aria-current="page" href="Administracion.aspx"
                    >Administracion</a
                  >
                </li>

                <li class="nav-item">
                  <a class="nav-link" href="Perfil.aspx">Mi Perfil</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Carrito.aspx">Carrito</a>
                </li>
                <li class="nav-item dropdown">
                  <a
                    class="nav-link dropdown-toggle"
                    href="/Catalogo.aspx"
                    data-bs-toggle="dropdown"
                    aria-expanded="false"
                  >
                    Catalogo
                  </a>
                  <div class="dropdown-menu" arial-labelledby="navbarDropdown">
                    <br />
                    <br />
                    <a class="dropdown-item" href="Catalogo.aspx"
                      >Para ellos</a
                    >
                    <br />
                    <br />
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="Catalogo.aspx"
                      >Accesorios</a
                    >
                    <br />
                    <br />
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="Catalogo.aspx"
                      >Para ellas</a
                    >
                    <br />
                    <br />
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="Catalogo.aspx">Ver Todo</a>
                  </div>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#Sobre_Nosotros">Sobre Nosotros</a>
                </li>
              </ul>
              <ul class="navbar-nav ms-auto">
                  &nbsp;<asp:Button ID="Button1" runat="server" CssClass="btn btn-grad" Text="Iniciar Sesion" OnClick="Button1_Click" />
              </ul>
            </div>
          </div>
        </nav>
      </header>
      <!-- Carousel -->
      <div
        id="carouselExampleDark"
        class="carousel carousel-dark slide"
        data-bs-ride="carousel"
      >
        <div class="carousel-indicators">
          <button
            type="button"
            data-bs-target="#carouselExampleDark"
            data-bs-slide-to="0"
            class="active"
            aria-current="true"
            aria-label="Slide 1"
          ></button>
          <button
            type="button"
            data-bs-target="#carouselExampleDark"
            data-bs-slide-to="1"
            aria-label="Slide 2"
          ></button>
          <button
            type="button"
            data-bs-target="#carouselExampleDark"
            data-bs-slide-to="2"
            aria-label="Slide 3"
          ></button>
        </div>
        <div class="carousel-inner">
          <div class=" img carousel-item active" data-bs-interval="10000">
            <img src="resources/pexels-evg-culture-1040173.jpg" class=" d-block w-100" alt="..." />
            <div class="carousel-caption d-none d-md-block">
              <h5 class="texto">Aprovecha las ofertas</h5>
              <p class="texto">
                Dale un vistazo a lo nuevo de esta temporada
              </p>
            </div>
          </div>
          <div class="carousel-item" data-bs-interval="2000">
            <img src="/resources/pexels-evg-culture-1040173.jpg" class="d-block w-25" alt="..."> -->
            <div class="overlay-image"></div>
            <div class="carousel-caption d-none d-md-block">
              <h5 class="texto">Aprovecha las ofertas</h5>
              <p class="texto">
                Dale un vistazo a lo nuevo de esta temporada
              </p>
            </div>
          </div>
          <div class="carousel-item">
            <img src="/resources/pexels-evg-culture-1040173.jpg" class="d-block w-100" alt="..." />
            <div class="carousel-caption d-none d-md-block">
              <h5 class="texto">Aprovecha las ofertas</h5>
              <p class="texto">
                Dale un vistazo a lo nuevo de esta temporada
              </p>
            </div>
          </div>
        </div>
        <button
          class="carousel-control-prev"
          type="button"
          data-bs-target="#carouselExampleDark"
          data-bs-slide="prev"
        >
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </button>
        <button
          class="carousel-control-next"
          type="button"
          data-bs-target="#carouselExampleDark"
          data-bs-slide="next"
        >
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </button>
      </div>
      <!-- Cards -->
       <div class="iframe-container">
        <div class="titulo-cartas">
          <h1>Conoce nuestros productos</h1>
        </div>
          </div>
      <section>
        <div class="container">
          <div class="card m-4 border-0">
            <img
              src="resources/roma_mujer.jpg"
              alt="img1"
              class="card-img-top"
            />
            <div class="card-body">
              <h3 class="card-title">Para ellas</h3>
              <p class="card-text">
                La mejores prendas con todo el glamour de las nuevas temporadas
              </p>
              <a href="" class="btn btn-bg">Conoce mas</a>
            </div>
          </div>
          <div class="card m-4 border-0">
            <img
              src="resources/ropa_mujer.jpg"
              alt="img1"
              class="card-img-top"
            />
            <div class="card-body">
              <h3 class="card-title">Elegante</h3>
              <p class="card-text">
                Las prendas mas elegantes y sofisticadas de la temporada
              </p>
              <a href="" class="btn btn-bg">Conoce mas</a>
            </div>
          </div>

          <div class="card m-4 border-0">
            <img
              src="resources/accesorios.jpg"
              alt="img1"
              class="card-img-top"
            />
            <div class="card-body">
              <h3 class="card-title">Accesorios</h3>
              <p class="card-text">
                Complementa tus looks con los mejores accesorios
              </p>
              <a href="" class="btn btn-bg">Conoce mas</a>
            </div>
          </div>
        </div>
      </section>
      <!-- fin cartas -->
      <div class="iframe-container">
        <div class="titulo-mapa">
          <h1>Veni a visitarnos</h1>
        </div>
          
        <iframe
          src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3622.1797254863927!2d-65.42203618438415!3d-24.789298613965393!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x941bc3b1b1cc2db9%3A0xf03ab8e7a8f1b9a6!2sAlpaka!5e0!3m2!1ses!2sar!4v1622689421416!5m2!1ses!2sar"
          width="600"
          height="450"
          class="mapa"
          allowfullscreen=""
          loading="lazy"
        ></iframe>
      </div>
      <!-- footer -->
             <a id="Sobre_Nosotros"></a>
      <footer class="text-white bg-dark pt-0 pb-4">
        <div class="container text-center text-md-end abajo">
          <div class="row text-center text-md-end">
            <div class="col-md-3 col-lg-3 col-xl-3 mx-auto mt-3">
              <h3 class="text-uppercase mb-4 font-weight-bold titulos-footer">
                A L P A K A
              </h3>
              <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Iusto
                officia tempore rem corrupti quia voluptatem. Vitae et totam
                tenetur quis molestiae repellendus consequatur, quaerat dolores
                nam adipisci accusantium nostrum unde!
              </p>
            </div>
            <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mt-3">
              <h5
                class="
                  text-uppercase
                  mb-4
                  font-weight-bold
                  titulos-footer-chicos
                "
              >
                mas Informacion
              </h5>
              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Providers</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Creatinity</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Source</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Warehouse</a
                >
              </p>
            </div>
            <div class="col-md-3 col-lg-2 col-xl-2 mx-auto mt-3">
              <h5
                class="
                  text-uppercase
                  mb-4
                  font-weight-bold
                  titulos-footer-chicos
                "
              >
                Links Importantes
              </h5>
              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Providers</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Providers</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Providers</a
                >
              </p>

              <p>
                <a href="#" class="text-white" style="text-decoration: none"
                  >Providers</a
                >
              </p>
            </div>

            <div class="col-md-4 col-lg-3 col-xl-3 mx-auto mt-3">
              <h5 class="text-uppercase mb-4 font-weight-bold">Contactanos</h5>
              <p>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="20"
                  height="20"
                  fill="currentColor"
                  class="bi bi-house-door"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4.5a.5.5 0 0 0 .5-.5v-4h2v4a.5.5 0 0 0 .5.5H14a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146zM2.5 14V7.707l5.5-5.5 5.5 5.5V14H10v-4a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5v4H2.5z"
                  />
                </svg>
                Direccion del local
              </p>
              <p>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="20"
                  height="20"
                  fill="currentColor"
                  class="bi bi-envelope"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1H2zm13 2.383-4.758 2.855L15 11.114v-5.73zm-.034 6.878L9.271 8.82 8 9.583 6.728 8.82l-5.694 3.44A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.739zM1 11.114l4.758-2.876L1 5.383v5.73z"
                  />
                </svg>
                Email
              </p>
              <p>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="20"
                  height="20"
                  fill="currentColor"
                  class="bi bi-telephone-inbound"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M15.854.146a.5.5 0 0 1 0 .708L11.707 5H14.5a.5.5 0 0 1 0 1h-4a.5.5 0 0 1-.5-.5v-4a.5.5 0 0 1 1 0v2.793L15.146.146a.5.5 0 0 1 .708 0zm-12.2 1.182a.678.678 0 0 0-1.015-.063L1.605 2.3c-.483.484-.661 1.169-.45 1.77a17.568 17.568 0 0 0 4.168 6.608 17.569 17.569 0 0 0 6.608 4.168c.601.211 1.286.033 1.77-.45l1.034-1.034a.678.678 0 0 0-.063-1.015l-2.307-1.794a.678.678 0 0 0-.58-.122l-2.19.547a1.745 1.745 0 0 1-1.657-.459L5.482 8.062a1.745 1.745 0 0 1-.46-1.657l.548-2.19a.678.678 0 0 0-.122-.58L3.654 1.328zM1.884.511a1.745 1.745 0 0 1 2.612.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511z"
                  />
                </svg>
                Telefono
              </p>
            </div>
            <hr class="mb-4" />
            <div class="row align-items-center">
              <div class="col-md-7 col-lg-8">
                <p>Copyright 2021 All right reserved by: Alejo Torres</p>
              </div>
              <div class="col-md-5 col-lg-4">
                <div class="text-center text-md-right">
                  <ul class="list-unstyled list-inline">
                    <li class="list-inline-item">
                      <a class="btn-floating text-white" href="#">
                        <svg
                          xmlns="http://www.w3.org/2000/svg"
                          width="25"
                          height="25"
                          fill=" white"
                          class="bi bi-facebook"
                          viewBox="0 0 16 16"
                        >
                          <path
                            d="M16 8.049c0-4.446-3.582-8.05-8-8.05C3.58 0-.002 3.603-.002 8.05c0 4.017 2.926 7.347 6.75 7.951v-5.625h-2.03V8.05H6.75V6.275c0-2.017 1.195-3.131 3.022-3.131.876 0 1.791.157 1.791.157v1.98h-1.009c-.993 0-1.303.621-1.303 1.258v1.51h2.218l-.354 2.326H9.25V16c3.824-.604 6.75-3.934 6.75-7.951z"
                          />
                        </svg>
                      </a>
                    </li>
                    <li class="list-inline-item">
                      <a class="btn-floating text-white" href="#">
                        <svg
                          xmlns="http://www.w3.org/2000/svg"
                          width="25"
                          height="25"
                          fill="white"
                          class="bi bi-instagram"
                          viewBox="0 0 16 16"
                        >
                          <path
                            d="M8 0C5.829 0 5.556.01 4.703.048 3.85.088 3.269.222 2.76.42a3.917 3.917 0 0 0-1.417.923A3.927 3.927 0 0 0 .42 2.76C.222 3.268.087 3.85.048 4.7.01 5.555 0 5.827 0 8.001c0 2.172.01 2.444.048 3.297.04.852.174 1.433.372 1.942.205.526.478.972.923 1.417.444.445.89.719 1.416.923.51.198 1.09.333 1.942.372C5.555 15.99 5.827 16 8 16s2.444-.01 3.298-.048c.851-.04 1.434-.174 1.943-.372a3.916 3.916 0 0 0 1.416-.923c.445-.445.718-.891.923-1.417.197-.509.332-1.09.372-1.942C15.99 10.445 16 10.173 16 8s-.01-2.445-.048-3.299c-.04-.851-.175-1.433-.372-1.941a3.926 3.926 0 0 0-.923-1.417A3.911 3.911 0 0 0 13.24.42c-.51-.198-1.092-.333-1.943-.372C10.443.01 10.172 0 7.998 0h.003zm-.717 1.442h.718c2.136 0 2.389.007 3.232.046.78.035 1.204.166 1.486.275.373.145.64.319.92.599.28.28.453.546.598.92.11.281.24.705.275 1.485.039.843.047 1.096.047 3.231s-.008 2.389-.047 3.232c-.035.78-.166 1.203-.275 1.485a2.47 2.47 0 0 1-.599.919c-.28.28-.546.453-.92.598-.28.11-.704.24-1.485.276-.843.038-1.096.047-3.232.047s-2.39-.009-3.233-.047c-.78-.036-1.203-.166-1.485-.276a2.478 2.478 0 0 1-.92-.598 2.48 2.48 0 0 1-.6-.92c-.109-.281-.24-.705-.275-1.485-.038-.843-.046-1.096-.046-3.233 0-2.136.008-2.388.046-3.231.036-.78.166-1.204.276-1.486.145-.373.319-.64.599-.92.28-.28.546-.453.92-.598.282-.11.705-.24 1.485-.276.738-.034 1.024-.044 2.515-.045v.002zm4.988 1.328a.96.96 0 1 0 0 1.92.96.96 0 0 0 0-1.92zm-4.27 1.122a4.109 4.109 0 1 0 0 8.217 4.109 4.109 0 0 0 0-8.217zm0 1.441a2.667 2.667 0 1 1 0 5.334 2.667 2.667 0 0 1 0-5.334z"
                          />
                        </svg>
                      </a>
                    </li>
                    <li class="list-inline-item">
                      <a class="btn-floating text-white" href="#">
                        <svg
                          xmlns="http://www.w3.org/2000/svg"
                          width="25"
                          height="25"
                          fill="currentColor"
                          class="bi bi-twitter"
                          viewBox="0 0 16 16"
                        >
                          <path
                            d="M5.026 15c6.038 0 9.341-5.003 9.341-9.334 0-.14 0-.282-.006-.422A6.685 6.685 0 0 0 16 3.542a6.658 6.658 0 0 1-1.889.518 3.301 3.301 0 0 0 1.447-1.817 6.533 6.533 0 0 1-2.087.793A3.286 3.286 0 0 0 7.875 6.03a9.325 9.325 0 0 1-6.767-3.429 3.289 3.289 0 0 0 1.018 4.382A3.323 3.323 0 0 1 .64 6.575v.045a3.288 3.288 0 0 0 2.632 3.218 3.203 3.203 0 0 1-.865.115 3.23 3.23 0 0 1-.614-.057 3.283 3.283 0 0 0 3.067 2.277A6.588 6.588 0 0 1 .78 13.58a6.32 6.32 0 0 1-.78-.045A9.344 9.344 0 0 0 5.026 15z"
                          />
                        </svg>
                      </a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
      </footer>
    </div>
    <!--  fin footer -->
    </form>
</body>
</html>
