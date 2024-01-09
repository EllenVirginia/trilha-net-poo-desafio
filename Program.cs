using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"112222", modelo: "Modelo 8", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Genshin Impact");

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"256398", modelo: "Modelo 7", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Stardew Valley");