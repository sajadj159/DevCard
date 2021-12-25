using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [MinLength(3, ErrorMessage = "حداقل باید بیشتر از 3 کارکتر باشد")]
        [MaxLength(100, ErrorMessage = "این فیلد نباید بیشتر از 100 کارکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress(ErrorMessage = "ایمیل به درستی وارد نشده است")]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Service { get; set; }

        public Contact(string name, string email, string message, string service)
        {
            Name = name;
            Email = email;
            Message = message;
            Service = service;
        }

        public Contact()
        {
             
        }
    }
}