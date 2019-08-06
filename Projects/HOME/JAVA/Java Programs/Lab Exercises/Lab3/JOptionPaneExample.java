/*
 * Author: Yash Djson Dookun
 * Purpose: Illustrating the use of JOptionPane
*/
import javax.swing.JOptionPane;

class JOptionPaneExample{
	public static void main(String arg[]){
	String Response, Message;

	Response = JOptionPane.showInputDialog("Enter your name:");
	Message = ("The user's name is " + Response);
		JOptionPane.showMessageDialog(null, Message);
	}
}
