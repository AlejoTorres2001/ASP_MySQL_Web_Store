<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Alpaka.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="Estilos/Login.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
	<link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <title>Login</title>
</head>
<body>
    <script src="Scripts/jquery-3.6.0.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js" integrity="sha512-AA1Bzp5Q0K1KanKKmvN/4d3IRKVlv9PYgwFPvm32nPO6QS8yH1HO7LbgB1pgiOxPtfeg5zEn2ba64MUcqJx6CA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="Scripts/LoginSwal.js"></script>
    <form id="form1" runat="server">
        <div class="container-fluid">
		<div class="row">
			<div class="col-lg-6 col-md-6 form-container">
				<div class="col-lg-8 col-md-12 col-sm-9 col-xs-12 form-box text-center">
					<div class="logo mt-5 mb-3">
						<h2 class="marca">A L P A K A</h2>
						
					</div>
					<div class="heading mb-3">
						<h4>Ingresa a tu cuenta</h4>
					</div>
					<form  id="fromulario" method="post">
						<div class="form-input">
							<span><i class="fa fa-envelope"></i></span>
							<input type="email" placeholder="Email" name="email" required>
						</div>
						<div class="form-input">
							<span><i class="fa fa-lock"></i></span>
							<input type="password" placeholder="****" name="password" required>
						</div>
						<div class="row mb-3">
							<div class="col-6 d-flex">
								<div class="custom-control custom-checkbox">
									<input type="checkbox" class="custom-control-input" id="cb1">
									<label class="custom-control-label text-white" for="cb1">Recordarme</label>
								</div>
							</div>
							<div class="col-6 text-right">
								<a href="forget.aspx" class="forget-link">Olvide mi Contraseña</a>
							</div>
						</div>
						<div class="text-left mb-3">
							<button type="submit" class="btn">Login</button>
						</div>
						<div class="text-white mb-3">Accede con</div>
						<div class="row mb-3">
							<div class="col-4">
								<a href="" class="btn btn-block btn-social btn-facebook">
									<i class="fa fa-facebook"></i>
								</a>
							</div>
							<div class="col-4">
								<a href="" class="btn btn-block btn-social btn-google">
									<i class="fa fa-google"></i>
								</a>
							</div>
							<div class="col-4">
								<a href="" class="btn btn-block btn-social btn-twitter">
									<i class="fa fa-twitter"></i>
								</a>
							</div>
						</div>
						<div class="text-white">No tienes una cuenta?
							<a href="register.aspx" class="register-link">Registrate aqui</a>
						</div>
					</form>
				</div>
			</div>

			<div class="col-lg-6 col-md-6 d-none d-md-block image-container"></div>
		</div>
	</div>
    </form>
</body>
</html>
