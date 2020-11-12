namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.Resimler")]
    public partial class Resimler
    {
        public int Id { get; set; }

        public int? KonuID { get; set; }

        public string Resim { get; set; }

        public virtual Konular Konular { get; set; }
    }
}
