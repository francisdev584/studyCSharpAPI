using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models {
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(20,ErrorMessage ="Este campo deve conter entre 3 e 20 caracteres")]
        [MinLength(3,ErrorMessage ="Este campo deve conter entre 3 e 20 caracteres")]
        public String  Username { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(20,ErrorMessage ="Este campo deve conter entre 3 e 20 caracteres")]
        [MinLength(3,ErrorMessage ="Este campo deve conter entre 3 e 20 caracteres")]
        public String  Password { get; set; }

        public String Role { get; set; }
        
    }
}