<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $mob = $_SESSION['c_mobile_number'];
        if($mob == false)
        {
            header("location: registerUserMob.php");
        }
        if(isset($_POST['submit']))
        {
            if(!empty($_POST['fname']) && !empty($_POST['mname']) && !empty($_POST['lname']) && !empty($_POST['email']) && !empty($_POST['dob']) && !empty($_POST['address']) && !empty($_POST['pass'])  && !empty($_POST['cpass']) &&($_POST['pass']==$_POST['pass']))
            {
                $fname = trim($_POST['fname']);
                $mname = trim($_POST['mname']);
                $lname = trim($_POST['lname']);
                $email = trim($_POST['email']);
                $dob = $_POST['dob'];
                $add = trim($_POST['address']);
                $pass = trim($_POST['pass']);

                $query = "INSERT INTO customer(customerFName,customerMName,customerLName,email,cdateOfBirth,caddress,MobileNo,password) values('$fname','$mname','$lname','$email','$dob','$add','$mob','$pass')";
                $rs = mysqli_query($con,$query);
                if($rs)
                {
                    header("location: login.php");
                } 
                else
                {
                    $msg = mysqli_error($con);
                }
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="registerUser.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
</head>
<body>
<div class="header"><?php include("header.php") ?></div>
<div class="body">
<div class="msg" style="margin:.5vw 0;height:.5vw;font-weight:bold;"><p style="color:red; text-align:center;"><?php echo $msg; ?></p></div>
    <div class="main">
        <div class="left">
            <div class="up">
                <h4 style="text-align:center;">USER<br>REGISTRATION</h4><hr style="margin-top:1vh;">
                <h5 style="margin-top:1vw;color:grey;text-align:center;">Welcome to MyKart</h5>
                <p style="font-size:2vh; margin-top:1vh;color:grey;"> "Most people spend more time and energy going around problems than in trying to solve them."</p><hr style="margin:2vh 0 2vh 0;">
            </div>
            <div class="down" style="margin:2vw 0">
                <img src="image/logo.jpg" alt="image/alt.jpg">
                <img src="image/logo.png" alt="image/alt.jpg">
            </div>
        </div>
        <div class="right">
            <form class="form"action="" class="form" method="POST">
                <div class="upleft">
                    <ul>
                     <li style="margin-top:1vw;"><label class="label" for="HTML">Full Name:</label></li>
                        <li><input class="input" type="text" name="fname" placeholder="First Name"></li>
                        <li><input class="input" type="text" name="mname" placeholder="Middle Name"></li>
                        <li><input class="input" type="text" name="lname" placeholder="Last Name"></li>
                        <li style="margin-top:1vw;"><label class="label" for="html">Email:</label></li>
                        <li><input class="input" type="email" name="email" placeholder="Email"></li>
                        <li style="margin-top:1vw;"><label class="label" for="html">Date of Birth:</label></li>
                        <li><input class="input" type="Date" name="dob" placeholder="Date of Birth"></li>
                        <li style="margin-top:1vw;"><label class="label" for="html">Address:</label></li>
                        <li><textarea class="text" name="address" cols="50" rows="7"></textarea></li>                
                    </ul>
                </div>
                <div class="upright">
                    <ul>
                        <li><img class="adimage"src="Image/ad_image01.jpg" alt="Image/alt.jpg"></li>
                        <li style="margin-top:1vw;"><label class="label" for="html">Password:</label></li>
                        <li><input class="input" type="password" name="pass" placeholder="Enter Password"></li>
                        <li><input class="input" type="password" name="cpass" placeholder="Confirm Password"></li>
                        <li class="sub"><input type="submit" name="submit" value="Submit"></li>
                        <li class="sub"><input style="Background-color:grey;color:blue;" type="reset" name="reset" value="Reset"></li>
                        <li class="transfer"><a href="login.php"><p Style="font-size:1vw;">Existing User? Log in</p></a></li>
                    </ul>
                </div>
            </form>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>