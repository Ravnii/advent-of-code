#load "part_1.csx"

using Internal;

public string part2() {
    return run(10000, (x, y, z) => x % modulus);
}

Console.WriteLine("Part 2: " + part2());
