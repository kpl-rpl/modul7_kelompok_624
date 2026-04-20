using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Jurnal7
{
    public class GlossaryItem
    {
        public GlossaryData glossary { get; set; }

        public static void ReadJSON()
        {
            string fileName = "jurnal7_3_103082400013.json";

            try
            {
                string jsonString = File.ReadAllText(fileName);
                GlossaryItem data = JsonSerializer.Deserialize<GlossaryItem>(jsonString);
                var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine("=== GlossEntry Data ===");
                Console.WriteLine($"ID           : {entry.ID}");
                Console.WriteLine($"SortAs       : {entry.SortAs}");
                Console.WriteLine($"GlossTerm    : {entry.GlossTerm}");
                Console.WriteLine($"Acronym      : {entry.Acronym}");
                Console.WriteLine($"Abbrev       : {entry.Abbrev}");
                Console.WriteLine($"Definition   : {entry.GlossDef.para}");
                Console.WriteLine($"See Also     : {string.Join(", ", entry.GlossDef.GlossSeeAlso)}");
                Console.WriteLine($"GlossSee     : {entry.GlossSee}");
                Console.WriteLine("========================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public class GlossaryData
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }
}