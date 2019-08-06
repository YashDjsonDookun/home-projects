let person = {
    name: 'Tyron',
    age: 40,
    weekendAlarm: 'No alarms needed',
    weekAlarm: 'Alarm set to 7AM',
    sayHello: () => {                    // This is one way of creating a method
        return "Hello, there!";
    },
    sayGoodbye() {                       // This is another way of creating a method (JavaScript version EC6)
      return 'Goodbye!';
    },
    hey_buddy: function() {                  // This is a function with a method in the array; it uses the .this keyword
      return `Hey ${this.name}, all good?`
    }  
  };

  person['hobbies'] = ['gaming', 'programming'];
  
  let day = 'Wednesday';
  let alarm;
  
  if (day === 'Saturday' || day === 'Sunday') {
    alarm = 'weekendAlarm';
  } else {
    alarm = 'weekAlarm'
  };
  
  console.log(person['name']);   /* lines 25 - 28  => printing keys/values from the array/list */
  console.log(person['age']);
  console.log(person[alarm]);
  console.log(person.hobbies);
  console.log(person.sayHello());    // printing methods from the array
  console.log(person.hey_buddy());
  console.log(person.sayGoodbye());  // printing methods from the array
