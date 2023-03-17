
using Bridge.Logic;

Console.WriteLine("ingrese la estructura de su puente");
string? theBridge = Console.ReadLine();
var mybridge = new MyBridge($"{theBridge}");

Console.WriteLine(mybridge.IsValide());