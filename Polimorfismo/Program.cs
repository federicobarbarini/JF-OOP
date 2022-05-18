// See https://aka.ms/new-console-template for more information
Console.WriteLine("Polimorfismo");

var figure = new List<Polimorfismo.Model.iArea>();
figure.Add(new Polimorfismo.Model.Quadrato() { Base = 2});
figure.Add(new Polimorfismo.Model.Rettangolo() { Base = 2, Altezza = 3 });
figure.Add(new Polimorfismo.Model.Triangolo() { Base = 2, Altezza = 3 });
figure.Add(new Polimorfismo.Model.Cerchio() { Raggio = 3 });

foreach (var i in figure)
{
    Console.WriteLine("Nome: {0} - Area: {1}", i.GetType().FullName, i.CalcolaArea());
};