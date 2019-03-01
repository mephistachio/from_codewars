using System;
public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n)
    {
        foreach (var item in signature)
        {
            Console.Write(item.ToString() + ", ");
        }
        Console.WriteLine();

        Console.WriteLine(n);

        if (n == 0) return new double[0];
        if (n < 3)
        {
            Array.Resize(ref signature, n);
            return signature;
        }

        if (signature.Length < 3) return signature;

        int length = signature.Length;
        for (int i = 0; i < n - length; i++)
            signature = Tribonacci(signature);

        return signature;
    }

    public static double[] Tribonacci(double[] signature)
    {
        double[] newSignature = new double[signature.Length + 1];
        double sum = 0;
        signature.CopyTo(newSignature, 0);
        for (int i = signature.Length - 1; i > signature.Length - 4; i--)
        {
            sum = sum + signature[i];
        }
        newSignature[newSignature.Length - 1] = sum;
        return newSignature;
    }
}
