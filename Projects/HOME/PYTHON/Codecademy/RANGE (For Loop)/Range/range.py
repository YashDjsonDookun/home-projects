def my_function(x):
  for i in range(0, len(x)):
    x[i] = x[i]
  return x

print my_function(range(0,100,5)) # Add your range between the parentheses!

#There are 3 types of ranges:

## range(6) # => [0, 1, 2, 3, 4, 5]

###  range(1, 6) # => [1, 2, 3, 4, 5]

####  range(1, 6, 3) # => [1, 4]
