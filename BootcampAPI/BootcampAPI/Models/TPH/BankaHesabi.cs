using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampAPI.Models.TPH
{
    [Table("BankAcount")]
    public class BankaHesabi : FaturaDetayi
    {
        public string BankaAdi { get; set; }
    }
}
