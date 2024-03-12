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
                $price = $_POST['price'];
                $manufacturer = $_POST['manufacturer'];
                $discount = $_POST['discount'];
                $delivery = $_POST['delivery'];
                $warranty = $_POST['warranty'];
                $inc_com = $_POST['inc_com'];
                $specialFeature = $_POST['specialFeature'];
                $sno = $user;

                $image_size1 = getimagesize($_FILES['x']['tmp_name']);
                $image_size2 = getimagesize($_FILES['y']['tmp_name']);

                if ($image_size1 && $image_size2)
                {
                    mkdir("Image/ProductImage/" . $pname . "-" . $cname);
                    $target_dir = "Image/ProductImage/" . $pname . "-" . $cname . "/";
                    $target_file1 = $target_dir . $pname . "_1.jpg";
                    $target_file2 = $target_dir . $pname . "_2.jpg";

                    if (file_exists($target_file1) || file_exists($target_file2)) 
	                {
                        $msg= "image already exists";
                    }
                    else 
                    {
                        $q = "INSERT INTO product(productName,companyName,quan,category,ProductImage1,productImage2,productDescription,SellerNo,price,manufacturer,discount,delivery,warranty,inc_com,specialFeature) values('$pname','$cname','$quan','$category','$target_file1','$target_file2','$pd','$sno','$price','$manufacturer','$discount','$delivery','$warranty','$inc_com','$specialFeature');";

                        $rs = mysqli_query($con,$q);
                        if($rs)
                        {
                            if (move_uploaded_file($_FILES["x"]["tmp_name"],$target_file1)
                            && move_uploaded_file($_FILES["y"]["tmp_name"],$target_file2))
                            {
                                $msg = "Product is uploaded";
                            }
                            else 
                            {
                                $msg= "image not uploaded";
                            }
                        }
                        else
                        {
                            $msg =  ("Error description: " . mysqli_error($con));
                        } 
                    }
                }
                else
                {
                    $msg =  ("Error description(File uploaded is not a valid image): " . mysqli_error($con));
                } 

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
    <link rel="stylesheet" href="CSS/productEntry.css">
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
                        <li><input class="input" type="text" name="pname" placeholder="Product Name" required></li>
                        <li><input class="input" type="text" name="cname" placeholder="Company Name"required></li>
                        <li><input class="input" type="Number" name="quan" placeholder="Quantity"required></li>
                        <li><input class="input" type="Number" name="price" placeholder="Price"required></li>
                        <li><input class="input" type="text" name="manufacturer" placeholder="Manufacturer"required></li>
                        <li><input class="input" type="Number" name="discount" placeholder="Discount"required></li>
                        <li><input class="input" type="Number" name="delivery" placeholder="Delivery Charges"required></li>
                        <li><input class="input" type="text" name="warranty" placeholder="Warranty Period / Expiry Date"required></li>
                        <li><input class="input" type="text" name="inc_com" placeholder="Included Components"required></li>
                        <li><input class="input" type="text" name="specialFeature" placeholder="Special Features"required></li>
                    </ul>
                </div>
                <div class="upright">
                    <ul>
                    <li style="margin-top:.2vh;"><label class="label" for="HTML">Category:</label></li>
                    <li>
                            <select class="input" name="category">
                                <option value="Grocery">&nbsp;&nbsp;&nbsp;&nbsp;Grocery</option>
                                <option value="Mobile">&nbsp;&nbsp;&nbsp;&nbsp;Mobile</option>
                                <option value="Fashion">&nbsp;&nbsp;&nbsp;&nbsp;Fashion</option>
                                <option value="Electronics">&nbsp;&nbsp;&nbsp;&nbsp;Electronics</option>
                                <option value="Furniture">&nbsp;&nbsp;&nbsp;&nbsp;Home & Furniture</option>
                                <option value="Appliance">&nbsp;&nbsp;&nbsp;&nbsp;Appliance</option>
                                <option value="Beauty_Toy">&nbsp;&nbsp;&nbsp;&nbsp;Beauty Toy & More</option>
                                <option value="TwoWheeler">&nbsp;&nbsp;&nbsp;&nbsp;Two Wheeler</option>
                                
                            </select>
                        </li>
                        <li style="margin-top:2vh;"><label class="label" for="HTML">Enter Product Image:</label></li>
                        <li><input Style="Background-color:White; padding:1vh 0;" class="input" type="file" name="x"required></li>
                        <li><input Style="Background-color:White; padding:1vh 0;" class="input" type="file" name="y"required></li>
                        <li style="margin-top:2vh;"><label class="label" for="HTML">Product Description:</label></li>
                        <li><textarea class="text" name="pd" cols="50" rows="7"></textarea></li>
                        <li class="sub"><input style="cursor:pointer;" type="submit" name="submit" value="Submit"required></li>
                        <li class="transfer"><input style="cursor:pointer;" type="reset" name="reset" value="Reset"required></li>
                    </ul>
                </div>
            </form>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>