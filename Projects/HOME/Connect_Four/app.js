$(window).ready(function() {
	const Player1 = prompt(`Player One, Enter your name... you'll be blue`);
	const Player2 = prompt(`Player Two, Enter your name... you'll be red`);
	let isPlayer1Turn = true;
	let isPlayer2Turn = false;
	const red = 'rgb(217, 37, 37)';
	const blue = 'rgb(0, 90, 254)';
	const defaultColor = 'rgb(106, 106, 106)';
	const Player1Hint = "it is your turn, please pick a column to drop your blue chip";
	const Player2Hint = "it is your turn, please pick a column to drop your red chip";
	var positionID;
	var columnID;
	var column;
	var currentPlayer = 1;
	let hasWon = false;

	gameStart();

	function gameStart() {
		swapHints();
		$('#player').text(Player1);
		$('#playerText').text(Player1Hint);
	}	

	function swapHints () {
		$(".hint1").hide();
		$(".hint2").show();
	}

	$('.gameButtons').on('click', function() {
		positionID = $(this).get(0).id;
		columnID = $('#' + positionID + ' button').last();
		// console.table(columnID);
		// console.table(positionID);
		nextChip();

		verticalWin();
		horizontalWin();
		verticalWin();
	});

	function PlayerOneTurn() {
		$('#player').text(Player1);
		$('#playerText').text(Player1Hint);
		addChip(blue);
		isPlayer1Turn = false;
		isPlayer2Turn = true;
		$('#player').text(Player2);
		$('#playerText').text(Player2Hint);
	}

	function PlayerTwoTurn() {
		$('#player').text(Player2);
		$('#playerText').text(Player2Hint);
		addChip(red);
		isPlayer2Turn = false;
		isPlayer1Turn = true;
		$('#player').text(Player1);
		$('#playerText').text(Player1Hint);
	}

	function addChip(color) {
		columnID.css('background-color', color);
		console.log(columnID);
	}

	function nextChip() {
		if ($(columnID).css('background-color') == defaultColor){
			if (isPlayer1Turn){
				PlayerOneTurn();
			}
			else if (isPlayer2Turn) {
				PlayerTwoTurn();
			}
		}
		else {
			nextRow();
		}
	}

	function nextRow() {
		columnID = columnID.prev();
		if ($(columnID).css('background-color') == defaultColor){
			if (isPlayer1Turn){
				PlayerOneTurn();
			}
			else if (isPlayer2Turn) {
				PlayerTwoTurn();
			}	
		}
		else {
			nextRow();
		}
	}
	//TODO
	function horizontalWin() {

	}

	function verticalWin() {
		var colorCheck = columnID.css('background-color');
		var nextColor1 = columnID.next().css('background-color');
		var nextColor2 = columnID.next().next().css('background-color');
		var nextColor3 = columnID.next().next().next().css('background-color');
		
		if (colorCheck == nextColor1  && colorCheck == nextColor2 && colorCheck == nextColor3){
			winner();
		}
	}
	//TODO
	function diagonalWin() {

	}

	function winner() {
		$('.hint2').hide();
		$('.hint3').show();
		if (!isPlayer1Turn){
			$('.hint3 span').text(Player1);
		}
		else {
			$('.hint3 span').text(Player2);
		}
	}
});