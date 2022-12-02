using Internal;

// A = rock
// B = paper
// C = scissors

// X = rock = 1 point;
// Y = paper = 2 points;
// Z = scissors = 3 points;

// Loose = 0 points;
// Draw = 3 points;
// Win = 6 points;

// A == X : 1 + 3 = 4
// A < Y  : 2 + 6 = 8
// A > Z  : 3 + 0 = 3

// B > X  : 1 + 0 = 1
// B == Y : 2 + 3 = 5
// B < Z  : 3 + 6 = 9

// C < X  : 1 + 6 = 7
// C > Y  : 2 + 0 = 2
// C == Z : 3 + 3 = 6


string[] rounds = File.ReadAllLines("./input.txt");
int score = 0;

foreach(string round in rounds)
{
  switch(round)
  {
    case "A X":
      score += 4;
      break;
    case "A Y":
      score += 8;
      break;
    case "A Z":
      score += 3;
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
      score += 7;
      break;
    case "C Y":
      score += 2;
      break;
    case "C Z":
      score += 6;
      break;
    default:
      break;
  }
}

Console.WriteLine("Your final score is: " + score.ToString());
