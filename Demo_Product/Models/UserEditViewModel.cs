﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisim Giriniz.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet Seçiniz.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen Girilen Şifreler Eşleşsin.")]
        public string ConfirmPassword { get; set; }



    }
}
