namespace Animals;

[NewAttribute("Cow is an Animal")]
public class Cow : Animal
{
    public Cow() {}

    public Cow(string country, string name, bool hideFromOtherAnimal, eClassificationAnimal type) : base(country, name,
        hideFromOtherAnimal, type) {}
    
    public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Plants;
    
    public override void SayHello() => Console.WriteLine("Hello from cow");

}