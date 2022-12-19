#load "part_1.csx"

using Internal;

public string part2() {
    HashSet<int> visited = new HashSet<int>();
    Snake head = new Snake(null, (x,y) => visited.Add(y*1000+x));
    for (int i = 0; i < 9; i++) head = new Snake(head);
    for (int i = 0; i < data.Length; i += 2) head.move(data[i], data[i+1]);
    return visited.Count.ToString();
}

Console.WriteLine("Part 2: " + part2());
