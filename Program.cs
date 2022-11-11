using System.Reflection;
using System.Xml.Schema;
using System.Xml.Serialization;
using Animals;
namespace lab07;

public class Program
{
    public async static Task Main(string[] args)
    {
         Console.WriteLine("Animal");
         Type animal_type = typeof(Animal);
         foreach (var animal_members in animal_type.GetMembers())
         {
             Console.WriteLine($"{animal_members.DeclaringType} {animal_members.MemberType} {animal_members.Name}");
         }

         object[] animal_attribute = animal_type.GetCustomAttributes(false);
         foreach (var attr in animal_attribute)
         {
             if (attr is NewAttribute own_attr)
             {
                 Console.WriteLine("Attribute is: ");
                 Console.WriteLine(own_attr.Comment);
             }
         }
         Console.WriteLine();
         
         Console.WriteLine("Cow");
         Type cow_type = typeof(Cow);
         foreach (var cow_members in cow_type.GetMembers())
         {
             Console.WriteLine($"{cow_members.DeclaringType} {cow_members.MemberType} {cow_members.Name}");
         }

         object[] cow_attribute = cow_type.GetCustomAttributes(false);
         foreach (var attr in cow_attribute)
         {
             if (attr is NewAttribute own_attr)
             {
                 Console.WriteLine("Attribute is: ");
                 Console.WriteLine(own_attr.Comment);
             }
         }
         Console.WriteLine();
         
         Console.WriteLine("Lion");
         Type lion_type = typeof(Lion);
         foreach (var lion_members in lion_type.GetMembers())
         {
             Console.WriteLine($"{lion_members.DeclaringType} {lion_members.MemberType} {lion_members.Name}");
         }

         object[] lion_attribute = lion_type.GetCustomAttributes(false);
         foreach (var attr in lion_attribute)
         {
             if (attr is NewAttribute own_attr)
             {
                 Console.WriteLine("Attribute is: ");
                 Console.WriteLine(own_attr.Comment);
             }
         }
         Console.WriteLine();
         
         Console.WriteLine("Pig");
         Type pig_type = typeof(Pig);
         foreach (var pig_members in pig_type.GetMembers())
         {
             Console.WriteLine($"{pig_members.DeclaringType} {pig_members.MemberType} {pig_members.Name}");
         }

         object[] pig_attribute = pig_type.GetCustomAttributes(false);
         foreach (var attr in pig_attribute)
         {
             if (attr is NewAttribute own_attr)
             {
                 Console.WriteLine("Attribute is: ");
                 Console.WriteLine(own_attr.Comment);
             }
         }
         Console.WriteLine();
         
         
         var schema = new XmlSchemas();
         var exporter = new XmlSchemaExporter(schema);
         var mapping = new XmlReflectionImporter().ImportTypeMapping(typeof(Animal));
         exporter.ExportTypeMapping(mapping);
         var schemaWriter = new StringWriter();
         foreach (XmlSchema schem in schema)
         {
             schem.Write(schemaWriter);
         }
         await using (var file = new StreamWriter("Animal.xml", false))
         {
             await file.WriteLineAsync(schemaWriter.ToString());
         }
         schema.Clear();
         exporter = new XmlSchemaExporter(schema);
         mapping = new XmlReflectionImporter().ImportTypeMapping(typeof(Lion));
         exporter.ExportTypeMapping(mapping);
         schemaWriter = new StringWriter();
         foreach (XmlSchema schem in schema)
         {
             schem.Write(schemaWriter);
         }
         Console.WriteLine(schemaWriter.ToString());
         await using (var file = new StreamWriter("Lion.xml", false))
         {
             await file.WriteLineAsync(schemaWriter.ToString());
         }
    }
} 