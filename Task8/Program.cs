List<string> elements = new List<string>{"Davron","Yusuf","Mustafo"};

var ele = elements.FindAll( e => e.Length == 5);
foreach (var item in ele)
{
      System.Console.WriteLine(item);
}
  
