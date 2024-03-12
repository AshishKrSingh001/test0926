<?php
session_start();
    $connect = mysqli_connect("localhost", "root", "", "mykart");
    if($connect)
    {
        $record_per_page = 4;
        $page = '';
        $id = $_GET['id'];
        if(isset($_GET["page"]))
        {
            $page = $_GET["page"];
        }
        else
        {
            $page = 1;
        }

        $start_from = ($page-1)*$record_per_page;

        $query = "SELECT * FROM product where category='$id' order by productNo DESC LIMIT $start_from, $record_per_page";
        $result = mysqli_query($connect, $query);
    }

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/page.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
</head>
<body>
    <div class="header"><?php include("header.php"); ?></div>
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
                $page_query = "SELECT * FROM product where category='$id' order by productNo DESC";
                $page_result = mysqli_query($connect, $page_query);
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
                    echo "<a class='a' href='grocery.php?page=1'>First</a>";
                    echo "<a class='a' href='grocery.php?page=".($page - 1)."'>Previous</a>";
                }
                for($i=$start_loop; $i<=$end_loop; $i++)
                {     
                    echo "<a class='a' href='grocery.php?page=".$i."'>".$i."</a>";
                }
                if($page < $end_loop)
                {
                    echo "<a class='a' href='grocery.php?page=".($page + 1)."'>Next</a>";
                    echo "<a class='a' href='grocery.php?page=".$total_pages."'>Last</a>";
                }
            ?>
        </div>
    </div>
    <div class="footer"><?php include("footer.php"); ?></div>
</body>
</html>

