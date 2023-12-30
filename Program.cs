using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia");
Smartphone Nokia = new Nokia (numero: "1234", modelo: "tijolão", imei: "147741", memoria: 82 );
Nokia.Ligar();
Nokia.InstalarAplicativo("Zap Zap");
Console.WriteLine (" \n");
Console.WriteLine("Celular Iphone");
Smartphone Iphone = new Iphone (numero: "5678", modelo: "32 Pro Max", imei: "789654123", memoria: 100000 );
Iphone.Ligar();
Iphone.InstalarAplicativo("Zap Zap Premium plus");