
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = "D:\\kamran uet\\2nd sem\\OOP\\TR1.cs\\TR1.cs\\textfile.txt";
        StreamWriter filevariable = new StreamWriter(path);
        filevariable.WriteLine("Hello");
        filevariable.Flush();
        filevariable.Close();

    }
}