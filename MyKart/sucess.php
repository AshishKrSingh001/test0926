<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $user = $_SESSION['c_user'];
        if($user == false)
        {
            header("location: login.php");
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cart.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
    <style>
        .body{
            margin:2vh 1vw;
            height:42vh;
            width:97.5vw;
            background-color: rgb(28, 26, 26);
            color:white;
            border-radius:10px;
            padding:17vh 20vw;
        }
        .con{
            height:8vh;
            width:57.5vw;
            background-color: white;
            padding:2vh;
            box-shadow: 0px 10px 100px 25px #28283d;
            border-radius:5px;
        }
        
        .con p{
            color:blue;
            text-align:center;
            font-weight:bold;
        }
        .con p a{
            color:red;
            font-style:italic;
            text-decoration:underline;
        }
    </style>
</head>
<body>
    <div class="header"><?php include("header.php"); ?></div>
    <div class="body">
        <div class="con">
            <p>Your order has been placed successfully. <a href="cart.php">for more details</a></p>
        </div>
    </div>
    <div class="footer"><?php include("footer.php"); ?></div>
</body>
</html>