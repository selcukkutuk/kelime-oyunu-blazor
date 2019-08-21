using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kelime_oyunu_blazor
{
    public class Soru
    {
        public string SoruMetni { get; set; }
        public string Cevap { get; set; }
        public bool Soruldu { get; set; }
    }
}
