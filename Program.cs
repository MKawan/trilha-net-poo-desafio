using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "62997856921", modelo: "Modelo 1", imei: "494949494191919", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Cod");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "61989572514", modelo: "Modelo 2", imei: "444449494494948", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Warface");

