<?php
    session_start();
    $msg="If any query or suggestions you have you may post it";
    $connect = mysqli_connect("localhost", "root", "", "mykart");
    if($connect)
    {
        $user = $_SESSION['c_user'];
        if($user == false)
        {
            header("location: login.php");
        }
        $q1 = "SELECT * FROM customer WHERE customerNo='$user'";
        $rs1 = mysqli_query($connect,$q1);
        $row1  = mysqli_fetch_array($rs1);
        $id = $_GET['dl'];
        $q = "SELECT productNo,productName,companyName,quan,category,productImage1,productImage2,productDescription,seller.sellerNo,price,manufacturer,discount,delivery,warranty,inc_com,specialFeature,sellerFName,sellerMName,sellerLName,email,saddress,sDateOfBirth,MobileNo FROM product,seller where productNo='$id' and product.sellerNo = seller.sellerNo";
        $rs = mysqli_query($connect,$q);
        $row  = mysqli_fetch_array($rs);
		
        if(isset($_POST['confirm-order']))
        {
            $sno = $row['sellerNo'];
            $cno = $user;
            $pno = $row['productNo'];
            $orderDate = date("Y/m/d");
            $deliveryDate = Date('y:m:d', strtotime('+7 days'));
            $queryConfirm = "INSERT INTO productBuyed(sellerNo,customerNo,productNo,orderDate,deliveryDate) VALUES('$sno','$cno','$pno','$orderDate','$deliveryDate')";
            $resultConfirm = mysqli_query($connect,$queryConfirm);
            if($resultConfirm)
            {
                header("location:sucess.php");
            }
            else
            {
                $msg =  ("Error description: " . mysqli_error($connect));
            }
        }
        if(isset($_POST['post']) && !empty($_POST['name']) && !empty($_POST['email']) && !empty($_POST['comment']))
        {
            $name = $_POST['name'];
            $email = $_POST['email'];
            $comment = $_POST['comment'];
            $q = "INSERT INTO comment(name,email,comment) values('$name','$email','$comment')";
            $rs = mysqli_query($connect,$q);
            if($rs)
            {
                $msg="Thanks for posting your comment";
            }
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/details.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
</head>
<body>
    <dic class="container">
        <div class="header"><?php include("header.php"); ?></div>
        <div class="main">
            <div class="abc">
                <div class="a">
                    <h2 style="text-align:center; margin-bottom:1vh;color:blue;"><?php echo "Buy " . ucwords($row['productName']) . "  (" . $row['companyName'] . ")  " . $row['category']; ?></h2>
                </div>
                <div class="b">
                    <div class="b1"><img src="<?php echo $row['productImage1'];?>" alt="Image/alt.jpg" class="logo1"></div>
                    <div class="b2">
                    <p><b>Price: </b><?php 
                        $p = $row['price'] + (($row['price'] * $row['discount'])/100);
                        echo "<b style='color:red;'>-" . $row['discount'] . "%&nbsp;off</b>" . "&nbsp;&nbsp;<i style='text-decoration:line-through'>&#8377;" . $p . "</i>&nbsp;&nbsp;<b style='color:red;'>&#8377;" . $row['price'] . "</b>";?></p>
                        <hr>
                        <p><?php echo $row['productDescription'];?></p>
                        <hr>
                        <p style='color:yellow;'><i>Only&nbsp;<?php echo $row['quan'];?>&nbsp;item left</i></p>
                    </div>
                </div>
                <div class="c">
                    <p><b>Warranty</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['warranty'];?></p>
                    <hr>
                    <h3 style="text-align:center;">Seller Contact Details</h3>
                    <p><b>Seller Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['sellerFName'] . " " . $row['sellerMName'] . " " . $row['sellerLName'];?></p>
                    <p>&#128231; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['email'];?></p>
                    <p>&#9742; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['MobileNo'];?></p>
                    <p><b>Address</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['saddress'];?></p>
                    <hr>
                    <h3 style="text-align:center;">Product Details</h3>
                    <p><b>Product Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['productName'];?></p>
                    <p><b>Company Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['companyName'];?></p>
                    <p><b>Category</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['category'];?></p>
                    <p><b>Brand</b>&nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['manufacturer'];?></p>
                    <p><b>Delivery Charges</b> &nbsp;&nbsp;:&nbsp;&nbsp; 
                    <?php if($row['delivery'] ==0){echo "<b style='text-decoration:line-through;color:green;'>&#8377;40</b> Free";}else{echo "<b style='color:green;'>&#8377;" . $row['delivery'] . "</b>";};?></p>
                    <p><b>Discount</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo "<b style='color:red;'>-" . $row['discount'] . "%&nbsp;off</b>";?></p>
                    <p><b>Feature</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['specialFeature'];?></p>
                    <p><b>Included Component</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['inc_com'];?></p>
                    <hr>
                    <h3 style="text-align:center;">User's Address Details</h3>
                    <p><b>Customer Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row1['customerFName'] . " " . $row1['customerMName'] . " " . $row1['customerLName'];?></p>
                    <p>&#128231; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row1['email'];?></p>
                    <p>&#9742; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row1['MobileNo'];?></p>
                    <p><b>Address</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row1['caddress'];?></p>
                    <hr>
                </div>
                <div class="d">
                    <h2>Images</h2>
                    <img src="<?php echo $row['productImage1'];?>" alt="Image/alt.jpg">
                    <img src="<?php echo $row['productImage2'];?>" alt="Image/alt.jpg">
                </div>
                <div class="e"  align="center">
                    <form action="" method="POST">
                        <input type="submit" name="confirm-order" style="margin:1vh 2vw;" value="Confirm Order">
                    </form>
                    <p class="msg"><?php echo $msg;?></p>
                </div>
                <div class="f">
                    <nav class="com">
                        <form action="" method="POST">
                            <ul>
                                <li>&nbsp;&nbsp;Comment: </li>
                                <li><textarea name="comment"required></textarea></li>
                                <li>&nbsp;&nbsp;Name: </li>
                                <li><input class="input" type="text" name="name" required></li>
                                <li>&nbsp;&nbsp;Email: </li>
                                <li><input class="input" type="email" name="email" required></li>
                                <li align="right"><input class="btn" type="submit" name="post" value="Post"></li>
                            </ul>
                        </form>
                    </nav>
                    <nav class="pic"><img src="Image/ad_image01.jpg" alt="Image/alt.jpg"></nav>
                </div>
            </div>
        </div>
        <div class="footer"><?php include("footer.php"); ?></div>
    </div>
</body>
</html>