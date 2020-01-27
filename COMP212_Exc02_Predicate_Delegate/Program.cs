using System;

/*This Assignment is for COMP 212- Prof Sujeet Lohan
 * Excercise 02
 * TASKS:
  * 1- Define a student's grade array having at least 10 double values between 10 and 100. Define a 
  * delegate GradesPredicate which takes one input of type double and returns a bool.
  */
namespace COMP212_Exc02_Predicate_Delegate
{
    //delcaring the delegate
    public delegate bool GradesPredicate(double grade);
    class Program
    {
        static void Main(string[] args)
        {
            double[] studentGrades = {63.1, 69.75, 77.8,79.12, 81.99,86.89, 89.12, 92.99, 96.22, 98.19 };
            

        }
    }
}
