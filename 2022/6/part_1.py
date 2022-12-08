import collections

f = open("2022/6/input.txt", "r")

marker_to_be_processed = []
start = 0
end = 4

for line in f:
  chars = list(line.strip())
  while len(chars) > start:
    marker_to_be_processed = chars[start:end]
    duplicates = [item for item, count in collections.Counter(marker_to_be_processed).items() if count > 1]
    if len(duplicates) == 0:
      break
    start += 1
    end += 1

print('Marker: ', marker_to_be_processed, ' Start position: ', start, ' End position: ', end)
