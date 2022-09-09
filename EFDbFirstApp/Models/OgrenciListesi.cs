using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class OgrenciListesi
    {
        public int OgrenciId { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string? Country { get; set; }
    }
}
