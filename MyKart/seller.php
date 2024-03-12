<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $record_per_page = 4;
        $page = '';
        $user = $_SESSION['s_user'];
        if($user == false)
        {
            header("location: SellerLogin.php");
        }
        if(isset($_GET["page"]))
        {
            $page = $_GET["page"];
        }
        else
        {
            $page = 1;
        }

        $start_from = ($page-1)*$record_per_page;

        $query = "SELECT * FROM product where sellerNo='$user' order by productNo DESC LIMIT $start_from, $record_per_page";
        $result = mysqli_query($con, $query);
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/seller.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
</head>
<body>
    <div class="header"><?php include("header.php") ?></div>
    <div class="body">
        <div class="head"><a href="productEntry.php"><div class="link"><p>Enter More Product Details</p></div></a></div>
        <div class="tail">
            <h1>Available Product Are: </h1>
        </div>
        <div class="main">
            <div class="row">
                <?php while($row = mysqli_fetch_array($result)){?>
                <div class="col">
                <div class="card">
                    <a href="details.php?dl=<?php echo $row['productNo'];?>"><img src="<?php echo $row['productImage1']; ?>" alt="alt.jpg"></a>
                        <a href="details.php?dl=<?php echo $row['productNo'];?>"><div align="center" class="card_body">
                            <p><?php echo ucwords($row['productName']); ?></p><p><?php echo "<b style='color:red;'>&#8377;" . $row['price'] . " </b>(<b style='color:green;'>" . $row['discount'] . "%OFF</b>)";?></p>
                            <p><?php echo "<i style='color:yellow;'>only " . $row['quan'] . " item left</i>"; ?></p>
                        </div></a>
                    </div>
                </div>
                <?php
                }?>
            </div>
        <div class="php" align="center">
            <?php
                $page_query = "SELECT * FROM product where sellerNo='$user' ORDER BY productNo DESC";
                $page_result = mysqli_query($con, $page_query);
                $total_records = mysqli_num_rows($page_result);
                $total_pages = ceil($total_records/$record_per_page);
                $start_loop = $page;
                $difference = $total_pages - $page;
                if($difference <= 3)
                {
                    $start_loop = $total_pages - 3;
                    if($start_loop<1)
                    {
                        $start_loop=1;
                    }
                }
                $end_loop = $start_loop + 2;
                if($end_loop>$total_pages)
                {
                    $end_loop = $start_loop + 1;
                    if($end_loop>$total_pages)
                    {
                        $end_loop = $start_loop;
                    }
                }
                if($page > 1)
                {
                    echo "<a class='a' href='seller.php?page=1'>First</a>";
                    echo "<a class='a' href='seller.php?page=".($page - 1)."'>Previous</a>";
                }
                for($i=$start_loop; $i<=$end_loop; $i++)
                {     
                    echo "<a class='a' href='seller.php?page=".$i."'>".$i."</a>";
                }
                if($page < $end_loop)
                {
                    echo "<a class='a' href='seller.php?page=".($page + 1)."'>Next</a>";
                    echo "<a class='a' href='seller.php?page=".$total_pages."'>Last</a>";
                }
            ?>
        </div>
    </div>
    </div>
    <div class="footer"><?php include("footer.php") ?></div>
</body>
</html>