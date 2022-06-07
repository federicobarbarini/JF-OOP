using System;
using Game.ORM;

namespace Game // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var JF = Context.Load("JF");
            JF.Distinta();
            Context.Save(JF);



            //if (JF.Titolari.Count() != 0)
            //{
            //    Console.WriteLine("Quale giocatore vuoi spostare?");
            //    var r = Console.ReadLine();
            //    var giocatore_selezionato=(from x in JF.Titolari where x.Nome == r select x).FirstOrDefault();
            //    if (giocatore_selezionato != null)
            // {
            //        Console.WriteLine("Come vuoi spostare il giocatore? (es: su + 10)");
            //        var y = Console.ReadLine();
            //        var comando = y.Split("+".ToCharArray().FirstOrDefault()).FirstOrDefault().Trim().ToLower();
            //        var passi = y.Split("+".ToCharArray().FirstOrDefault()).LastOrDefault().Trim().ToLower();
            //        if (comando == "su")
            //        {
            //            passi = passi.ToUpperInvariant();
            //            giocatore_selezionato.Su(2);
            //        }
            //        if (comando == "giu")
            //        {
            //            passi = passi.ToUpperInvariant();
            //            giocatore_selezionato.Giu(2);
            //        }
            //        if (comando == "destra")
            //        {
            //            passi = passi.ToUpperInvariant();
            //            giocatore_selezionato.Destra(2);
            //        }
            //        if (comando == "sinistra")
            //        {
            //            passi = passi.ToUpperInvariant();
            //            giocatore_selezionato.Sinistra(2);
            //        }
            //
            //    }
            //}


            //JF.Su(3);
        }
    }
}


