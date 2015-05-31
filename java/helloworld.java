/*---------------------------------------------------
 * Name:        HelloWorld
 * Purpose:     Practice
 * version:     1.0
 * Author:      Kosei.A
 *
 * Created:     26/5/2015
 * Copyright:   Kosei.A
 * Licence:     your licence
 *--------------------------------------------------- */

package jp.kosei.atl.sample;

public class helloworld {

	public static void main(String[] args) {

		 System.out.println("----- 1.1 only 1 time -----");
		 System.out.println("Hello World");
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.2 loop 5 times -----");
		 for (int i = 0; i < 5 ; i++){
			 System.out.println("Hello World");
		 }
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.3 print each characters -----");
		 String str = "Hello World";
		 for (int i = 0; i < str.length(); i++){
		    char c = str.charAt(i);
		    System.out.println(c);
		 }
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.4 print [l] character only -----");
		 for (int i = 0; i < str.length(); i++){
			    char c = str.charAt(i);
			    if (c == 'l'){
			    	System.out.println(c);
			    }
		 }
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.5 print first 4 characters -----");
		 System.out.println(str.substring(0,4));
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.6 print last 4 characters -----");
		 System.out.println(str.substring(str.length()-4));
		 System.out.println("----- End -----\r\n");

		 System.out.println("----- 1.7 print 4 characters from [W] -----");
		 int index = str.indexOf("W");
		 System.out.println(str.substring(index,index+4));
		 System.out.println("----- End -----\r\n");


	}

}
