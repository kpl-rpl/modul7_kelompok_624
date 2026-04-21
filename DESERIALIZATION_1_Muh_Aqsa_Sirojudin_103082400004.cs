using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DESERIALIZATION_1_Muh_Aqsa_Sirojudin_103082400004
{
    public class Address
    {
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }

    public class Course
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Mahasiswa
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("courses")]
        public List<Course> Courses { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "jurnal7_1_103082400004.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File JSON tidak ditemukan.");
            return;
        }

        string jsonString = File.ReadAllText(filePath);

        Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine("=== HASIL DESERIALISASI JSON ===");
        Console.WriteLine($"Nama           : {data.FirstName} {data.LastName}");
        Console.WriteLine($"Gender         : {data.Gender}");
        Console.WriteLine($"Umur           : {data.Age}");
        Console.WriteLine("Alamat         :");
        Console.WriteLine($"  Jalan        : {data.Address.StreetAddress}");
        Console.WriteLine($"  Kota         : {data.Address.City}");
        Console.WriteLine($"  Provinsi     : {data.Address.State}");

        Console.WriteLine("Mata Kuliah    :");
        foreach (var course in data.Courses)
        {
            Console.WriteLine($"  - {course.Code} : {course.Name}");
        }

        Console.WriteLine("=== SELESAI ===");
    }
}
