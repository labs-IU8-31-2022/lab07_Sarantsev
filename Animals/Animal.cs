namespace Animals;

public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}
    
public enum eFavouriteFood
{
    Meat,
    Plants,
    Everything
}

[NewAttribute("abstract class")]
public abstract class Animal
{
    //properties
    public string Country { get; set; }
    public string Name { get; set; }
    public bool HideFromOtherAnimal { get; set; }
    public eClassificationAnimal WhatAnimal;

    public Animal() {}

    public Animal(string country, string name, bool hideFromOtherAnimal, eClassificationAnimal type) =>
        (Country, Name, HideFromOtherAnimal, WhatAnimal) = (country, name, hideFromOtherAnimal, type);

    public void Deconstruct(out string country, out string name, out bool hideFromOtherAnimal,
        out eClassificationAnimal type) => (country, name, hideFromOtherAnimal, type) =
        (Country, Name, HideFromOtherAnimal, WhatAnimal);

    public eClassificationAnimal GetClassificationAnimal() => WhatAnimal;

    public abstract eFavouriteFood GetFavouriteFood();

    public abstract void SayHello();
}