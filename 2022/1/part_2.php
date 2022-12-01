<?php

// Get the list of "calories" for each "elf"
$listOfElves = include("./part_1.php");

// Sort the list of "calories" for each "elf" in descending order
rsort($listOfElves);

// Get the 3 biggest "calories" from the list, combined
var_dump($listOfElves[0]+$listOfElves[1]+$listOfElves[2]);
