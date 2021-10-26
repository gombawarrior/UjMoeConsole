using System;
using System.IO;

namespace ÚjMoe {
    class IO {
        private string bázisÖsvény {get;set;}
        private StreamReader sr;
        private StreamWriter sw;
        public IO() {
            // ADATBÁZIS ÖSVÉNYE
            bázisÖsvény = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/ÚjMoe";
            // IO INICIALIZÁLÁSA
            Directory.CreateDirectory(bázisÖsvény);
            sw = new StreamWriter(bázisÖsvény + "/bázis");
            sr = new StreamReader(bázisÖsvény + "/bázis");
        }
        
    }
}