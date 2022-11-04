using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampAPI.Models.TPH
{
    [Table("CreeditAcount")]
    public class BankaHesabi : FaturaDetayi
    {
        public int KartTipi { get; set; }
        public string SonaErmeAyi { get; set; }
        public string SonaErmeYili { get; set; }

    }
}
