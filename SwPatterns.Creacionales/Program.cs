// See https://aka.ms/new-console-template for more information
using SwPatterns.Creacionales;


var key = "conn";
SingletonConfiguration singleton = SingletonConfiguration.GetInstance();
var strConn = singleton.configuration.GetValueOrDefault(key);
Console.WriteLine(strConn);
Console.WriteLine(SingletonConfiguration.GetInstance().configuration.GetValueOrDefault("path"));

Client.Run();