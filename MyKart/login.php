<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        if(isset($_POST['submit']))
        {
            if(!empty($_POST['mob']) && !empty($_POST['password']))
            {
                $mob = trim($_POST['mob']);
                $pass = trim($_POST['password']);

                $query = "SELECT * from customer where MobileNo='$mob'and password='$pass' ";
                $rs = mysqli_query($con,$query);
                if($rs)
                {
                    $row = mysqli_num_rows($rs);
                    if($row)
                    {
                        $user="";
                        $name="";
                        foreach ($con->query($query) as $r) 
                        {
                            $user = $r['customerNo'];
                            $name = $r['customerFName'] . " " . $r['customerMName'] . "<br>" . $r['customerLName'];
                        }
                        $_SESSION['c_user'] = $user;
                        $_SESSION['c_name'] = $name;

                        header("location: index.php");
                    } 
                    else
                    {
                        $msg =  ("Error description(Invalid username or password): " . mysqli_error($con));
                    }
                }
                else
                {
                    $msg =  ("Error description(connection): " . mysqli_error($con));
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
    <link rel="stylesheet" href="CSS/login.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
    <script>
        function show() 
        {
            var x = document.getElementById("myInput");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }
        }
    </script>
</head>
<body>
<div class="header"><?php include("header.php") ?></div>
<div class="body">
    <div class="msg" style="margin:.5vw 0;height:1vw;font-weight:bold;"><p style="color:red; text-align:center;"><?php echo $msg; ?></p></div>
    <div class="main">
        <div class="left">
            <div class="up">
                <h4 style="text-align:center;">USER-LOGIN-PAGE</h4><hr style="margin-top:1vh;">
                <h5 style="margin-top:1vw;color:grey;text-align:center">Welcome to MyKart</h5>
                <p style="font-size:1vw; margin-top:1vw;color:grey;"> "Most people spend more time and energy going around problems than in trying to solve them."</p>
                <hr style="margin:1vw;">
            </div>
            <div class="down">
                <img src="image/logo.png" alt="image/alt.jpg">
            </div>
        </div>
        <div class="right">
            <form action="" class="form" method="POST">
                <ul>
                    <li><input class="username" type="text" name="mob" placeholder="Enter Mobile number"></li>
                    <li><input id ="myInput"class="password" type="password" name="password" placeholder="Enter Password"></li>
                    <li style="margin-left:15vw;"><input class="checkbox" onclick="show()"type="checkbox" name="checkbox">&nbsp;<b style="font-size:1vw;">Show Password</b>&nbsp;&nbsp;&nbsp;&nbsp;</li>
                    <li style="margin:1vw 0;"><p style="font-size:.9vw; text-align:center;">By continuing, you agree to Flipkart's <a style="color:maroon;" href="">Terms of Use</a> and <a style="color:maroon;" href="">Privacy Policy</a>.</p></li>
                    <li class="sub">
                        <input style="cursor:pointer;" type="submit" name="submit" value="Submit"></li>
                </ul>
            </form>
            <div class="register" style="margin-top: 5vw;"><a href="registerUserMob.php"><p>New to MyKart? Create an account</p></a></div>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>