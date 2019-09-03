/**********************************

AreaTest class

**********************************/

using System;

namespace MyProgram {

  public class AreaTest {

    public static void Main(String[] args) {

      Console.WriteLine("");
      Console.WriteLine("####################### Running Program ##########################");
      Console.WriteLine("");

      // Builds object from the AreaTwo
      // class in order to have access to variables
      // and methods.
      AreaTwo aObj = new AreaTwo();

       // Initiales array.
       double[] radius = {0};
       int control;
       double theR;

       // Prompts user.
       Console.Write("Please enter -1 to quit program or else any other key to run program: ");
       control = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("");

       while(control != -1) {

         // Prompts user.
         Console.Write("Enter radius of circle: ");
         radius[0] = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("");

         // Method call
         // using object name.
         // Takes one parameter,
         // stores output in the variable theR.
         theR = aObj.findArea(radius);

         Console.WriteLine("The area of the circle with a radius of " + radius[0] + " is " + theR);

         // Promtps user.
         Console.Write("Enter -1 to quit program: ");
         control = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine();

       }

      Console.WriteLine("");
      Console.WriteLine("####################### Exiting Program ###########################");
      Console.WriteLine("");

      Console.ReadKey();


    }

  }

}
