//Create a custom Dog class
class Dog extends Animal {

//Using instance variables to model our Car class after a real-life car
int age;
/*The class constructor for the Dog class*/
/*Use instance variables to model our Car class after a real-life car*/
public Dog(int dogsAge) {

  age = dogsAge;

}
public void bark() {
  System.out.println("Woof!");
}
public void run(int feet) {
  System.out.println("Your dog ran " + feet + " feet!");
}
public int getAge() {
 return age;
}
	public static void main(String[] args) {
Dog spike = new Dog(5);
spike.bark();

spike.run(10);

int spikeAge = spike.getAge();

System.out.println(spikeAge);

spike.checkStatus();
	}
}














/* A class is a set of instructions that describe how a data structure should behave.
Java provides us with its own set of pre-defined classes, but we are also free to create our own custom classes.

  - A class constructor will allow us to create Dog instances. With a class constructor, we can set some information about the Dog.
  - If we do not create a class constructor, Java provides one that does not allow you to set initial information.

  When we create a new class, we probably have specific details that we want the class to include. We save those specific details into instance variables.*/


/*By adding a class constructor and creating instance variables, we will soon be able to use the Dog class. However, the class constructor Dog is still empty.
Let's modify this by adding parameters to the Dog constructor.

You can think of parameters like options at an ice cream store. You can choose to order a traditional ice cream cone, but other times you may want to specify
the size of the cone or the flavor of the ice cream.

For the Dog class, we can specify the initial dog age by adding parameters to the class constructor.
    -Parameters allow data types to be created with specified attributes.
*/

/* A method is a pre-defined set of instructions. Methods are declared within a class.
Java provides some pre-defined methods available to all classes, but we can create our own as well. */


/* The void keyword indicates that no value should be returned by the method after it executes all the logic in the method.
If we do want the method to return a value after it finishes running, we can specify the return type.

The void keyword (which means "completely empty") indicates to the method that no value is returned after calling that method.
Alternatively, we can use data type keywords (such as int, char, etc.) to specify that a method should return a value of that type. */
