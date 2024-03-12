<?php
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        if(isset($_POST["sub_search"]) && !empty($_POST['search']))
        {           
            $_SESSION['search'] = $_POST['search'];
            if($_SESSION)
            {
                header("location:search.php");
            }
        }
    }
?><!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/header.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>header</title>
</head>
<body>
    <div class="container">
        <header class="header">
                <!-- Logo -->
                <a href="index.php" class="logo"><p><img style="height:13vh; width:13vw;"src="Image/logo.jpg" alt="Image.alr.jpg"></p></a>
                <div class="x"></div>       
                <form action="" method="POST">
                    <ul class="menu">
                        <div class="front-end"><?php if(isset($_SESSION['s_user'])){?><li style="text-align:center;margin-top:1.5vw;"><a href="logout.php?name=seller"><p class="logout" style="color:white;"><?php echo "Logout-SELLER<br><b style='color:green;font-size:3vh;'>" . ucwords($_SESSION['s_name']) . "</b>";?></p></a></li><li><a href="seller.php"><p class="seller">Seller-Items</p></a></li><?php }else{?><li><a href="sellerLogin.php"><p class="login">Become a Seller</p></a></li><?php }?></div>
                        <div class="front-end"><?php if(isset($_SESSION['c_user'])){?><li style="margin-left:2px;"><a href="cart.php"><img src="image/cart.png" alt="alt.jpg" class="cartlogo"></a></li>
                        <li style="margin-right:0px;"><a href="cart.php"><p class="cart">Orders</p></a></li><li style="margin-left:2px;margin-top:1.5vw;"><img src="image/login.png" alt="alt.jpg" class="loginlogo"></li><li style="margin-right:0px;margin-top:1.5vw;text-align:center;"><a href="logout.php?name=user"><p class="logout" style="color:white;"><?php echo "Logout-USER<br><b style='color:green;font-size:3vh;'>" . ucwords($_SESSION['c_name']) . "</b>";?></p></a></li><?php }else{?><li style="margin-left:2px;"><img src="image/login.png" alt="alt.jpg" class="loginlogo"></li><li style="margin-right:0px;"><a href="login.php"><p class="login">Login</p></a></li><?php }?></div>
                        <li  style="margin-left:0px;"><button style="background-color:transparent;" class="img_search" type="submit" name="sub_search"><img src="image/search-icon.png" alt="alt.jpg"></button></li>
                        <li  style="margin-right:0px;"><input class="search" type="text" name="search" placeholder="SEARCH" ></li>
                    </ul>
                </form>
        </header>
    </div> 
</body>
</html>