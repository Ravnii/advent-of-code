#load "part_1.csx"

using Internal;

public string part2() {
    long max = 0;
    int len = data.Count;
    for (int i = 0; i < data.Count; i++) {
        for (int j = 0; j < data.Count; j++) {
            int tmp = 0, prod = 1;
            for (int k = i - 1; k >= 0; k--) { tmp++; if (data[k][j] >= data[i][j]) break; }
            prod *= tmp; tmp = 0;
            for (int k = i + 1; k < len; k++) { tmp++; if (data[k][j] >= data[i][j]) break; }
            prod *= tmp; tmp = 0;
            for (int k = j - 1; k >= 0; k--) { tmp++; if (data[i][k] >= data[i][j]) break; }
            prod *= tmp; tmp = 0;
            for (int k = j + 1; k < len; k++) { tmp++; if (data[i][k] >= data[i][j]) break; }
            prod *= tmp; tmp = 0;
            if (prod > max) max = prod;
        }
    }
    return max.ToString();
}

Console.WriteLine("Part 2: " + part2());
