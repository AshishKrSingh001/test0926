<?php
    $connect = mysqli_connect("localhost", "root", "", "mykart");
    session_start();
    $search = $_SESSION['search'];
    if($connect)
    {
        $record_per_page = 4;
        $page = '';
        if(isset($_GET["page"]))
        {
            $page = $_GET["page"];
        }
        else
        {
            $page = 1;
        }

        $start_from = ($page-1)*$record_per_page;

        $query1 = "SELECT * FROM product WHERE productName LIKE '%$search%' order by productName DESC LIMIT $start_from, $record_per_page";
        $result1 = mysqli_query($connect, $query1);   
        if($result1)
        {
            $noDataFound = "";
            $q = "SELECT COUNT(*) as count FROM product WHERE productName LIKE '%$search%' order by productName";
            $r = mysqli_query($connect, $q);   
            $row = $r->fetch_assoc();

            if ($row['count'] >= 1) {
                $noDataFound = "<b style='color:green;'>" .ucwords($search) . "</b>";
            }
            else{
                $noDataFound = "<b style='color:red;'>" .ucwords($search) . " not found!</b>";
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/search.css">
    <link rel="icon" type="image/iconMykart.jpg" href="image/faviconMyKart.ico">
    <title>MyKart</title>
</head>
<body>
    <div class="header"><?php include("header.php"); ?></div>
    <div class="main">
            <div class="row">
            <h2 align="center"><?php echo $noDataFound; ?></h2>
                <?php while($row = mysqli_fetch_array($result1)){?>
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
                $page_query1 = "SELECT * FROM product WHERE productName LIKE '%$search%' order by productName DESC LIMIT $start_from, $record_per_page";
                $page_result1 = mysqli_query($connect, $page_query1);
                $total_records = mysqli_num_rows($page_result1);
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
                    echo "<a class='a' href='index.php?page=1'>First</a>";
                    echo "<a class='a' href='index.php?page=".($page - 1)."'>Previous</a>";
                }
                for($i=$start_loop; $i<=$end_loop; $i++)
                {     
                    echo "<a class='a' href='index.php?page=".$i."'>".$i."</a>";
                }
                if($page < $end_loop)
                {
                    echo "<a class='a' href='index.php?page=".($page + 1)."'>Next</a>";
                    echo "<a class='a' href='index.php?page=".$total_pages."'>Last</a>";
                }
            ?>
        </div>
    </div>
    <div class="footer"><?php include("footer.php"); ?></div>
</body>
</html>

