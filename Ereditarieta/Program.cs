// See https://aka.ms/new-console-template for more information

var mezzi = new List<Ereditarieta.Model.MezziTrasp>();
mezzi.Add(new Ereditarieta.Model.Auto("vW","Golf 7"));
mezzi.Add(new Ereditarieta.Model.Moto("KTM", "Super Duke 990"));
mezzi.Add(new Ereditarieta.Model.Bici("Cannondale", "Trail 8"));

foreach (var m in mezzi)
{
    if (m.UMMovimento == "Km")
    {
        m.Muoviti(10);
        if (m is Ereditarieta.Model.Veicoli)
        {
            var v = (Ereditarieta.Model.Veicoli) m;
            if (v.Marca=="KTM") Console.WriteLine("E' una KTM!");
        };
        Console.WriteLine(m.ToString());
        //m.Merci.ToLowerInvariant().StartsWith("p");
        
    };
};
