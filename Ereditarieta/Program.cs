using Ereditarieta;
// See https://aka.ms/new-console-template for more information

var elenco = new List<Ereditarieta.Model.iEntity>();
elenco.Add(new Ereditarieta.Model.Auto("vW","Golf 7"));
elenco.Add(new Ereditarieta.Model.Auto("vW", "Golf 8"));
elenco.Add(new Ereditarieta.Model.Moto("KTM", "Super Duke 990"));
elenco.Add(new Ereditarieta.Model.Moto("KTM", "Super Duke 1390"));
elenco.Add(new Ereditarieta.Model.Bici("Cannondale", "Trail 8"));
elenco.Add(new Ereditarieta.Model.Persone("Barbarini", "Federico", "Casteggio", 19780623));


var ctx = new Ereditarieta.ORM.Context(@"C:\JobFactory\");
ctx.Save<Ereditarieta.Model.Auto>(elenco);
ctx.Save<Ereditarieta.Model.Moto>(elenco);
ctx.Save<Ereditarieta.Model.Bici>(elenco);
ctx.Save<Ereditarieta.Model.Persone>(elenco);

//foreach (var e in elenco)
//{
//    if (i is Ereditarieta.Model.iMuoviti)
//        if (i is Ereditarieta.Model.MezziTrasp)
//    {
//        var m = (Ereditarieta.Model.MezziTrasp)i;
//        if (m.UMMovimento == "Km")
//        {
//            if (m is Ereditarieta.Model.Veicoli)
//            {
//                var v = (Ereditarieta.Model.Veicoli)m;
//                if (v.Marca == "KTM") Console.WriteLine("E' una KTM!");
//            };
//            i.Muoviti(10);
//            Console.WriteLine(i.ToString());
//        };
//
//    } else {
//        i.Muoviti(1);
//        Console.WriteLine(i.ToString());
//    };
//};
