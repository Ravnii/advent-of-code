using Internal;

// A = rock = 1 point;
// B = paper = 2 points;
// C = scissors = 3 points;

// X = lose = 0 points;
// Y = draw = 3 points;
// Z = win = 6 points;

// A X > C = 3 + 0 = 3
// A Y > A = 1 + 3 = 4
// A Z > B = 2 + 6 = 8

// B X > A = 1 + 0 = 1
// B Y > B = 2 + 3 = 5
// B Z > C = 3 + 6 = 9

// C X > B = 2 + 0 = 2
// C Y > C = 3 + 3 = 6
// C Z > A = 1 + 6 = 7

string[] rounds = File.ReadAllLines("./input.txt");

int score = 0;

foreach(string round in rounds)
{
  switch(round)
  {
    case "A X":
      score += 3;
      break;
    case "A Y":
      score += 4;
      break;
    case "A Z":
      score += 8;
      break;
    case "B X":
      score += 1;
      break;
    case "B Y":
      score += 5;
      break;
    case "B Z":
      score += 9;
      break;
    case "C X":
      score += 2;
      break;
    case "C Y":
      score += 6;
      break;
    case "C Z":
      score += 7;
      break;
    default:
      break; 
  }
}

Console.WriteLine("Your final score is: " + score.ToString());
