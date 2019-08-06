print 'Please enter 5 digts.'
number_list = []

def numbers() :
    counter = 0

    for x in range(5):
        x = float(raw_input("Enter number here: "))
        number_list.append(x)

        if (x >= 100):
            counter += 1
    return counter

y = numbers()

print 'There is/are',y ,'number(s) greater than 100.'
    
