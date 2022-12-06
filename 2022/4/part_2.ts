import fs from 'fs';

const input = fs.readFileSync('input.txt', 'utf8');

let result = 0;

input.split(/\r?\n/).forEach(line =>  {
  let ranges = line.split(',').map(range => range.split('-').map(Number));

  const rangeOne = ranges[0];
  const rangeTwo = ranges[1];

  const expandedRangeOne: number[] = [];
  const expandedRangeTwo: number[] = [];

  for (let i = rangeOne[0]; i <= rangeOne[1]; i++) {
    expandedRangeOne.push(i);
  }

  for (let i = rangeTwo[0]; i <= rangeTwo[1]; i++) {
    expandedRangeTwo.push(i);
  }

  const intersection = expandedRangeOne.filter(x => expandedRangeTwo.includes(x));

  if (intersection.length > 0) {
    result += 1;
  }

});

console.log(result);