
public class EnumType {
  enum Planets {
    Mercury,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune
  }

  public static void DisplayPlanet(){
    foreach(Planets planet in Enum.GetValues(typeof(Planets))){
      Console.WriteLine(planet);
    }

    foreach(int planetIndex in Enum.GetValues(typeof(Planets))){
      Console.WriteLine($"{planetIndex}");
    }
  }
}
