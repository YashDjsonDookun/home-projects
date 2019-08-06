let name = 'Bruh';
let knowsJavaScript = true;

if (knowsJavaScript && name) {
    console.log(`Great, ${name}! Get ready to practice your JavaScript!`);
} else if (knowsJavaScript) {
    console.log(`Great! Get ready to practice your JavaScript!`);
} else if (name) {
    console.log(`Great, ${name}! Get ready to learn something new!`);
} else {
    console.log(`Great! Get ready to learn something new!`);
}
