using System;
using System.Collections.Generic;

public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    r = Math.Min(Math.Max(r, 0), 255);
    g = Math.Min(Math.Max(g, 0), 255);
    b = Math.Min(Math.Max(b, 0), 255);
 
   return (r.ToString("X2")+g.ToString("X2")+b.ToString("X2")).ToUpper();

  }
  
  
}
