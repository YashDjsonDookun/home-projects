
lst = []

def bubble() :
    print ('Enter the number of digits for the list')
    print
    x = int(input("Length of list: "))
    print

    for count in range(x):
        num = float(input("Enter digit here: "))
        lst.append(num)
        count += 1
        print
    print ('Your list:',lst)


    for i in range(len(lst)-1,0,-1):
        for j in range(i):
            temp = []
            if lst[j]>lst[j+1]:
                temp = lst[j]
                lst[j] = lst[j+1]
                lst[j+1] = temp
bubble()
print ('Sorted list:',lst)


def TryAgain():
    response = str(input("Add additional numbers to the list? [Y/N]: "))
    response.upper

    if response == 'y':
       bubble()
       print ('Final Sorted list:',lst)
       TryAgain()
    elif response == 'n':
        print ('Goodbye!')
        StopIteration
    else:
        print ('Invalid Response! Try Again!')
        TryAgain()
TryAgain()
