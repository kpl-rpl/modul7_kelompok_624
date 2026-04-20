using System;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        ReadJSON();
    }

    public static void ReadJSON()
    {
        string fileName = "jurnal7_3_103082400013.json";
        
        try
        {
            string jsonString = File.ReadAllText(fileName);
            GlossaryItem data = JsonConvert.DeserializeObject<GlossaryItem>(jsonString);
            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;
            
            Console.WriteLine("=== Hasil Deserialisasi GlossEntry ===");
            Console.WriteLine($"ID        : {entry.ID}");
            Console.WriteLine($"Term      : {entry.GlossTerm}");
            Console.WriteLine($"Acronym   : {entry.Acronym}");
            Console.WriteLine($"Definition: {entry.GlossDef.para}");
            Console.Write("See Also  : ");
            Console.WriteLine(string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine("======================================");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}