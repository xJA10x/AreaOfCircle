/*****************************************

Abstract Area class.

******************************************/

// Notes:

  // Program to find area of circle using OOP principals.

  // Abstract classes can only be inheritance.
  // You cannot create an instance from an abstract class.

  // Abstract methods can only be overriden in the base class,
  // they cannot be implemented on the base class.

  namespace MyProgram {

    public abstract class Area {

      // Builds method.
      // Takes one parameter,
      // variable radius in the main class.
      public abstract double findArea(double[] radius);

    }

  }
