let randomNumbers = [375, 200, 3.14, 7, 13, 852];

let smallNumbers = randomNumbers.filter(randomNumbers => randomNumbers < 250); /* One way of doing it */
let favoriteWords = ['nostalgia', 'hyperbole', 'fervent', 'esoteric', 'serene'];

let longFavoriteWords = favoriteWords.filter(function(word) {  /* Another way of using the .filter() method */
  return word.length > 7;
});
