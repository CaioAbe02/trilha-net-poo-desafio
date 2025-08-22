using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone (CONCLUÍDO!)
Console.WriteLine("-== NOKIA =--");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Tijolo", imei: "1111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n-== IPhone ==-");
Smartphone iphone = new Iphone(numero: "123456", modelo: "IPhone 16", imei: "2222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");