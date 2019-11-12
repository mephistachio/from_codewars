using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    var bmi = Math.Round(weight / ( height * height ),1);
    return
      bmi <= 18.5 ? "Underweight" :
      bmi <= 25 ? "Normal" :
      bmi <= 30 ? "Overweight" : "Obese";
  }
}
