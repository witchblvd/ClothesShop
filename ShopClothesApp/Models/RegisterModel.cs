using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ShopClothesApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Это поле должно быть обязательно заполнено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите полное имя")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите полную фамилию")]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите полное отчество")]
        public string Patronymic { get; set; }

        public string number { get; set; }

        [StringLength(50, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть длинее 8 символов")]
        public string password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }

        public string Address { get; set; }
       
    }
}
