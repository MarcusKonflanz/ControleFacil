using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Domain.Models
{
    public class Usuario
    {   
        [Key]
        public long Id {get; set; }
        [Required]
        public string Email {get; set; }




    }
}