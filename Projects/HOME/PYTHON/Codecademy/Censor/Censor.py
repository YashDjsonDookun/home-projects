text_input = str(raw_input("Enter your text here: "))
word_input = str(raw_input("Enter your word here: "))

def censor(text, word):
    words = text.split()
    result = ''
    stars = '*' * len(word)
    count = 0

    for i in words:
        if i == word:
            words[count] = stars
        count += 1
    result = ' '.join(words)

    return result

print censor(text_input, word_input)
