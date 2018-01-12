using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string chaineNormale = "Bonjour à tous";
        string chaineCryptee = Encodage.Crypte(chaineNormale);
        Console.WriteLine(chaineCryptee);
        chaineNormale = Encodage.Decrypte(chaineCryptee);
        Console.WriteLine(chaineNormale);
        Console.ReadKey();
    }

}

public static class Encodage
{
    public static string Crypte(string chaine)
    {
        return Convert.ToBase64String(Encoding.Default.GetBytes(chaine));
    }

    public static string Decrypte(string chaine)
    {
        return Encoding.Default.GetString(Convert.FromBase64String(chaine));
    }
}