<?php

// Get the list of "calories" for each "elf"
$listOfTotalCaloriesPerElf = include("./part_1.php");

// Sort the list of "calories" for each "elf" in descending order
rsort($listOfTotalCaloriesPerElf);

// Get the 3 biggest "calories" from the list, combined
echo PHP_EOL . "The 3 most calories combined: " . ($listOfTotalCaloriesPerElf[0]+$listOfTotalCaloriesPerElf[1]+$listOfTotalCaloriesPerElf[2]);
