// See https://aka.ms/new-console-template for more information

using modul5_103082400005;

public class Program()
{
    public static void Main()
    {
        SimpleDataBase<int> simpleDataBase = new();
        simpleDataBase.AddNewData(12);
        simpleDataBase.AddNewData(34);
        simpleDataBase.AddNewData(56);

        simpleDataBase.PrintAllData();
    }
}