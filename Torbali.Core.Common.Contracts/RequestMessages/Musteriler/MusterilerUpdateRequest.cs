namespace Torbali.Core.Common.Contracts.RequestMessages.Musteriler
{
    public class MusterilerUpdateRequest: MusterilerRequest
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public decimal? EnDusukFiyat { get; set; }
        public decimal? EnYuksekFiyat { get; set; }
        public int? Statu { get; set; }
    }
}
