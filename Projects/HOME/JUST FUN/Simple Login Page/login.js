// Loop through Array of objects
var objPeople = [
	{ // Object at index 0
		Username: "Yash",
		Password: "Password"
	},

	{ //Object at index 1
		Username: "Poonam",
		Password: "Password"
	},

	{ //Object at index 2
		Username: "Randy",
		Password: "Password"
	}
];

function	getInfo() {
	let Username = document.getElementById('Username').value;
	let Password = document.getElementById('Password').value;

	for(let i=0; i < objPeople.length; i++) {
		// Check if the user input matches the Username and Passord of the current index of the ObjPeople Array

		if(Username == objPeople[i].Username && Password == objPeople[i].Password) {
			console.log(Username + " is logged in!!");
			//stop the funtion if this is found to be true
			return
		}
	}
		
	console.log("Incorrect Username or Password!");
}