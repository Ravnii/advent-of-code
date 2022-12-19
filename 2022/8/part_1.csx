using Internal;

public List<int[]> data = new List<int[]>();
public void parse(List<string> input) {
    foreach (var s in input) {
        int[] arr = new int[s.Length];
        for (int i = 0; i < s.Length; i++) arr[i] = s[i] - '0' + 1;
        data.Add(arr);
    }
}

public string part1() {
    int sum = 0; int dim = data.Count - 1;
    List<int[]> visible = new List<int[]>();
    foreach (var s in data) visible.Add(new int[data[0].Length]);
    for (int i = 0; i < data.Count; i++) {
        int maxlr = 0, maxrl = 0, maxtb = 0, maxbt = 0;
        for (int j = 0; j < data.Count; j++) {
            if (data[i][j] > maxlr) { maxlr = data[i][j]; visible[i][j] = 1; }
            if (data[i][dim - j] > maxrl) { maxrl = data[i][dim - j]; visible[i][dim - j] = 1; }
            if (data[j][i] > maxtb) { maxtb = data[j][i]; visible[j][i] = 1; }
            if (data[dim - j][i] > maxbt) { maxbt = data[dim - j][i]; visible[dim - j][i] = 1; }
        }
    }
    for (int i = 0; i < data.Count; i++) for (int j = 0; j < data.Count; j++) sum += visible[i][j];
    return sum.ToString();
}

List<String> input = File.ReadAllLines("./input.txt").ToList();

parse(input);

Console.WriteLine("Part 1: " + part1());
