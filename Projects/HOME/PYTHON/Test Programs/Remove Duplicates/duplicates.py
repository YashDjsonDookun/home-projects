list_range = int(raw_input("Enter the range: "))  # Number of items in the list
x_list = []

for i in range(list_range):              # Adding items to the list
   z = int(raw_input("number in list: "))
   x_list.append(z)

def remove_duplicates(inputlist):
    if inputlist == []:
        return []
    
# Sort the input list from low to high    
    inputlist = sorted(inputlist)
# Initialize the output list, and give it the first value of the now-sorted input list
    outputlist = [inputlist[0]]

# Go through the values of the sorted list and append to the output list
# ...any values that are greater than the last value of the output list
    for i in inputlist:
        if i > outputlist[-1]:
            outputlist.append(i)
        
    return outputlist

print x_list   # Prints the full list
print remove_duplicates(x_list)  # Prints the updates list without any duplicates