#### To print even numbers from 1 to 10 (inclusive)

def even(x):
    for i in range(0, len(x)):
        x[i] = x[i]
        return x
        
print even(range(2,11,2))


#### Alternatively, we could use: 

evens_to_50 = [i for i in range(51) if i % 2 == 0]   
print evens_to_50

####### uncomment lines 13 and 14 to print all even numbers from 0 to 50.