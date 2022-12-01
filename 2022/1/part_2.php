<?php

$result = include("./part_1.php");

rsort($result);

var_dump($result[0]+$result[1]+$result[2]);
