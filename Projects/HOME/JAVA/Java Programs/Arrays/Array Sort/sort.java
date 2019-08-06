import java.util.Arrays;
public class sort {
	public static void main(String[] args) {
		 int intArr[] = {55,55,55,55,55};

		 System.out.println("The unsorted array is: ");
		 for (int number : intArr) {
		 	System.out.println("Number =  " + number);
		 }

		 Arrays.sort(intArr);

		 System.out.println("The sorted array is: ");
		 for (int number : intArr) {
		 	System.out.println("Number =  " + number);
		 }

		 int searchVal = 55;
		 int retVal = Arrays.binarySearch(intArr, searchVal);
		 System.out.println("The index of element 12 is: " + retVal);
	}
}
// public class sort {
//    public static void main(String args[]){
//       int array[] = {55, 55, 55, 40, 55, 55};
//       int size = array.length;
//       int value = 55;

//       for (int i=0 ;i< size; i++){
//          if(array[i]==value){
//             System.out.println("Element found index is :"+ i);
//          }else{
//             System.out.println("Element not found");
//          }
//       }
//    }
// }