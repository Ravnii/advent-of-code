#load "part_1.csx"

using Internal;

public class CPU2 : CPU {
    public int cycle = 0;
    public StringBuilder sb = new StringBuilder();
    public override void tick() {
        if (cycle % 40 == 0) {
            sb.Append('\n');
        }
        int posx = cycle++ % 40;
        if (posx == x || posx == x - 1 || posx == (x + 1) % 40) {
            sb.Append('█');
        } else {
            sb.Append(' ');
        }
    }
}

public string part2() {
    CPU2 cpu = new CPU2();
    foreach (Instruction instruction in program) {
        cpu.execute(instruction);
    }
    return cpu.sb.ToString();
}

Console.WriteLine("Part 2: " + part2());
