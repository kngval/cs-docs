namespace cs_docs.ValueTypes;

public class ValueTypes
{
    public struct MutablePoint
    {
        public int X;
        public int Y;
        public MutablePoint(int x, int y) => (X, Y) = (x, y);
        public override string ToString() => $"({X},{Y})";
    }

    public static void MutableTest()
    {

        var p1 = new MutablePoint(1, 2);
        var p2 = new MutablePoint(50, 30);
        p1 = p2;
        p1.X = 100;
        Console.WriteLine("p1 : " + p1);
        Console.WriteLine("p2 : " + p2);
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified : {p1}");
        Console.WriteLine($"{nameof(p2)} : {p2}"); // should output (50,30)

        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after mutating X : {p2}"); //should output (50,30)
    }

    private static void MutateAndDisplay(MutablePoint p)
    {
        p.X = 100;
        Console.WriteLine($"Point mutated : {p}");
    }
}
