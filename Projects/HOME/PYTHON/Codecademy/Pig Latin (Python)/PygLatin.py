print ("Welcome to the Pyg Latin Translator!")

pyg = "ay"
original = raw_input("Enter a word: ")

if (len(original) > 0) and (original.isalpha()):
    word = original.lower()
    first = word[0]
    new_word = word + first + pyg
    new_word = new_word[1:] #This will slice the word obtained, therefore, return everything starting the the 1st position. for e.g, boy --> oy
    print (new_word)
else:
    print ("Empty")
