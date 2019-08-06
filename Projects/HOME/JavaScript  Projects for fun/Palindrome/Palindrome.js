function word(PalindromeWord) {
	
	let palindrome = PalindromeWord.split('').reverse().join('');

	if (PalindromeWord == palindrome ) {
		console.log("True");
	}
	else {
			console.log("False");
	}
}
