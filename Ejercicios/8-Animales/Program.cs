using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro("Enzo",4);
            p.MetodoPerro();
            Console.WriteLine("Nombre del perro: " + p.Nombre);
            Console.WriteLine("Numero de patas: " + p.Patas);
            Console.WriteLine("Come? " + p.Comer);
            Console.WriteLine("Bebe agua? " + p.TomarAgua);
            Console.WriteLine("Duerme? " + p.Dormir);
            Console.WriteLine("Puede caminar? " + p.Caminar);
            Console.WriteLine("Muerde? " + p.Muerden);
            Console.WriteLine("Ladra? " + p.Ladrar);
            Console.WriteLine("Aulla? " + p.Aullan);
            Console.WriteLine("");

            Aguila a = new Aguila("Luna","Cafe y Blanco");
            a.MetodoAguila();
            Console.WriteLine("Nombre del aguila: " + a.Nombre);
            Console.WriteLine("Color de Plumaje: " + a.ColorPlumaje);
            Console.WriteLine("Come? " + a.Comer);
            Console.WriteLine("Bebe agua? " + a.TomarAgua);
            Console.WriteLine("Duerme? " + a.Dormir);
            Console.WriteLine("Puede volar? " + a.Volar);
            Console.WriteLine("Pone huevos? " + a.PonenHuevos);
            Console.WriteLine("Vuela alto? " + a.VolarAlto);
            Console.WriteLine("");
           
            PezGlobo pg = new PezGlobo("Puas",8);
            pg.MetodoPezGlobo();
            Console.WriteLine("Nombre del pez globo: " + pg.Nombre);
            Console.WriteLine("Numero de aletas: " + pg.NumeroAletas);
            Console.WriteLine("Come? " + pg.Comer);
            Console.WriteLine("Bebe agua? " + pg.TomarAgua);
            Console.WriteLine("Duerme? " + pg.Dormir);
            Console.WriteLine("Puede nadar? " + pg.Nadar);
            Console.WriteLine("Puede inflarse? " + pg.Inflarse);
            Console.WriteLine("Es venenoso? " + pg.Venenoso);
            Console.WriteLine("");

            Gato g = new Gato("Michi",4);
            g.MetodoGato();
            Console.WriteLine("Nombre del gato: " + g.Nombre);
            Console.WriteLine("Numero de patas: " + g.Patas);
            Console.WriteLine("Come? " + g.Comer);
            Console.WriteLine("Bebe agua? " + g.TomarAgua);
            Console.WriteLine("Duerme? " + g.Dormir);
            Console.WriteLine("Puede caminar? " + g.Caminar);
            Console.WriteLine("Muerde? " + g.Muerden);
            Console.WriteLine("Maulla? " + g.Maullar);
            Console.WriteLine("Ronronea? " + g.Ronronear);
            Console.WriteLine("");

            Mono m = new Mono("Cesar",2);
            m.MetodoMono();
            Console.WriteLine("Nombre del mono: " + m.Nombre);
            Console.WriteLine("Numero de patas: " + m.Patas);
            Console.WriteLine("Come? " + m.Comer);
            Console.WriteLine("Bebe Agua? " + m.TomarAgua);
            Console.WriteLine("Duerme? " + m.Dormir);
            Console.WriteLine("Puede caminar? " + m.Caminar);
            Console.WriteLine("Maulla? " + m.Maullar);
            Console.WriteLine("Son Violentos? " + m.Violentos);
            Console.WriteLine("");
            
            Loro l = new Loro("Gring","Amarillo, verde y rojo");
            l.MetodoLoro();
            Console.WriteLine("Nombre del Loro: " + l.Nombre);
            Console.WriteLine("Color de Plumaje: " + l.ColorPlumaje);
            Console.WriteLine("Come? " + l.Comer);
            Console.WriteLine("Bebe agua? " + l.TomarAgua);
            Console.WriteLine("Duerme? " + l.Dormir);
            Console.WriteLine("Puede volar? " + l.Volar);
            Console.WriteLine("Pone huevos? " + l.PonenHuevos);
            Console.WriteLine("Puede hablar? " + l.Hablar);
            Console.WriteLine("");
        }
    }
}
