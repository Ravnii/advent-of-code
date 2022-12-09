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

  // Empty line, representing a new "elf"
  if (intval($calories) === 0) {
    $elfNumber++;
    continue;
  }

  // "Calories" added to a specific "elf"
  $listOfElves[$elfNumber][] = intval($calories);

}

fclose($theList);

$listOfTotalCaloriesPerElf = [];
// Calculate the total "calories" for each "elf"
foreach ($listOfElves as $elf => $listOfCalories) {
  $listOfTotalCaloriesPerElf[$elf] = array_sum($listOfCalories);
}

// Find the "elf" with the most "calories"
$mostCalories = max($listOfTotalCaloriesPerElf);

echo "Most calories for an elf: " . $mostCalories;

return $listOfTotalCaloriesPerElf;
