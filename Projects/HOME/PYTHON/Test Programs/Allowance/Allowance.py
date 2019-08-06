for i in range(10):
    
    basic_salary = int(raw_input("Enter the basic Salary: "))
    number_of_children = int(raw_input("Enter the number of children: "))

    if number_of_children > 5:
        additional_allowance = 0.05 * basic_salary
        basic_salary += additional_allowance
        print basic_salary
    
    else:
        print basic_salary
    i += 1
