import fs from 'fs';

const input = fs.readFileSync('input.txt', 'utf8');

let result = 0;

input.split(/\r?\n/).forEach(line =>  {
  let ranges = line.split(',').map(range => range.split('-').map(Number));

  const rangeOne = ranges[0];
  const rangeTwo = ranges[1];

  if (rangeOne[0] <= rangeTwo[0] && rangeOne[1] >= rangeTwo[1]) {
    result += 1;
  } else if (rangeTwo[0] <= rangeOne[0] && rangeTwo[1] >= rangeOne[1]) {
    result += 1;
  }
});

console.log(result);
