<%@page pageEncoding="UTF-8" contentType="text/html; charset=UTF-8"%>
<%@ taglib  uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"  %>
<%@ taglib  uri="http://www.springframework.org/tags" prefix="spring" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Biblioteka</title>

    <!-- Bootstrap Core CSS -->

	<link type="text/css" href="<c:url value="/resource/css/bootstrap.min.css"></c:url>" rel="stylesheet" />
    <!-- Custom CSS -->
	<link type="text/css" href="<c:url value="/resource/css/shop-homepage.css"></c:url>" rel="stylesheet" />
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <%@include file="navigation.jsp" %>

    <!-- Page Content -->
    <div class="container">



			<div class="col-lg-4">
				<h1>Logowanie</h1>
				<c:if test="${not empty error}">
					<div class="alert alert-danger">
						Złe hasło baranie<br />
					</div>
				</c:if>
				<form action="<c:url value="/j_spring_security_check"></c:url>" method="post">
	     			<input class="form-control" placeholder="Username" type="text" id="username" name="j_username" /> <br />
	     			<input class="form-control" placeholder="Password" type="password" id="password" name="j_password" /> <br />
	      			<input class=" btn btn-primary btn-block" type="submit" value="Log in" />
	    		</form>
			</div>

      
    </div>
    <!-- /.container -->

    <div class="container">

        <hr>

        <!-- Footer -->
        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p>Copyright &copy; Your Website 2014</p>
                </div>
            </div>
        </footer>

    </div>
    <!-- /.container -->

    <!-- jQuery -->
<!--     <script src="js/jquery.js"></script> -->
    <script src="<c:url value="/resource/js/jquery.js" />" type="text/javascript"></script>

    <!-- Bootstrap Core JavaScript -->
<!--     <script src="js/bootstrap.min.js"></script> -->
    <script src="<c:url value="/resource/js/bootstrap.min.js" />" type="text/javascript"></script>

</body>

</html>