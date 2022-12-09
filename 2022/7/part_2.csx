#load "part_1.csx"

using Internal;

public string part2() {
    long freeSpace = 70000000 - allNodes[0].size;
    long minNeeded = 30000000 - freeSpace;
    long min = allNodes[0].size;
    foreach (Node n in allNodes) if (n.size < min && n.size > minNeeded) min = n.size;
    return min.ToString();
}

Console.WriteLine("Part 2: " + part2());
