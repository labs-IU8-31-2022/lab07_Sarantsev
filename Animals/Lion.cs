namespace Animals;

[NewAttribute("Lion is an Animal")]
public class Lion : Animal
{
    public Lion() {}
    
    public Lion(string country, string name, bool hideFromOtherAnimal, eClassificationAnimal type) : base(country, name,
        hideFromOtherAnimal, type) {}
 
    public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Meat;
    
    public override void SayHello() => Console.WriteLine("Hello from lion");
}