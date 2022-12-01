<?php

$handle = fopen("./input.txt", "r");

$result = [];

if ($handle) {

    $i = 0;

    while (($line = fgets($handle)) !== false) {

      if ($line == "0") {
        continue;
      }

      if (intval($line) === 0) {
        $i++;
        continue;
      }

      $result[$i][] = intval($line);
        
    }

    fclose($handle);
}

foreach ($result as $key => $value) {
  $result[$key] = array_sum($value);
}

$biggest = max($result);

var_dump($biggest);

return $result;
