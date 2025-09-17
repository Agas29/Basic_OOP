using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    static void Main(string[] args)
    {
        fighter fighter1 = new fighter();
        fighter1.name = "Al-Haytam";
        fighter1.str = 20;
        fighter1.level = "10";

        Console.Write($"{fighter1.profil()}");

        fighter1.LevelUp(25, "11");
    }

}
public class fighter
{
    private string name;
    public int str;
    public string level;

    private string gold;
    private bool online;
    public class GetName()
    {
        return name;
    }
    public string profil()
    {
        return $"saya : {name} \nStrength : {str}\n";
    }
    public void LevelUp(int str, string level)
    {
        this.str = str;
        this.level = level;

        Console.WriteLine("Selamat, anda naik level!!");
        Console.WriteLine($"Strength : {str}");
        Console.WriteLine($"Level    : {level}");
    }
}