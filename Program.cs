using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia01 = new Nokia(numero: "998765432", modelo: "NKA-01", imei: "777777", memoria: 128);
Iphone iphone01 = new Iphone(numero: "112345678", modelo: "IAP-01", imei: "333333", memoria: 128);

nokia01.Ligar(numero: "112345678");
nokia01.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("______________");
Console.WriteLine("Smartphone Iphone:");

iphone01.Ligar(numero: "998765432");
iphone01.InstalarAplicativo(nomeApp: "Gmail");

iphone01.Ligar(numero: "00000"); //Ligando para número inexistente

Console.WriteLine("______________");

Smartphone.consultarSmartphonesCadastrados();


