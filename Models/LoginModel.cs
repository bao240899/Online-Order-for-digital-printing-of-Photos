using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Order_for_digital_printing_of_Photos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your UserName")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string userPwd { get; set; }
    }
}