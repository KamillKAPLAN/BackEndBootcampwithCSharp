using System;

namespace BootcampAPI.Models.TPH
{
    public abstract class FaturaDetayi
    {
        public int Id { get; set; }
        public string FaturaSahibi { get; set; }
        public string FaturaAdi { get; set; }
    }
}
