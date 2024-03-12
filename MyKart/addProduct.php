<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $user = $_SESSION['s_user'];
        if($user == false)
        {
            header("location: sellerLogin.php");
        }
        if(isset($_POST['submit']))
        {
            if(!empty($_POST["category"]) && !empty($_POST["pname"]) && !empty($_POST["cname"]) && !empty($_POST["quan"]) && !empty($_POST["pd"]))
            {
                $pname = trim($_POST["pname"]);
                $cname = trim($_POST["cname"]);
                $quan = $_POST['quan'];
                $category = $_POST['category'];
                $pd = $_POST['pd'];
                $sno = $user;

            }
            else
            {
                $msg =  ("Error description(Not all field filled): " . mysqli_error($con));
            } 
        }
    }
    else
    {
        $msg =  ("Error description(connection): " . mysqli_error($con));
    } 
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/addProduct.css">
    <link rel="icon" type="image/iconMykart.jpg" href="image/faviconMyKart.ico">
    <title>MyKart</title>
</head>
<body>
<div class="header"><?php include("header.php") ?></div>
<div class="body">
    <div class="msg" style="margin:1vh 0;height:2vh;font-weight:bold;"><p style="color:red; text-align:center;"><?php echo $msg; ?></p></div>
    <div class="head"><a href="seller.php"><div class="link"><p>Show available Products</p></div></a></div>
    <div class="main">
        <div class="left">
            <div class="up">
                <h3 style="text-align:center;">PRODUCT ENTRY</h3><hr style="margin-top:1vh;">
                <h3 style="margin-top:2vh;color:grey;text-align:center;">Welcome to MyKart</h3>
                <p style="font-size:2vh; margin-top:1vh;color:grey;"> "Most people spend more time and energy going around problems than in trying to solve them."</p><hr style="margin:2vh 0 2vh 0;">
            </div>
            <div class="down" style="margin: 2vh 0 2vh 0;">
                <img style="margin:2vh 0;"src="image/logo.jpg" alt="image/alt.jpg">
                <img src="image/logo.png" alt="image/alt.jpg">
            </div>
        </div>
        <div class="right">
            <form action="" class="form" method="POST" enctype="multipart/form-data">
                <div class="upleft">
                    <ul>
                        <li><input class="input" type="text" name="pname" placeholder="Product Name" value=""></li>
                        <li><input class="input" type="text" name="cname" placeholder="Company Name"></li>
                        <li><input class="input" type="Number" name="quan" placeholder="Quantity"></li>
                        <li style="margin-top:2vh;"><label class="label" for="HTML">Product Description:</label></li>
                        <li><textarea class="text" name="pd" cols="50" rows="5"></textarea></li>                
                    </ul>
                </div>
                <div class="upright">
                    <ul>
                        <li><img class="adimage"src="Image/ad_image01.jpg" alt="Image/alt.jpg"></li>
                        <li class="sub"><input style="cursor:pointer;" type="submit" name="submit" value="Submit"></li>
                        <li class="transfer"><input style="cursor:pointer;" type="reset" name="reset" value="Reset"></li>
                    </ul>
                </div>
            </form>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>