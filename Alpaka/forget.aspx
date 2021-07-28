<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forget.aspx.cs" Inherits="Alpaka.forget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="Estilos/Login.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
	<link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
    
	<title></title>
</head>
<body>
    <script src="Scripts/jquery-3.6.0.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js" integrity="sha512-AA1Bzp5Q0K1KanKKmvN/4d3IRKVlv9PYgwFPvm32nPO6QS8yH1HO7LbgB1pgiOxPtfeg5zEn2ba64MUcqJx6CA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="Scripts/ForgetSwal.js"></script>
	<form id="form1" runat="server">
        <div class="container-fluid">
		<div class="row">
			<div class="col-lg-6 col-md-6 form-container">
				<div class="col-lg-8 col-md-12 col-sm-9 col-xs-12 form-box">
					<div class="logo mt-5 mb-3 text-center">
						<h2 class="marca">A L P A K A</h2>
					</div>
					<div class="reset-form d-block">
						<form class="reset-password-form">
							<h4 class="mb-3">Reestablecer contraseña</h4>
							<p class="mb-3 text-white">
								Ingrese la direccion de correo asociada  a su cuenta de Alpaka 
							</p>
							<div class="form-input">
								<span><i class="fa fa-envelope"></i></span>
								<input type="email" placeholder="Email" name="email"required>
							</div>
							<div class="mb-3">
								<button type="submit" class="btn">Reenviar correo</button>
							</div>
						</form>
					</div>
					<div class="reset-confirmation d-none">
						<div class="mb-4">
							<h4 class="mb-3">El correo fue enviado</h4>
							<h6 class="text-white">Por favor,verifique su bandeja de entrada</h6>
						</div>
						<div>
							<a href="login.html">
								<button type="submit" class="btn">Login</button>
							</a>
						</div>
					</div>
				</div>
			</div>

			<div class="col-lg-6 col-md-6 d-none d-md-block image-container"></div>
		</div>
	</div>

	<script type="text/javascript">
		function PasswordReset() {
			$('form.reset-password-form').on('submit', function(e){
				e.preventDefault();
				$('.reset-form')
				.removeClass('d-block')
				.addClass('d-none');
				$('.reset-confirmation').addClass('d-block');
			});
		}

		window.addEventListener('load',function(){
			PasswordReset();
		});
    </script>
    </form>
</body>
</html>
