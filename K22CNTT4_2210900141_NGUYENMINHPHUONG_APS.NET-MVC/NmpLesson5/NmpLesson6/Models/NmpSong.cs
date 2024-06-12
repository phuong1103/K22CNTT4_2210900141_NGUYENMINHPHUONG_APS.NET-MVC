using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NmpLesson6.Models
{
    public class NmpSong
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Nmp: hay nhap tieu de")]
        [DisplayName("Tieu de")]
        
        public string NmpTitle { get; set; }


        [Required(ErrorMessage = "Nmp: hay nhap tac gia")]
        [DisplayName("Tac gia")]
        public string NmpAuthor { get; set; }

        [Required(ErrorMessage = "Nmp: hay nhap nghe si")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Nmp: Ten nghe si co toi thieu 2 ki tu, toi da 50 ki tu")]
        [DisplayName("Nghe si")]

        public string NmpArtist { get; set; }


        [Required(ErrorMessage = "Nmp: hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Nmp: Nam xuat ban phai co 2 ki tu so")]
        [Range(1900,2024,ErrorMessage =" Nmp: nam xuat ban trong khoang 1900-2024")]
        [DisplayName("Nam xuat ban")]
        public int NmpYearRelease { get;set; }
    }
}