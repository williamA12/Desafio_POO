using System;
using DesafioPOO.Models;




Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");

//Intanciando Iphone

Smartphone iphone = new Iphone(numero: "999999999", modelo: "Apple iPhone 11", imei: "AY1AA1Y1A1YA", memoria: 128);
iphone.Apresentar();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");




//Intanciando Nokia

Smartphone Nokia = new Nokia(numero: "111111111", modelo: "Nokia G21", imei: "BX0BB0X0B0BX", memoria: 62);
Nokia.Apresentar();
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");
Nokia.ReceberLigacao();

Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");
