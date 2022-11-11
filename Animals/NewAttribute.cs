using System.Reflection;

namespace Animals;

public class NewAttribute: Attribute
{
    public string Comment { get; }
    public NewAttribute(string comment) => Comment = comment;
}