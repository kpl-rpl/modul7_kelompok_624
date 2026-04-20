using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Member
{
    public string nim { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
}

public class TeamData
{
    public List<Member> members { get; set; }
}

public class TeamMembers103082400035
{
    public void ReadJSON()
    {
        string fileName = "jurnal7_2_103082400035.json";

        try
        {
            string jsonString = File.ReadAllText(fileName);

            TeamData team = JsonSerializer.Deserialize<TeamData>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{fileName}' tidak ditemukan. Pastikan file ada di folder yang sama dengan program (.exe).");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat parsing JSON: {ex.Message}");
        }
    }
}