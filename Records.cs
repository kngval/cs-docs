
public class Records
{
    public record Person(string FirstName, string LastName);


    public static void DisplayPerson()
    {
      Person p1 = new Person("Brent","Valino");
      Person p2 = p1;
      p2.FirstName = "Test";
      Console.WriteLine(p2);
      Console.WriteLine(p1);
    }
}
