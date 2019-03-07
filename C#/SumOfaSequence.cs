public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
    
    if (start > end) return 0;
    return start + SequenceSum(start + step, end, step);
     
   }
}
