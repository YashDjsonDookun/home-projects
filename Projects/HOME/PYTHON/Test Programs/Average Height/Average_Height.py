#### Calculate and Display the Average Height of 5 persons

height = []

def Average():
    mean = 0
    for count in range(5):
        x = float(raw_input("Enter Height here: "))
        height.append(x)
        count += 1
    print height
    print "Number:", count
    mean = sum(height) / count
    return mean
print ("The average height is" ,Average())

    
