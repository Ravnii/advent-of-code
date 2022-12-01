<?php

// Read the file line by line
$handle = fopen("./input.txt", "r");

$i = 0;
$result = [];

while (($line = fgets($handle)) !== false) {

  // Incase of line explicitly containing 0
  if ($line === "0") {
    continue;
  }

  // New line, representing a new "elf"
  if (intval($line) === 0) {
    $i++;
    continue;
  }

  // "Calories" added to a specific "elf"
  $result[$i][] = intval($line);
    
}

fclose($handle);

// Calculate the total "calories" for each "elf"
foreach ($result as $key => $value) {
  $result[$key] = array_sum($value);
}

// Find the "elf" with the most "calories"
$biggest = max($result);

var_dump($biggest);

return $result;
