<?php

// Get the list of "calories" for each "elf"
$result = include("./part_1.php");

// Sort the list of "calories" for each "elf" in descending order
rsort($result);

// Get the first 3 "calories" from the list combined
var_dump($result[0]+$result[1]+$result[2]);
