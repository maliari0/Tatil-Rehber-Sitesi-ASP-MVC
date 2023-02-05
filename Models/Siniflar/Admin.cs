using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adını boş bırakamazsınız")]
        public string Kullanici { get; set; }
        [Required(ErrorMessage = "Şifreyi boş bırakamazsınız")]
        public string Sifre { get; set; }
    }
    public class AdminList
    {
        public Admin adminList { get; set; }
    }
}