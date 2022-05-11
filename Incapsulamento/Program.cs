// See https://aka.ms/new-console-template for more information

var mezzi = new List<Incapsulamento.MezziTrasp>();
mezzi.Add(new Incapsulamento.MezziTrasp("pippo"));
mezzi.Add(new Incapsulamento.MezziTrasp() { UMMovimento = "Km",
                                            Merci = "Pipp2", 
                                            Carburante = "Gasolio" });
mezzi.Add(new Incapsulamento.MezziTrasp() { UMMovimento = "m", 
                                            Merci = "Pippa", 
                                            Carburante = "acqua" });

foreach (var m in mezzi) {
    if (m.UMMovimento == "Km")
    {
        //m.Merci.ToLowerInvariant().StartsWith("p");
        m.Muoviti(10);
        Console.WriteLine(m.ToString());
    };
};

var t1 = new Incapsulamento.Test();
Console.WriteLine("Incrementa +1: {0}", t1.Incrementa(1));
Console.WriteLine("Incrementa +2: {0}", t1.Incrementa(2));
Console.WriteLine("Incrementa +3: {0}", t1.Incrementa(3));
Console.ReadLine();

var t2 = new Incapsulamento.Test2();
Console.WriteLine("Incrementa +1: {0}", t2.Incrementa(1));
Console.WriteLine("Incrementa +2: {0}", t2.Incrementa(2));
Console.WriteLine("Incrementa +3: {0}", t2.Incrementa(3));
Console.WriteLine("Decrementa -1: {0}", t2.Decrementa(1));
Console.WriteLine("Decrementa -2: {0}", t2.Decrementa(2));
Console.WriteLine("Decrementa -3: {0}", t2.Decrementa(3));
Console.ReadLine();

var t3 = new Incapsulamento.Test3();
Console.WriteLine("Incrementa +1: {0}", t3.Incrementa(1));
Console.WriteLine("Incrementa +2: {0}", t3.Incrementa(2));
Console.WriteLine("Incrementa +3: {0}", t3.Incrementa(3));
Console.WriteLine("Decrementa -1: {0}", t3.Decrementa(1));
Console.WriteLine("Decrementa -2: {0}", t3.Decrementa(2));
Console.WriteLine("Decrementa -3: {0}", t3.Decrementa(3));
Console.WriteLine("Incrementa +1: {0}", t3.Incrementa(1));
Console.WriteLine("Moltiplica *2: {0}", t3.Moltiplica(2));
Console.WriteLine("Moltiplica *2: {0}", t3.Moltiplica(2));
Console.ReadLine();
