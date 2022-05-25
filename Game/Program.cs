// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
{
    Delimiter = ";"
};

using (var r = new System.IO.StreamReader(System.IO.Path.Combine("../../../dati", "portieri.csv"))) {
    using (var c = new CsvHelper.CsvReader(r, config))
    {
        var p = c.GetRecords<Game.Model.Portiere>().ToArray();

    };
};





var S = new Game.Model.Squadra() { Nome = "JF" };
S.Add(new Game.Model.Portiere() { Nome = "Mike Maignan" });
