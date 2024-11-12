
public class Tuple
{
    public static void CreateTuple()
    {
      // using CustomTuple = (string s, double d);
        (int, string, float) t1 = (5, "hi", 1.2f);
        Console.WriteLine($"{t1.Item1} {t1.Item2}, {t1.Item3}");
    }

    public static (int min, int max) ReturnTuple(int[] arr)
    {
      if(arr.Length <= 0){
        throw new ArgumentException("Array has no elements.");
      }
      int min = int.MaxValue;
      int max = int.MinValue;

      for(int i = 0; i < arr.Length; i++){
        if(arr[i] < min){
          min = arr[i];
        }
        if(arr[i] > max){
          max = arr[i];
        }
      }
      return (min,max);
    }
}
