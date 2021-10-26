using System;

namespace ÚjMoe {
    class Program {
        private static void Main() {
            // HIBAKIÍRÓ
            Print hibázás = new Print();
            // FŐMENÜ CIKLUSA
            #region Főmenü
            bool kilépés = false;
            do {
            Console.Clear();
            // ALAP KIÍRATÁSOK
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Jónapot a MoeMod 2.0-ban!");
            Console.WriteLine("\n1 - Megjelenítés\n2 - Adatbevitel\n3 - Visszaállítás\n4 - Kilépés");
            Console.WriteLine("\nÍrj egy számot!");
            Console.WriteLine(". . .");
            // FŐMENÜ OPCIÓJA
            if (byte.TryParse(Console.ReadLine(), out byte főmenüÉrték))
                switch (főmenüÉrték) {
                    // MEGJELENÍTÉS
                    case 1:
                        break;
                    // ADATBÁZIS FELTÖLTÉSE
                    case 2:
                        break;
                    // TÖRLÉS
                    case 3:
                        break;
                    // KILÉPÉS
                    case 4:
                        kilépés = true;
                        break;
                    // NEM OPCIÓ
                    default:
                        hibázás.HibaKiíró(0);
                        break;
                }
                // NEM SZÁM
                else {
                    hibázás.HibaKiíró(1);
                }
            } while (!kilépés);
            Console.Clear();
            #endregion
        }
    }
}
