using Internal;

public enum Operation { NOOP, ADDX }

public class Instruction {
    public Operation operation;
    public int value;
    public Instruction(Operation o, int v) {
        operation = o;
        value = v;
    }
}

public List<Instruction> program = new List<Instruction>();
public void parse(List<string> input) {
    foreach (string line in input) {
        string[] parts = line.Split(' ');
        int value = parts.Length > 1 ? int.Parse(parts[1]) : 0;
        program.Add(new Instruction(Enum.Parse<Operation>(parts[0].ToUpper()), value));
    }
}

public abstract class CPU {
    public int x = 1;
    public abstract void tick();
    public void execute(Instruction instruction) {
        switch (instruction.operation) {
            case Operation.NOOP:
                tick();
                break;
            case Operation.ADDX:
                tick();
                tick();
                x += instruction.value;
                break;
        }
    }
}

public class CPU1 : CPU {
    public int cycle = 20;
    public int strength = 0;
    public override void tick() {
        if (++cycle % 40  == 0) {
            strength += (cycle - 20) * x;
        }
    }
}

public string part1() {
    CPU1 cpu = new CPU1();
    foreach (Instruction instruction in program) {
        cpu.execute(instruction);
    }
    return cpu.strength.ToString();
}

List<string> input = File.ReadAllLines("./input.txt").ToList();

parse(input);

Console.WriteLine("Part 1: " + part1());
