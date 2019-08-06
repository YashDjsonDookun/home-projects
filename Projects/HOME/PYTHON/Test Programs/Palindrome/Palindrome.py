print ('This is a simple python program to test if a word is a Palindrome')
print

x = str(input("Enter the word that you want to verify: "))

PalindromeWord = x[::-1] #used to reverse

if PalindromeWord == x:
	print('True')
else:
	print('False')


