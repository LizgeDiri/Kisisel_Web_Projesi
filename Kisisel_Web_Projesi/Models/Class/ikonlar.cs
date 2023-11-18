using System.ComponentModel.DataAnnotations;


namespace Kisisel_Web_Projesi.Models.Class
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}