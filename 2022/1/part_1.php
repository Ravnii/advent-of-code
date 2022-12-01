<?php

// Read the file calories by calories
$theList = fopen("./input.txt", "r");

$elfNumber = 0;
$listOfElves = [];

while (($calories = fgets($theList)) !== false) {

  // Incase of calories explicitly containing 0
  if ($calories === "0") {
    continue;
  }

  // New line, representing a new "elf"
  if (intval($calories) === 0) {
    $elfNumber++;
    continue;
  }

  // "Calories" added to a specific "elf"
  $listOfElves[$elfNumber][] = intval($calories);
    
}

fclose($theList);

// Calculate the total "calories" for each "elf"
foreach ($listOfElves as $elf => $listOfCalories) {
  $listOfElves[$elf] = array_sum($listOfCalories);
}

// Find the "elf" with the most "calories"
$biggest = max($listOfElves);

var_dump($biggest);

return $listOfElves;
