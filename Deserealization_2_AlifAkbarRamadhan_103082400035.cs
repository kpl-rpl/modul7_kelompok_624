using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Deserealization_2_AlifAkbarRamadhan_103082400035
{
    public string nim { get; set; }

    [JsonPropertyName("firstName")]
    public string firstname { get; set; }

    [JsonPropertyName("lastName")]
    public string lastname { get; set; }

    public int age { get; set; }
    public string gender { get; set; }

    // Class pembungkus sesuai struktur JSON
    public class Root
    {
        public List<Deserealization_2_AlifAkbarRamadhan_103082400035> members { get; set; }
    }

    public static void ReadJSON()
    {
        string path = "jurnal7_2_103082400035.json";

        string jsonString = File.ReadAllText(path);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        Root data = JsonSerializer.Deserialize<Root>(jsonString, options);

        Console.WriteLine("Team member list:");

        foreach (var m in data.members)
        {
            Console.WriteLine($"{m.nim} {m.firstname} {m.lastname} {m.age} {m.gender}");
        }
    }
}
