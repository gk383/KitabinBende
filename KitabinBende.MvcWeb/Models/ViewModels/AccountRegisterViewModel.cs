using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required (ErrorMessage ="Zorunlu alan.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan.")]
        [DataType(DataType.Password, ErrorMessage = "Şifre giriniz")]
        [MinLength(6,ErrorMessage ="En az 6 karakter")]
        [MaxLength(16, ErrorMessage = "En fazla 16 karakter")]
        public string Password { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        [DataType(DataType.Password,ErrorMessage ="Şifre giriniz")]
        [Compare("Password",ErrorMessage ="Şifre aynı olmalı")]
        public string ConfirmPassword { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        public string FirstName { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        public string LastName { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        [DataType(DataType.Date,ErrorMessage ="Bir tarih giriniz")]
        public DateTime BirthDate { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        public byte GenderId { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Telefon numarası giriniz")]
        public string Phone { get; set; }
        [Required (ErrorMessage ="Zorunlu Alan.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="E-Mail adresi giriniz")]
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

    }
}
