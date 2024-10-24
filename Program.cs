using cs_docs.ValueTypes;
public class Program {

  public static void Main(){
    var p1 = new MutablePoint(1,2);
    var p2 = p1;
    p2.Y = 200;
    Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified : {p1}");
    Console.WriteLine($"{nameof(p2)} : {p2}"); // should output (1,200)
    
    MutateAndDisplay(p2);
    Console.WriteLine($"{nameof(p2)} after mutating X : {p2}"); //should output (100,200)
  }
  private static void MutateAndDisplay(MutablePoint p){
    p.X = 100;
    Console.WriteLine($"Point mutated : {p}");
  }
}
