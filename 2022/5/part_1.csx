#load "stacks_and_instructions.csx"

using Internal;

foreach (string instruction in instructions)
{
  string[] instructionTokens = instruction.Split(" ");
  int move = int.Parse(instructionTokens[1]);
  int from = int.Parse(instructionTokens[3]);
  int to = int.Parse(instructionTokens[5]);

  for (int i = 0; i < move; i++)
  {
    Stack<string> fromStack = getStack(from);
    Stack<string> toStack = getStack(to);

    toStack.Push(fromStack.Pop());

  }
}

writeStackPeeks();
