using System;
using System.Text;

public class Kata
{
  public static string BreakCamelCase(string str)
   {
          var result = new StringBuilder();

            result.Append(str[0]);
            for (var i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    result.Append(' ');
                }
                result.Append(str[i]);

            }
            return result.ToString();
   
    }

   
}
