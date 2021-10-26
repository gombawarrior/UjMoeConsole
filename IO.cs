using System;
using System.Collections.Generic;
using System.IO;

namespace ÚjMoe {
    class IO {
        private string bázisÖsvény;
        private StreamReader sr;
        private StreamWriter sw;
        private List<Tár> lista;
        public IO() {
            // ADATBÁZIS ÖSVÉNYE
            bázisÖsvény = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/ÚjMoe";
            // IO INICIALIZÁLÁSA
            Directory.CreateDirectory(bázisÖsvény);
            sw = new StreamWriter(bázisÖsvény + "/bázis");
            sr = new StreamReader(bázisÖsvény + "/bázis");
            lista = new List<Tár>();
        }
        private void FájlbaÍrás() {
            // LISTA FÁJLBA ÍRÁSA
            for (int i = 0; i < lista.Count; i++) {
                sw.WriteLine($"{lista[i].tankNév}${lista[i].elsőMark}${lista[i].másodikMark}${lista[i].harmadikMark}${lista[i].százMark}");
            }
        }
    }
}