namespace Animals;

[NewAttribute("Pig is an Animal")]
public class Pig: Animal
{
    public Pig() {}
    
    public Pig(string country, string name, bool hideFromOtherAnimal, eClassificationAnimal type) : base(country, name,
        hideFromOtherAnimal, type) {}
    public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Everything;
    
    public override void SayHello() => Console.WriteLine("Hello from pig");
}