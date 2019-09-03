/**************************************

AreaTwo class

****************************************/


namespace MyProgram {


  public class AreaTwo : Area {

    // Method call.
    // Takes one parameter,
    // overrides abstract method.
    public override double findArea(double[] radius) {

      // Returns area of circle.
      return radius[0] * radius[0] * 3.14;

    }

  }

}
