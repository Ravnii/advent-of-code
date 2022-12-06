using Internal;
using System.Collections.Generic;

Stack<string> stackOne = new Stack<string>(new string[] {"D", "L", "V", "T", "M", "H", "F"});
Stack<string> stackTwo = new Stack<string>(new string[] {"H", "Q", "G", "J", "C", "T", "N", "P"});
Stack<string> stackThree = new Stack<string>(new string[] {"R", "S", "D", "M", "P", "H"});
Stack<string> stackFour = new Stack<string>(new string[] {"L", "B", "V", "F"});
Stack<string> stackFive = new Stack<string>(new string[] {"N", "H", "G", "L", "Q"});
Stack<string> stackSix = new Stack<string>(new string[] {"W", "B", "D", "G", "R", "M", "P"});
Stack<string> stackSeven = new Stack<string>(new string[] {"G", "M", "N", "R", "C", "H", "L", "Q"});
Stack<string> stackEight = new Stack<string>(new string[] {"C", "L", "W"});
Stack<string> stackNine = new Stack<string>(new string[] {"R", "D", "L", "Q", "J", "Z", "M", "T"});

Stack<string>[] allStacks = new Stack<string>[] {stackOne, stackTwo, stackThree, stackFour, stackFive, stackSix, stackSeven, stackEight, stackNine};

string[] instructions = File.ReadAllLines("./input.txt");

public Stack<string> getStack(int stackNumber)
{
  switch (stackNumber)
  {
    case 1:
      return stackOne;
    case 2:
      return stackTwo;
    case 3:
      return stackThree;
    case 4:
      return stackFour;
    case 5:
      return stackFive;
    case 6:
      return stackSix;
    case 7:
      return stackSeven;
    case 8:
      return stackEight;
    case 9:
      return stackNine;
    default:
      return null;
  }
}

public void writeStackPeeks()
{
  foreach (Stack<string> stack in allStacks)
  {
    Console.Write(stack.Peek());
  }
}
