// See https://aka.ms/new-console-template for more information

var elenco = new List<Ereditarieta.Model.iMuoviti>();
elenco.Add(new Ereditarieta.Model.Auto("vW","Golf 7"));
elenco.Add(new Ereditarieta.Model.Moto("KTM", "Super Duke 990"));
elenco.Add(new Ereditarieta.Model.Bici("Cannondale", "Trail 8"));
elenco.Add(new Ereditarieta.Model.Persone("Barbarini", "Federico", "Casteggio", 19780623));

foreach (var i in elenco)
{
    if (i is Ereditarieta.Model.MezziTrasp)
    {
        var m = (Ereditarieta.Model.MezziTrasp)i;
        if (m.UMMovimento == "Km")
        {
            if (m is Ereditarieta.Model.Veicoli)
            {
                var v = (Ereditarieta.Model.Veicoli)m;
                if (v.Marca == "KTM") Console.WriteLine("E' una KTM!");
            };
            i.Muoviti(10);
            Console.WriteLine(i.ToString());
        };

    } else {
        i.Muoviti(1);
        Console.WriteLine(i.ToString());
    };
};
