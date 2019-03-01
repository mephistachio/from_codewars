using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string AbbrevName(string name)
    {
        var namelname = name.ToUpper().Split(' ');
        Console.WriteLine(String.Join(".", namelname[0][0], namelname[1][0]));
        return String.Join(".", namelname[0][0], namelname[1][0]);
    }
}
