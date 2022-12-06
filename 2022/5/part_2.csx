#load "stacks_and_instructions.csx"

using Internal;

foreach (string instruction in instructions)
{
  string[] instructionTokens = instruction.Split(" ");
  int move = int.Parse(instructionTokens[1]);
  int from = int.Parse(instructionTokens[3]);
  int to = int.Parse(instructionTokens[5]);

  List<string> movedCrates = new List<string>();

  for (int i = 0; i < move; i++)
  {
    Stack<string> fromStack = getStack(from);
    Stack<string> toStack = getStack(to);

    movedCrates.Add(fromStack.Pop());

    if (i + 1 == move)
    {
      movedCrates.Reverse();
      foreach (string crate in movedCrates)
      {
        toStack.Push(crate);
      }
      movedCrates.Clear();
    }
  }
}

writeStackPeeks();
