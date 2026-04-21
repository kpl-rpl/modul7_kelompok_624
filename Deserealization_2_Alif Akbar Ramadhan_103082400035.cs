using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Deserealization_2_Alif Akbar Ramadhan_103082400035
{
    public string nim { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public int age { get; set; }
    public string gender { get; set; }

    // 🔹 Method untuk baca JSON + buat object + print
    public static void ReadJSON()
    {
        string path = "jurnal7_2_103082400035.json";

        string jsonString = File.ReadAllText(path);

        // 🔹 Deserialization + pembuatan object DI SINI
        List<Deserealization_2_Alif Akbar Ramadhan_103082400035> members =
            JsonSerializer.Deserialize<List<Deserealization_2_Alif Akbar Ramadhan_103082400035>>(jsonString);

        Console.WriteLine("Team member list:");

        foreach (var m in members)
        {
            Console.WriteLine($"{m.nim} {m.firstname} {m.lastname} {m.age} {m.gender}");
        }
    }
}
