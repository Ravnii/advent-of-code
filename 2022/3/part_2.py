import part_1

f = open("3/input.txt", "r")

lines = []

for line in f:
  lines.append(line.strip())

f.close()

def set_result(lines):
  first_line = lines[0]
  second_line = lines[1]
  third_line = lines[2]

  for char in first_line:
    if char in second_line and char in third_line:
      return char

three_lines = []
result = []
i = 1

for line in lines:
  three_lines.append(line)

  if i%3 == 0:
    result.append(set_result(three_lines))
    three_lines = []
    
  i = i + 1

sum = 0;
for char in result:
  if char in part_1.priority:
    sum += part_1.priority[char]

print(sum)
