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

        <div class="row">

            <div class="col-md-3">
                <p class="lead">Kategorie</p>
                <div class="list-group">
                    <a href="#" class="list-group-item">Kategoria 1</a>
                    <a href="#" class="list-group-item">Kategoria 2</a>
                    <a href="#" class="list-group-item">Kategoria 3</a>
                </div>
            </div>

            <div class="col-md-9">

                <div class="row carousel-holder">

                    <div class="col-md-12">
                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                            </ol>
                            <div class="carousel-inner">
                                <div class="item active">
                                    <img class="slide-image" src="http://placehold.it/800x300" alt="">
                                </div>
                                <div class="item">
                                    <img class="slide-image" src="http://placehold.it/800x300" alt="">
                                </div>
                                <div class="item">
                                    <img class="slide-image" src="http://placehold.it/800x300" alt="">
                                </div>
                            </div>
                            <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                                <span class="glyphicon glyphicon-chevron-left"></span>
                            </a>
                            <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                                <span class="glyphicon glyphicon-chevron-right"></span>
                            </a>
                        </div>
                    </div>

                </div>

                <div class="row">

                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="https://static01.helion.com.pl/global/okladki/326x466/htcsww.jpg" style="width:50%" alt="">
                            <div class="caption">
                                <h4>
                                	<a href="#">Pierwszy tytuł</a>
                                </h4>
                                <h5>
                                	<a href="#">Pierwszy Autor</a>
                                </h5>
                                <p>Krótki opis książki</p>
                            </div>
                            <div class="ratings">
                                <p class="pull-right">15 opinii</p>
                                <p>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                </p>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="https://static01.helion.com.pl/global/okladki/326x466/htcsww.jpg" style="width:50%" alt="">
                            <div class="caption">
                                <h4>
                                	<a href="#">Drugi tytuł</a>
                                </h4>
                                <h5>
                                	<a href="#">Drugi Autor</a>
                                </h5>
                                <p>To jest krótki opis ksiażki.</p>
                            </div>
                            <div class="ratings">
                                <p class="pull-right">12 opinii</p>
                                <p>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star-empty"></span>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
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