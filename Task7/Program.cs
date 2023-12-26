List<string> ele = new List<string>{"Davron","Yusuf","Mustafo"};

ele.RemoveAt(0);

foreach (var item in ele)
{
    System.Console.WriteLine(item);
}