using System;

namespace ÚjMoe {
    class Print {
        private string Vonal() {
            // VONAL MEGRAJZOLÁSA
            string vonal = "";
            for(long i = 0; i < Console.LargestWindowWidth/3; i++) {
                vonal += "\u2014";
            }
            return vonal;
        }
        public void HibaKiíró(byte hibakód) {
            string vonal = Vonal();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vonal + "\n" + vonal);
            // HIBA KIÍRÁSA
            switch(hibakód) {
                case 0: 
                    Console.WriteLine("Nem opció...");
                    break;
                case 1:
                    Console.WriteLine("Hibás bemenet...");
                    break;
            }
            Console.WriteLine(vonal + "\n" + vonal);
            Console.ResetColor();
            Console.Beep();
            Console.ReadKey();
        }
        public void Adatbekérő() {
            // BEKÉRI A TANK NEVÉT ÉS A CSATÁK SZÁMÁT
            Console.Clear();
            Console.WriteLine("Add meg a tank adatait!");
            Console.WriteLine("\n1 - Vissza");
            Console.WriteLine(Vonal() + "\n");
            Console.Write("Tank neve: ");
            string Tank = Console.ReadLine();
        }
    }
}