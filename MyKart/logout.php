<?php
    session_start();
    if($_GET['name']=="seller")
    {
        unset($_SESSION['s_name']);
        unset($_SESSION['s_user']);
    }
    else if($_GET['name']=="user")
    {
        unset($_SESSION['c_name']);
        unset($_SESSION['c_user']);
    }
    header("location: index.php");
?>