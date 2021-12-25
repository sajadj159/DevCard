using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [MinLength(3, ErrorMessage = "حداقل باید بیشتر از 3 کارکتر باشد")]
        [MaxLength(100, ErrorMessage = "این فیلد نباید بیشتر از 100 کارکتر باشد")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress(ErrorMessage = "ایمیل به درستی وارد نشده است")]
        public string Email { get; private set; }

        public string Message { get; private set; }
        public int Service { get; private set; }

        public SelectList Services { get;  set; }


        public Contact(string name, string email, string message, int service,SelectList services)
        {
            Name = name;
            Email = email;
            Message = message;
            Service = service;
            Services = services;
        }

        public Contact()
        {
             
        }
    }
}