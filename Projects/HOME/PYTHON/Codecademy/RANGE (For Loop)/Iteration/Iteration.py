n = [3, 5, 7]

def total(numbers):
  result = 0
  for i in range(0,len(numbers)):
    result += numbers[i] ### This will update the varable result throughout the addition
  return result
print total(n)

### The output will be 15, since 3 + 5 + 7 = 15
