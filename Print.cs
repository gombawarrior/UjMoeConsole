using System;

namespace ÚjMoe {
    class Print {
        public void HibaKiíró(byte hibakód) {
            Console.ForegroundColor = ConsoleColor.Red;
            // VONAL MEGRAJZOLÁSA
            string vonal = "";
            for(long i = 0; i < Console.LargestWindowWidth/3; i++) {
                vonal += "\u2014";
            }
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
    }
}